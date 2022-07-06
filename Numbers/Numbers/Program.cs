using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 105566.65m; // sempre utilizar o "m" ao final utilizando decimal
            var culture = CultureInfo.CreateSpecificCulture("en-Us"); // selecionar novo idioma (inglês no caso); 
            culture = CultureInfo.CreateSpecificCulture("pt-BR"); // selecionar novo idioma (portugues no caso); 
            // para utilizar a cultura, tem que ser passado com argumento dentro do ToString;

            /*
            //Formatadores
            Console.WriteLine(valor.ToString("G", culture)); // Padrão
            Console.WriteLine(valor.ToString("C", culture)); // current cash
            Console.WriteLine(valor.ToString("E04", culture)); //Uso desconhecido
            Console.WriteLine(valor.ToString("N", culture)); //Numero
            Console.WriteLine(valor.ToString("P", culture)); //Porcentagem 
            Console.WriteLine(valor.ToString("F", culture)); //Precisao maior 
            */

            Console.WriteLine(Math.Round(valor)); // arredondar pra cima
            Console.WriteLine(Math.Ceiling(valor)); // arredondar pra cima
            Console.WriteLine(Math.Floor(valor)); // arredondar pra baixo




        }
    }
}
