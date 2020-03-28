using System;

namespace События
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            Message message = new Message();
            robot.onBack += message.txtRecord;
            robot.robotMove();
        }
    }
}
