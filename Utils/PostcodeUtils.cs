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
            return true;
        }

    }
}
 