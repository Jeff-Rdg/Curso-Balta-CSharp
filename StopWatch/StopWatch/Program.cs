using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");
            string data = Console.ReadLine().ToLower();
            
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int mult = 1;
            if (type == 'm')
                mult = 60;
            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * mult);
            Menu();
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Set..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Go..");
            Thread.Sleep(1000);

            Start(time);
        }

        static void Start(int time)
        {
            
            int currentTime = 0;
            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch Finalizado!");
            Thread.Sleep(2500);
        }

    }
}
