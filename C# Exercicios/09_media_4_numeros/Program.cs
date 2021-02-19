using System;

namespace _09_media_4_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //average 4 numbers
            //media de 4 números

            //var
            int num1, num2, num3, num4, media;

            //input
            Console.WriteLine(".::Cálculo Média::.");
            Console.Write("Digite o Primeiro Número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Segundo Número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Terceiro Número: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Quarto Número: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            //processament
            media = (num1 + num2 + num3 + num4) / 4;

            //output
            Console.WriteLine("A MÉDIA entre os números {0}, {1}, {2} e {3} é: {4}", num1, num2, num3, num4, media);
        }
    }
}
