using System;
using Serilog;

namespace fizz_buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().CreateLogger();
            Log.Information("Fizz Buzz test!");
            var fbl = new fizz_buzz_lib.fizzbuzzer(); 
            for (int i = 1; i <= 100; i++)
            {
                string output = fbl.Calculator(i, 3, 5);
                Console.WriteLine(output);
                Log.Information(output);
            }
            Console.Read();
        }
    }
}
