using System;

namespace Делегаты
{
    class Program
    {
       
        
            private delegate double DelegateM(double x);
        static void Main(string[] args)
        {
            DelegateM[] arr = new DelegateM[10];
            Random rnd = new Random();
            Methods methods = new Methods();
            for (int i = 0; i < 10; i++)
            {
                int a = Convert.ToInt32(rnd.Next(1, 5));
                switch (a)
                {
                    case 1:
                        arr[i] = methods.Add;
                        break;
                    case 2:
                        arr[i] = methods.Multiply;
                        break;
                    case 3:
                        arr[i] = methods.Division;
                        break;
                    case 4:
                        arr[i] = methods.Subtraction;
                        break;
                    case 5:
                        arr[i] = methods.Pow;
                        break;

                }
            }
            double num;
            Console.WriteLine("Введите число, над которым хотите проделать операции");
            num = double.Parse(Console.ReadLine());
            for (int j = 0; j < 10; j++)
            {
                num = arr[j](num);

            }

        }
    }
}
    

