using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahApps.Extra.Parameters.Helpers
{
    internal static class BoxingHelper<T>
        where T : struct
    {
        internal static T Unbox(object value)
        {
            Contract.Assume(value is T);
            return (T)value;
        }
    }
}
