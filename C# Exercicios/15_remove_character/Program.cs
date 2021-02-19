using System;

namespace _15_remove_character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(remove_char("w3resorce", 1));
            Console.WriteLine(remove_char("w3resorce", 9));
            Console.WriteLine(remove_char("w3resorce", 0));
        }

        public static string remove_char(string str, int n){
            return str.Remove(n, 1);
        }
    }
}
