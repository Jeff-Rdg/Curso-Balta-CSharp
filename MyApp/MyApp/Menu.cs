using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            var corAnterior = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();
            short option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
            Console.BackgroundColor = corAnterior;
        }

        public static void DrawScreen()
        {
            Collumns();
            Lines();
            Collumns();

        }

        public static void Collumns()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void Lines()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write("|");
                for (int j = 0; j <= 30; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(10, 2);
            Console.WriteLine("Editor Html");
            Console.SetCursorPosition(10, 3);
            Console.WriteLine("=============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo: ");
           
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Editor.Open(); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show();break;
            }
        }
    }
}

