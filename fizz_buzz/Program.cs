using System;
using fizz_buzz_lib;

namespace fizz_buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz test!");
            var fbl = new fizzbuzzer(); 
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fbl.Calculator(i, 3, 5));
            }
            Console.Read();
        }
    }
}
