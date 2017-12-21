using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace extensionmethodsTest
{
    public static class StringExtension
    {
        // 字串反轉
        public static string Reverse(this string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return "";
            }
            char[] charArray = new char[str.Length];
            int len = str.Length - 1;
            for (int i = 0; i <= len; i++)
            {
                charArray[i] = str[len - i];
            }
            return new string(charArray);
        }
    }
}