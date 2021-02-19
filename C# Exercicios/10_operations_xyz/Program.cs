using System;

namespace _10_operations_xyz
{
    class Program
    {
        static void Main(string[] args)
        {
            //some operations with 3 variables
            //operaçoes com 3 variáveis

            //Write a C# Sharp program to that takes three numbers(x,y,z)
            //as input and print the output of (x+y).z and x.y + y.z.

            //var
            int x, y, z, result1, result2;

            //input
            Console.Write(".::OPERAÇÕES 3 VARIAVES [x, y, x]::.");
            
            Console.Write("\nDigite X: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite Z: ");
            z = Convert.ToInt32(Console.ReadLine());

            //processament
            result1 = (x + y) * z;
            result2 = x * y + y * z;

            //output
            Console.Write("O resultado dos números digitados {0}, {1} e {2} is: ", x, y, z);
            Console.Write("\n(x + y) * z = {0}.", result1);
            Console.Write("\nx * y + y * z = {0}.", result2);

            Console.ReadKey();

        }
    }
}
