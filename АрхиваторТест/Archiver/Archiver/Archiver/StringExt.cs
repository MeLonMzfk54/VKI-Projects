using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archiver
{
    public static class StringExt
    {
        public static Dictionary<string, int> GetFrequencyTable(this string str)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            for (int i = 0; i < str.Length; i++)
            {
                int value;
                if (result.TryGetValue(str[i].ToString(), out value))
                {
                    result[str[i].ToString()] = value + 1;
                }
                else result.Add(str[i].ToString(), 1);
            }

            return result;
        }
    }
}
