using System;

namespace Menor_de_18_Nao_Entra
{
    class Program
    {
         static void Main(string[] args)
         {
             Processar();

             Console.ReadKey();
         }
        

        private static void Processar()
        {
            int Idade;
            Console.Write("Informe a sua idade: ");
            int.TryParse(Console.ReadLine(), out Idade);

            if (Idade >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Acesso permitdo");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Acesso Negado");
            }
        }
    }   
}