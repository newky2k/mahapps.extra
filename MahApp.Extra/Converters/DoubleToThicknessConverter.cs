using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace MahApps.Extra.Converters
{
    public sealed class DoubleToThicknessConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is double))
            {
                return DependencyProperty.UnsetValue;
            }

            var parameters = parameter as string;
            if (parameters != null)
            {
                var propertyNames = parameters.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                if (propertyNames.Length > 0)
                {
                    var thickness = new Thickness(0);

                    var changed = false;

                    foreach (var propertyName in propertyNames)
                    {
                        switch (propertyName)
                        {
                            case "Left":
                                thickness.Left = (double)value;
                                changed = true;
                                break;
                            case "Top":
                                thickness.Top = (double)value;
                                changed = true;
                                break;
                            case "Right":
                                thickness.Right = (double)value;
                                changed = true;
                                break;
                            case "Bottom":
                                thickness.Bottom = (double)value;
                                changed = true;
                                break;
                        }
                    }

                    if (changed)
                    {
                        return thickness;
                    }
                }
            }

            return new Thickness((double)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is Thickness))
            {
                return DependencyProperty.UnsetValue;
            }

            var thickness = (Thickness)value;

            var propertyName = parameter as string;
            switch (propertyName)
            {
                case "Left":
                    return thickness.Left;
                case "Top":
                    return thickness.Top;
                case "Right":
                    return thickness.Right;
                case "Bottom":
                    return thickness.Bottom;
                default:
                    return (thickness.Left + thickness.Top + thickness.Bottom + thickness.Right) / 4;
            }
        }
    }
}
