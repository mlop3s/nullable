using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace NullablePresentation
{
    public static class Helpers
    {
        public static bool IsStringNullOrEmpty([NotNullWhen(true)]string s)
        {
            return string.IsNullOrEmpty(s);
        }
    }
}
