using MahApps.Extra.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MahApps.Extra
{
    public class ExtrasThemeManager
    {
        private static readonly Uri CommonUiDictionaryUri = new Uri("/MahApps.Extra;component/Themes/Generic.xaml", UriKind.Relative);

        public static void RegisterThemes(ResourceDictionary resourceDictionary)
        {
            if (!resourceDictionary.MergedDictionaries.Any(x => x.Source == CommonUiDictionaryUri))
            {
                var sharedResourceDictionary = new SharedResourceDictionary()
                {
                    Source = CommonUiDictionaryUri.ToString()
                };

                resourceDictionary.MergedDictionaries.Add(sharedResourceDictionary);
            }
        }

    }
}

