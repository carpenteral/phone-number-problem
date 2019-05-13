using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utils {
    public class PostcodeUtils {

        public static bool IsValid(string strPostCode) {
            if (strPostCode.StartsWith("AB")) {
                return false;
            }

            string[] singleDigitPostCodeAreas = { "BR", "FY", "HA", "HD", "HG", "HR", "HS", "HX", "JE", "LD", "SM", "SR", "WC", "WN", "ZE" };
            foreach (string area in singleDigitPostCodeAreas)
            {
                if(strPostCode.StartsWith(area) && strPostCode.IndexOf(' ') > 3)
                {
                    return false;
                }
            }

            string[] doubleDigitPostCodeAreas = { "AB", "LL", "SO" };
            foreach (string area in doubleDigitPostCodeAreas)
            {
                if(strPostCode.StartsWith(area) && strPostCode.IndexOf(' ') == 3)
                {
                    return false;
                }
            }

                return true;
        }

    }
}
 