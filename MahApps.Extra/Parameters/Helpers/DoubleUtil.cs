using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MahApps.Extra.Parameters.Helpers
{
    internal static class DoubleUtil
    {

        internal static bool IsNonNegative(double value)
        {
            return !double.IsNaN(value) && !double.IsInfinity(value) && value > 0d;
        }

        [Conditional("CONTRACTS_FULL")]
        [ContractAbbreviator]
        internal static void EnsureNonNegative()
        {
            Contract.Ensures(IsNonNegative(Contract.Result<double>()));
        }

        internal static object CoerceNonNegative(DependencyObject obj, object basevalue)
        {
            ValidationHelper.NotNull(obj, "obj");
            var value = BoxingHelper<double>.Unbox(basevalue);
            return IsNonNegative(value) ? value : 0d;
        }
    }
}
