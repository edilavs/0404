using System;
using System.Collections.Generic;
using System.Text;

namespace _0404
{
    public static class ExtentionMethods
    {
        public static bool IsOdd(this int number)
        {
            if (number % 2 == 1)
                return true;
            else
                return false;
        }

        public static bool IsEven(this int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }

        public static bool IsContainsDigit(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    return true;
            }
            return false;
        }

        public static string ToCapitalize(this string str)
        {
        
            if (!string.IsNullOrEmpty(str))
            {
              var words = str.Split(' ');
                var newStr = "";
                for (int i = 0; i < words.Length; i++)
                {
                    newStr += char.ToUpper(words[i][0]) + words[i].Substring(1) + ' ';
                }
                newStr = str;
            }
            return str.Trim();

        }

        public static int[] GetValueIndexes(this string str,char a)
        {
            int[] indexs = new int[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==a)
                {
                    Array.Resize(ref indexs, indexs.Length + 1);
                    indexs[indexs.Length - 1] = a;
                }
                return indexs;
            }
            return indexs;
        }
    }
}
