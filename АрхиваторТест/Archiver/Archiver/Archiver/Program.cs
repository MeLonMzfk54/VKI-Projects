using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archiver;

namespace Archiver
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = new string('a', 150) + new string('b', 120) + new string('c', 100) + new string('d', 130) + new string('e', 280);

            Dictionary<string, int> testD = test.GetFrequencyTable();

            Console.WriteLine("Таблица частот:\n");
            foreach (var i in testD)
            {
                Console.WriteLine("Ключ - "+i.Key+" Значение - "+i.Value);
            }


            Archiver Arch = new Archiver();
            Console.WriteLine("\n\nКоды cимволов:\n");

            codes Tree =Arch.GetBinaryTree(testD);

            Tree.OutputValue();

            Console.ReadKey();
        }
    }
}
