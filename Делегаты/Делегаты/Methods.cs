using System;
using System.Collections.Generic;
using System.Text;

namespace Делегаты
{
    class Methods
    {
        public double Add(double x)
        {
            double answer = x + 5;
            Console.WriteLine("Операция сложения:" + answer);
            return answer;
        }
        public double Multiply(double x)
        {
            double answer = x * 7;
            Console.WriteLine("Операция умножения:" + answer);
            return answer;
        }
        public double Subtraction(double x)
        {
            double answer = x - 3;
            Console.WriteLine("Операция вычитания:" + answer);
            return answer;
        }
        public double Division(double x)
        {
            double answer = x / 3;
            Console.WriteLine("Операция деления без остатка:" + answer);
            return answer;
        }
        public double Pow(double x)
        {
            double answer = x * x;
            Console.WriteLine("Операция квадрата:" + answer);
            return answer;
        }
    }
}
