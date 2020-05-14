using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly ass = Assembly.LoadFrom("reflection"); 
            Console.WriteLine("Полное имя сборки - "+ass.FullName+"\n"); 
            Type[] myType = ass.GetTypes();
            foreach (Type val in myType)
            {
                Console.WriteLine("Название - "+val.Name + "\n\nМетоды: ");
                MethodInfo[] Minfo = val.GetMethods();
                foreach (MethodInfo i in Minfo)
                    Console.Write(i.ReturnType.Name + " => " + i.Name + "\n");
            }
        }
    }
}
