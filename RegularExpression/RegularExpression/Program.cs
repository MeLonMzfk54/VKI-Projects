using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt;

       
                using (StreamReader sr = new StreamReader("Input.txt"))
                {
                    txt = sr.ReadToEnd();
                }
                                
                Regex regex = new Regex(@"\d{2}-\d{2}-\d{4}");
                MatchCollection matches = regex.Matches(txt);
            Console.WriteLine("Все даты, которые были заменены:");
                foreach(Match match in matches)
                {
                    Console.Write(match.Value+" => ");

                    txt = txt.Remove(match.Index, match.Length);

                    txt = txt.Insert(match.Index, $"{match.Value[3]}{match.Value[4]}-{match.Value[0]}{match.Value[1]}{match.Value.Substring(5)}");
                    Console.WriteLine($"{match.Value[3]}{match.Value[4]}-{match.Value[0]}{match.Value[1] + match.Value.Substring(5)}");
                }

                using (StreamWriter sw = new StreamWriter("Output.txt", false, Encoding.Default))
                {
                    sw.WriteLine(txt);
                }
            
 

            Console.ReadKey();
        }
    }
}
