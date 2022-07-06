using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Soma()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double result = valor1 + valor2;
            Console.WriteLine($"O resultado da soma é {result}");
            Console.WriteLine("");
            Menu();

        }
        static void Subtracao()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double result = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração é {result}");
            Console.WriteLine("");
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double result = valor1 / valor2;
            Console.WriteLine($"O resultado da divisão é {result}");
            Console.WriteLine("");
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            double result = valor1 * valor2;
            Console.WriteLine($"O resultado da Multiplicação é {result}");
            Console.WriteLine("");
            Menu();
        }

        static void Menu()
        {

            Console.WriteLine("O que deseja fazer? ");
            Console.WriteLine("[1] - Soma");
            Console.WriteLine("[2] - Subtração");
            Console.WriteLine("[3] - Divisão");
            Console.WriteLine("[4] - Multiplicação");
            Console.WriteLine("[5] - Sair");
            Console.WriteLine("selecione a operação desejada: ");

            var entrada = int.Parse(Console.ReadLine());

            switch (entrada)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
    }
}
