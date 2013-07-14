using System;
using NUnit.Framework;

namespace FizzBuzzKata
{
    [TestFixture]
    public class Test
    {
        /*
         * Rules:
         * - Values divisble by 3 are converted to "Fizz"
         * - Values divisble by 5 are converted to "Buzz"
         * - Values divisble by 3 and 5 are converted to "FizzBuzz"
         * - All other values are converted to their string representations
         */
        [Test]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(7, "7")]
        [TestCase(8, "8")]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(11, "11")]
        [TestCase(12, "Fizz")]
        [TestCase(13, "13")]
        [TestCase(14, "14")]
        [TestCase(15, "FizzBuzz")]
        public void ShouldReturnCorrectValue(int valueToTranslate, string expectedResult)
        {
            var translation = Translate(valueToTranslate);

            Assert.That(translation, Is.EqualTo(expectedResult));
        }

        string Translate(int value)
        {
            var result = string.Empty;

            if (IsDivisibleBy(value, 3))
                result += "Fizz";
            if (IsDivisibleBy(value, 5))
                result += "Buzz";
            if (!IsDivisibleBy(value, 3) && !IsDivisibleBy(value, 5))
                result += value.ToString();

            return result;
        }

        private bool IsDivisibleBy(int value, int divisor)
        {
            return value % divisor == 0;
        }
    }
}

