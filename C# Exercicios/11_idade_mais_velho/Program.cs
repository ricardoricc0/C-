using System;

namespace _11_idade_mais_velho
{
    class Program
    {
        static void Main(string[] args)
        {
            //input age look older
            //digita a idade, parece mais velho

            //Write a C# Sharp program that takes an age (for example 20)
            //as input and prints something as "You look older than 20".

            //var
            int age;
            
            //input
            Console.Write("Digite sua idade: ");
            age = Convert.ToInt32(Console.ReadLine());

            //output
            Console.WriteLine("Você parece mais velho que {0}.", age);

            Console.Write("Digite uma tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
