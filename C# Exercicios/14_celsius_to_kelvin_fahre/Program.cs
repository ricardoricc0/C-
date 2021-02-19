using System;

namespace _14_celsius_to_kelvin_fahre
{
    class Program
    {
        static void Main(string[] args)
        {
            //14. Write a C# program to convert
            //from celsius degrees to Kelvin and Fahrenheit.

            //var
            double celsius, kelvin, fahrenheit;

            //input
            Console.Write("Digite o grau em Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            //processamento
            kelvin = celsius + 273.15;
            fahrenheit =  celsius * 1.8 + 32;

            //output
            Console.WriteLine("--------------------------");
            Console.WriteLine("Kelvin: {0}", kelvin);
            Console.WriteLine("Fahreheint: {0}", fahrenheit);

            Console.Write("\nDigite uma tecla para finalizar..");
            Console.ReadKey();
        }
    }
}
