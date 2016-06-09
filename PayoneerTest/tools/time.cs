using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayoneerTest.tools
{
    class time
    {
        private static object localDate;

        public static String getCurrentDate()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }
    }
}
