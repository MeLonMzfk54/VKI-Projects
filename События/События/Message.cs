using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace События
{
    class Message
    {
        public void txtRecord()
        {
            using (StreamWriter sw = new StreamWriter(@"zapis.txt", true, System.Text.Encoding.Default))
            {
                sw.Write("ку!");
            }
        }
    }
}
