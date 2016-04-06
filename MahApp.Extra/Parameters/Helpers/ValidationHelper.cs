using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;


namespace MahApps.Extra.Parameters.Helpers
{
    internal static class ValidationHelper
    {
        [ContractArgumentValidator]
        internal static void NotNull<T>(T argument, string parameterName)
        {
            // ReSharper disable CompareNonConstrainedGenericWithNull
            if (argument == null)
            // ReSharper restore CompareNonConstrainedGenericWithNull
            {
                throw new ArgumentNullException(parameterName);
            }
            Contract.EndContractBlock();
        }

    }
}
