using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Windows;

namespace MahApps.Extra.Parameters.Helpers
{
    internal static class ThicknessUtil
    {
        internal static bool IsNonNegative(Thickness value)
        {
            return DoubleUtil.IsNonNegative(value.Left) &&
                   DoubleUtil.IsNonNegative(value.Top) &&
                   DoubleUtil.IsNonNegative(value.Right) &&
                   DoubleUtil.IsNonNegative(value.Bottom);
        }

        [Conditional("CONTRACTS_FULL")]
        [ContractAbbreviator]
        internal static void EnsureNonNegative()
        {
            Contract.Ensures(IsNonNegative(Contract.Result<Thickness>()));
        }

        internal static object CoerceNonNegative(DependencyObject obj, object basevalue)
        {
            ValidationHelper.NotNull(obj, "obj");
            var value = BoxingHelper<Thickness>.Unbox(basevalue);
            if (!DoubleUtil.IsNonNegative(value.Left))
            {
                value.Left = 0d;
            }
            if (!DoubleUtil.IsNonNegative(value.Top))
            {
                value.Top = 0d;
            }
            if (!DoubleUtil.IsNonNegative(value.Right))
            {
                value.Right = 0d;
            }
            if (!DoubleUtil.IsNonNegative(value.Bottom))
            {
                value.Bottom = 0d;
            }
            return value;
        }
    }
}
