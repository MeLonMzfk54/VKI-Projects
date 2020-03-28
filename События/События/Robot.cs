using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace События
{
    class Robot
    {

        public delegate void MethodContainer();
        public  event  MethodContainer onBack;
        public void robotMove()
        {
            Thread robotThread = new Thread(move);
            robotThread.Start();
        }

        public void move()
        {
            Random rnd = new Random();
            int randomValue;
            Thread.Sleep(100);
            for(int i = 0; i < 10; i++)
            {
                randomValue = rnd.Next(1, 4);
                switch (randomValue)
                {
                    case 1:
                        Console.WriteLine("Робот идёт вперёд");
                        break;
                    case 2:
                        Console.WriteLine("Робот идёт назад");
                        onBack();
                        break;
                    case 3:
                        Console.WriteLine("Робот идёт влево");
                        break;
                    case 4:
                        Console.WriteLine("Робот идёт вправо");
                        break;
                    default:
                        Console.WriteLine("Робот неисправен, гг!");
                        break;
                }
            }
        }

    }
}
