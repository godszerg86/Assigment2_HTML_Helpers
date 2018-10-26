using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assigment2_HTML_Helpers.Classes
{
    public static class StringExtension
    {
        public static int ToDigitsOnly(this string str)
        {
            var arr = str.ToCharArray();
            var digArr = new List<char>();
            foreach (var chr in arr)
            {
                if (char.IsDigit(chr))
                {
                    digArr.Add(chr);
                }
            }
            var resStr = String.Concat(digArr);
    

            return Convert.ToInt32(resStr);
        }
    }
}