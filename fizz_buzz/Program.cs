using System;

namespace fizz_buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz test!");
            var fbl = new fizz_buzz_lib.fizzbuzzer(); 
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fbl.Calculator(i, 3, 5));
            }
            Console.Read();
        }
    }
}
