using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayoneerTest.tools
{
    class looger
    {
        public static void Logger(String lines)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\log.txt", true);
            file.WriteLine(lines);
            file.Close();
        }
    }
}
