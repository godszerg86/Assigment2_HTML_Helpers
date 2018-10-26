using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assigment2_HTML_Helpers.Classes
{
    public static class DateTimeExtension 
    {
        public static int ToAge(this DateTime date)
        {

            TimeSpan diff = DateTime.Now - date;
            return diff.Days/365;
        }

    }
}