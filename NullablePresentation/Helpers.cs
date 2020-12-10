#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace NullablePresentation
{
    public static class Helpers
    {
        public static bool IsStringNullOrEmpty([NotNullWhen(false)]string? s) 
          => string.IsNullOrEmpty(s);
    }
}
