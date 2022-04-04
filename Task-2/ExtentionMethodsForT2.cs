using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public static class ExtentionMethodsForT2
    {
        public static bool CheckGroupNo(this string str)
        {
            if (!string.IsNullOrWhiteSpace(str) && str.Length == 4 && char.IsUpper(str[0]) && char.IsDigit(str[1]) && char.IsDigit(str[2]) && char.IsDigit(str[3]))
                return true;
            else
                return false;
        }
        public static bool CheckFullname(this string str)
        {
           str=str.Trim();
           string firstName;
           firstName = str.Substring(0, str.IndexOf(" "));
           char.IsUpper(firstName[0]);

        }
    }
}
