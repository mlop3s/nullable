using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullablePresentation
{
    public static class Extensions
    {
        public static bool IsStringNullOrEmpty(string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }
    }
}
