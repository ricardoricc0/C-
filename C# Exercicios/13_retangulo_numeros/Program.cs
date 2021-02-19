using System;

namespace _13_retangulo_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*13. Write a C# program that takes a number as 
            input and then displays a rectangle of 3 columns 
            wide and 5 rows tall using that digit.*/

            //var 
            int num;

            //input
            Console.Write("Digite um Número: ");
            num = Convert.ToInt32(Console.ReadLine());

            //output
            Console.WriteLine("{0}{0}{0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0} {0}", num);
            Console.WriteLine("{0}{0}{0}", num);

            Console.Write("Digite uma tecla para finalizar..");
            Console.ReadKey();
        }
    }
}
