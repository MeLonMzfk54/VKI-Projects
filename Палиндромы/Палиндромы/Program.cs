using System;

namespace Палиндромы
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = true;
            int number;
            int choose;
            do
            {
                Console.WriteLine("Введите число, чтобы проверить является ли оно палиндромом");
                number = Int32.Parse(Console.ReadLine());
                number.Pal();
                Console.WriteLine("Продолжим?\n 1 - да \t 2 - нет");
                choose = Int32.Parse(Console.ReadLine());
                if(choose == 1)
                {
                    end = true;
                }else if(choose == 2)
                {
                    end = false;
                }
            } while (end);
        }
    }
}
