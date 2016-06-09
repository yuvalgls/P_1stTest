using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayoneerTest.tools
{
    class time
    {

        public static String getCurrentDate()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            return dateTime.ToString("dd/MM/yyyy");
        }
    }
}
