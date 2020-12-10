#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace NullablePresentation
{
    public static class Helpers
    {
        public static bool IsStringNullOrEmpty([NotNullWhen(true)]string? s) // bug on attribute => false and true are exchanged
        {
            return string.IsNullOrEmpty(s);
        }
    }
}
