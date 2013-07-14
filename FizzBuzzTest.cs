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
        public void ShouldReturnFizzForValuesDivisibleBy3()
        {
            var value = 3;

            var result = string.Empty;
            if (IsDivisibleBy(value, 3))
                result = "Fizz";
            if (IsDivisibleBy(value, 5))
                result = "Buzz";

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void ShouldReturnBuzzForValuesDivisibleBy5()
        {
            var value = 5;

            var result = string.Empty;
            if (IsDivisibleBy(value, 3))
                result = "Fizz";
            if (IsDivisibleBy(value, 5))
                result = "Buzz";

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        private bool IsDivisibleBy(int value, int divisor)
        {
            return value % divisor == 0;
        }
    }
}

