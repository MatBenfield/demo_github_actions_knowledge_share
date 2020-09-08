using System;

namespace fizz_buzz_lib
{
    public class fizzbuzzer
    {
        public string Calculator(int i, int f, int b)
        {
            if (i < 1)
            {
                throw new ArgumentOutOfRangeException("values cannot be less than 1");
            }
            string output = null;
            if (i % (f * b) == 0)
            {
                output = " FizzBuzz";
            }
            else if (i % f == 0)
            {
                output = " Fizz";
            }
            else if (i % b == 0)
            {
                output = " Buzz";
            }
            return (i + output);
        }
    }
}
