using System;
using System.Collections.Generic;
using System.Text;

namespace Палиндромы
{
   static class palindrome
    {
        public static void Pal(this int numb)
        {
            bool check = true;
            int view = numb;
            int len = numb.ToString().Length;
            int len1 = len;
            for (int i = 1; i <= len / 2; i++)
            {
                if (numb % 10 != numb / (int)Math.Pow(10, len1 - 1))
                {
                    check = false;
                    break;
                }
                else
                {
                    check = true;
                    len1 -= 1;
                    numb/= 10;
                    numb %= (int)Math.Pow(10, len1 - 1);
                    len1 = numb.ToString().Length;
                }
            }

            if (check == true)
            {
                Console.WriteLine(view + " - палиндром");
            }
            else
            {
                Console.WriteLine(view + " - не палиндром");
            }
        }
    }
}
