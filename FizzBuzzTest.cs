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

            var result = Translate(value);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void ShouldReturnBuzzForValuesDivisibleBy5()
        {
            var value = 5;

            var result = Translate(value);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void ShouldReturnFizzBuzzForValuesDivisibleBy3and5()
        {
            var value = 3 * 5;

            var result = Translate(value);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void ShouldReturnItselfAsStringForValuesNotDivisibleBy3or5()
        {
            var value = 7;

            var result = Translate(value);

            Assert.That(result, Is.EqualTo("7"));
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

