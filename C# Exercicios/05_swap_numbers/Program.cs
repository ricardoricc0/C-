using System;

namespace _05_swap_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //swap 2 numbers 
            //troca 2 números

            //var
            int num1, num2, aux;

            //input
            Console.Write("Digite um o Primeiro Número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o Segundo Número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //processament
            aux = num1;
            num1 = num2;
            num2 = aux;

            //output
            Console.WriteLine(".:: APÓS A TROCA ::.");
            Console.WriteLine("Primeiro Número: {0}", num1);
            Console.WriteLine("Segundo Número: {0}", num2);

            Console.ReadKey();




        }
    }
}
