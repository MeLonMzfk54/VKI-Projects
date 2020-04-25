using System;
using System.Security.Cryptography.X509Certificates;

namespace patternsNew
{
    class Program
    {

        static void Main(string[] args)
        {
            Cars sportCar = new Cars(new sportCar());
            sportCar.Type();
            sportCar.Color();
            sportCar.MoveNow();
            sportCar.MoveFaster();
            sportCar.MoveDown();

            Cars SUV = new Cars(new SUV());
            SUV.Type();
            SUV.Color();
            SUV.MoveNow();
            SUV.MoveFaster();
            SUV.MoveDown();

            Cars Truck = new Cars(new Truck());
            SUV.Type();
            SUV.Color();
            Truck.MoveNow();
            Truck.MoveFaster();
            Truck.MoveDown();
            Console.ReadLine();
        }

       /* abstract class createCars
        {
            public abstract void Car();
        }*/

        abstract class Move
        {
            public abstract void Speed();
        }

        abstract class MoveFaster
        {
            public abstract void SpeedUp();
        }

        abstract class MoveSlower
        {
            public abstract void SpeedDown();
        }

        abstract class Color
        {
            public abstract void colorCar();
        }

        abstract class Type
        {
            public abstract void typeCar();
        }

        class Grey : Color
        {
            public override void colorCar()
            {
                Console.WriteLine("Серого цвета");
            }
        }

        class White : Color
        {
            public override void colorCar()
            {
                Console.WriteLine("Белого цвета");
            }
        }

        class SUVType : Type
        {
            public override void typeCar()
            {
                Console.WriteLine("Внедорожник");
            }
        }
        class truckType : Type
        {
            public override void typeCar()
            {
                Console.WriteLine("Грузовик");
            }
        }
        class sportCarType : Type
        {
            public override void typeCar()
            {
                Console.WriteLine("Спортивная машина");
            }
        }
        class speedNow : Move
        {
            public override void Speed()
            {
                Random spd = new Random();
                int value = spd.Next(60, 150);
                Console.WriteLine("Двигается со скоростью" + value + "км/ч");
            }
        }
        

        class speedUp : MoveFaster
        {
            public override void SpeedUp()
            {
                Console.WriteLine("Повышаем скорость");
                Random spd = new Random();
                int value = spd.Next(151, 200);
                Console.WriteLine("Двигается со скоростью" + value + "км/ч");
            }
        }

        class speedDown : MoveSlower
        {
            public override void SpeedDown()
            {
                Console.WriteLine("Понижаем скорость");
                Random spd = new Random();
                int value = spd.Next(20, 60);
                Console.WriteLine("Двигается со скоростью" + value + "км/ч");
            }
        }

        abstract class carFactory
        {
            public abstract Move createSpeedNow();
            public abstract MoveFaster createSpeedUp();
            public abstract MoveSlower createSpeedDown();
            public abstract Color createColor();
            public abstract Type createType();


        }

        class sportCar : carFactory
        {
            public override Move createSpeedNow()
            {
                return new speedNow();
            }
            public override MoveFaster createSpeedUp()
            {
                return new speedUp();
            }
            public override MoveSlower createSpeedDown()
            {
                return new speedDown();
            }
            public override Color createColor()
            {
                return new White();
            }
            public override Type createType()
            {
                return new sportCarType();
            }
        }

        class SUV : carFactory
        {
            public override Move createSpeedNow()
            {
                return new speedNow();
            }
            public override MoveFaster createSpeedUp()
            {
                return new speedUp();
            }
            public override MoveSlower createSpeedDown()
            {
                return new speedDown();
            }
            public override Color createColor()
            {
                return new Grey();
            }
            public override Type createType()
            {
                return new SUVType();
            }
        }

        class Truck : carFactory
        {
            public override Move createSpeedNow()
            {
                return new speedNow();
            }
            public override MoveFaster createSpeedUp()
            {
                return new speedUp();
            }
            public override MoveSlower createSpeedDown()
            {
                return new speedDown();
            }
            public override Color createColor()
            {
                return new White();
            }
            public override Type createType()
            {
                return new truckType();
            }
        }

        class Cars
        {
            private Move move;
            private MoveFaster movefaster;
            private MoveSlower moveslower;
            private Color color;
            private Type type;
            public Cars(carFactory factory)
            {
                move = factory.createSpeedNow();
                movefaster = factory.createSpeedUp();
                moveslower = factory.createSpeedDown();
                color = factory.createColor();
                type = factory.createType();
            }

            public void MoveNow()
            {
                move.Speed();
            }
            public void MoveFaster()
            {
                movefaster.SpeedUp();
            }
            public void MoveDown()
            {
                moveslower.SpeedDown();
            }
            public void Color()
            {
                color.colorCar();
            }
            public void Type()
            {
                type.typeCar();
            }
        }

    }
}
