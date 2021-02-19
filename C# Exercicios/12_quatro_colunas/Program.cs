using System;

namespace _12_quatro_colunas
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            int num;

            //input
            Console.Write("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            //output
            Console.Write("{0} {0} {0} {0}", num);
            Console.Write("\n{0}{0}{0}{0}", num);
            Console.Write("\n{0} {0} {0} {0}", num);
            Console.Write("\n{0}{0}{0}{0}", num);

            Console.Write("\nDigite uma tecla para finalizar..");
            Console.ReadKey();
            
        }
    }
}
