using System;

namespace _07_calculator_2_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculate 2 numbers on + - * / %
            //calcula 2 números em + - * / %

            //var 
            int num1, num2, add, sub, multi, div, mod;

            //input
            Console.Write("CALCULA 2 NUMEROS [ + - * / % ]");
            
            Console.Write("\nDigite o Primeiro Número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Segundo Número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Processament
            add = num1 + num2;
            sub = num1 - num2;
            multi = num1 * num2;
            div = num1 / num2;
            mod = num1 % num2;

            //output
            Console.WriteLine("ADIÇÃO: {0} + {1} = {2}", num1, num2, add);
            Console.WriteLine("SUBTRAÇÃO: {0} - {1} = {2}", num1, num2, sub);
            Console.WriteLine("MULTIPLIÇÃO: {0} * {1} = {2}", num1, num2, multi);
            Console.WriteLine("DIVISÃO: {0} / {1} = {2}", num1, num2, div);
            Console.WriteLine("MOD/RESTO: {0} % {1} = {2}", num1, num2, mod);

            Console.ReadKey();


        }
    }
}
