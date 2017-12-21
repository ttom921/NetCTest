using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace extensionmethodsTest
{
    public static class DateTimeExt
    {
        // 將 DateTime 物件格式化成中華民國年份的日期字串.
        public static string ToRocDateString(this DateTime date, char separator)
        {
            int year = (date.Year - 1911);
            return year.ToString() + separator + date.Month + separator + date.Day;
        }
    }
}