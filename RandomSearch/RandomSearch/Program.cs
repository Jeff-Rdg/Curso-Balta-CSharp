using System;
using System.Collections.Generic;

namespace RandomSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> number = new List<int>();

            for(int i = 0; i < 30; i++)
            {
                int teste = rand.Next(1, 3012);
                number.Add(teste);
            }

            for(int i = 0; i < 30; i++)
            {
                Console.WriteLine(number[i]);
            }



        }
    }
}
