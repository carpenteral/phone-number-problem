using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils {
    public static class StringUtils { 
        public static string ToTitleCase(this string toConvert) {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(toConvert)
                .Replace("Van ", "van ")
                .Replace("Von ", "von ");
        }
    }
}
 