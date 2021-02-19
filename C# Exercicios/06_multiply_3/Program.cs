using System;

namespace _06_multiply_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //multiply 3 numbers
            //multiplica 3 números

            //var
            int num1, num2, num3, result;

            //input
            Console.Write("Digite o Primeiro Número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Segundo Número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Digite o Terceiro Número: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            //processament
            result = num1 * num2 * num3;

            //output
            Console.WriteLine("A Multiplicação entre {0}, {1} e {2} é igual a {3}.", num1, num2, num3, result);


            Console.ReadKey();

        }
    }
}
