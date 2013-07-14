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
            if (value % 3 == 0)
                result = "Fizz";
            Assert.That(result, Is.EqualTo("Fizz"));
        }
    }
}

