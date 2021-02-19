using System;

namespace _04_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(-1 + (4 * 6));
            //-1 + 24 = 23
            Console.WriteLine((35 + 5) % 7);
            //40 % 7 = 5
            Console.WriteLine(14 + (-4 * 6) / 11);
            //14 - (24 / 11) = 14 - 2 = 12
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            //2 + (15/6) - remainder of (7/2) = 2 + 2 - 1 = 4 - 1 = 3
            Console.ReadKey();
        }
    }
}
    