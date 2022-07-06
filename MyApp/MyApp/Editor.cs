using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyApp
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            var corAnterior = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo editor");
            Console.WriteLine("-----------");
            Start();
            Console.BackgroundColor = corAnterior;
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-----------");
            Viewer.Show(file.ToString());
            DecisionSave(file.ToString());
        }

        public static void DecisionSave(string file)
        {
            Console.Clear();
            Console.WriteLine("Deseja salvar o arquivo?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.Write("Opção desejada: ");
            int entrada = int.Parse(Console.ReadLine());

            switch (entrada)
            {
                case 1: Save(file); break;
                case 2: Menu.Show(); break;
                default: 
                    Console.WriteLine("Opção Incorreta! tente novamente");
                    break;
            }
        }

        public static void Save(string file)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var arquivo = new StreamWriter(path))
            {
                arquivo.Write(file);
            }

            Console.WriteLine($"Arquivo salvo com sucesso em {path}.");
            Console.ReadLine();
            Menu.Show();
        }

        public static void Open()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu.Show();

        }
    }
}
