using System;

namespace ArraysWorking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // formas de criação de array
            var meuArray = new int[5] {1, 2, 3, 4, 5};
            meuArray[1] = 15;
            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine(meuArray[3]);
            Console.WriteLine(meuArray[4]);
            Console.WriteLine("");

            // metodos
            Console.WriteLine(meuArray.Clone());//cria nova versão do array

            // Percorrer Array
            foreach (int i in meuArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");
            // ou

            for(var i = 0; i < meuArray.Length; i++)
            {
                Console.WriteLine(meuArray[i]);
            }

            Console.WriteLine("");
            // atividade

            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() { Id = 2539, Nome = "Jefferson" };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);
                Console.WriteLine("_______");
            }
        }



        public struct Funcionario
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
