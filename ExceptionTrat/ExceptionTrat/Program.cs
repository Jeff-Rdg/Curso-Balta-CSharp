using System;

namespace ExceptionTrat
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var arr = new int[3];
            // sempre tratar erros do mais especificos para os mais genéricos!
            try
            {
            for(int i = 0; i < 10; i++)
            {
                // System.IndexOutOfRangeException
                Console.WriteLine(arr[i]);
            }

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Indice não encontrado");
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
                Console.WriteLine("Deu ruim!");
            }
            */
            try
            {
            Cadastrar("");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Falha ao cadastrar");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Algo de errado não está certo");
            }
            finally
            {
                Console.WriteLine("o Finally sempre será executado!");
            }
        }
        

        public static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new ArgumentNullException("O texto não pode ser nulo ou vazio.");
            }
        }
    }
}
