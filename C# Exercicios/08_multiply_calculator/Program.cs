using System;

namespace _08_multiply_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //multiply calculator
            //calculadora de multiplicação

            //var
            int fator1, result;
            

            //input
            Console.Write(".::Calculadora de Multiplicação::.");
            Console.Write("\nDigite um número: ");
            fator1 = Convert.ToInt32(Console.ReadLine());

            //processament and output
            result = fator1 * 0;
            Console.WriteLine("{0} X {1} = {2}", fator1, 0, result);

            result = fator1 * 1;
            Console.WriteLine("{0} X {1} = {2}", fator1, 1, result);
            
            result = fator1 * 2;
            Console.WriteLine("{0} X {1} = {2}", fator1, 2, result);

            result = fator1 * 3;
            Console.WriteLine("{0} X {1} = {2}", fator1, 3, result);

            result = fator1 * 4;
            Console.WriteLine("{0} X {1} = {2}", fator1, 4, result);

            result = fator1 * 5;
            Console.WriteLine("{0} X {1} = {2}", fator1, 5, result);

            result = fator1 * 6;
            Console.WriteLine("{0} X {1} = {2}", fator1, 6, result);

            result = fator1 * 7;
            Console.WriteLine("{0} X {1} = {2}", fator1, 7, result);

            result = fator1 * 8;
            Console.WriteLine("{0} X {1} = {2}", fator1, 8, result);

            result = fator1 * 9;
            Console.WriteLine("{0} X {1} = {2}", fator1, 9, result);

            result = fator1 * 10;
            Console.WriteLine("{0} X {1} = {2}", fator1, 10, result);

            

            Console.ReadKey();


        }
    }
}
