using NUnit.Framework;
using System;
using fizz_buzz_lib;

namespace fizz_buzz_tests
{
    public class Tests
    {
        [TestCase(-1)]
        [TestCase(-3)]
        [TestCase(0)]
        public void GivenImpossibleValuesCalculatorReturnsThrowsException(int value)
        {
            var fbl = new fizzbuzzer();
            Assert.Throws<ArgumentOutOfRangeException>(()=> fbl.Calculator(value, 3, 5));
        }


        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void GivenValuesCalculatorReturnsFizz(int value)
        {
            var fbl = new fizzbuzzer();
            var output = fbl.Calculator(value, 3, 5);

            Assert.AreEqual(output, $"{value} Fizz");
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void GivenValuesCalculatorReturnsBuzz(int value)
        {
            var fbl = new fizzbuzzer();
            var output = fbl.Calculator(value, 3, 5);

            Assert.AreEqual(output, $"{value} Buzz");
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void GivenValuesCalculatorReturnsFizzBuzz(int value)
        {
            var fbl = new fizzbuzzer();
            var output = fbl.Calculator(value, 3, 5);

            Assert.AreEqual(output, $"{value} FizzBuzz");
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void GivenValuesCalculatorReturnsInteger(int value)
        {
            var fbl = new fizzbuzzer();
            var output = fbl.Calculator(value, 3, 5);

            Assert.AreEqual(output, $"{value}");
        }

    }
}