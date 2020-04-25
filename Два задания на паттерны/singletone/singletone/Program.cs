using System;

namespace singletone
{
    class Program
    {

        class singletone
        {
            private static singletone instance;
            private singletone() { }
            public static singletone getInstance()
            {
                if(instance == null)
                {
                    instance = new singletone();
                }
                return instance;
            }
       
        }
        static void Main(string[] args)
        {
            /*Computer comp = new Computer();
            comp.Launch("Windows 8.2");
            Console.WriteLine(comp.OS.Name);

            // у нас не получится изменить ОС, так как объект уже создан    
            comp.OS = OS.getInstance("Windows 10");
            Console.WriteLine(comp.OS.Name);

            Console.ReadLine();*/
            singletone test = singletone.getInstance();
            singletone test1 = singletone.getInstance();
            if(test == test1)
            {
                Console.WriteLine("Одиночка работает!");
            }
            else
            {
                Console.WriteLine("Одиночка не работает!");
            }
        }
    }
    /*class Computer
    {
        public OS OS { get; set; }
        public void Launch(string osName)
        {
            OS = OS.getInstance(osName);
        }
    }
    class OS
    {
        private static OS instance;

        public string Name { get; private set; }

        protected OS(string name)
        {
            this.Name = name;
        }

        public static OS getInstance(string name)
        {
            if (instance == null)
                instance = new OS(name);
            return instance;
        }
    }*/
}
