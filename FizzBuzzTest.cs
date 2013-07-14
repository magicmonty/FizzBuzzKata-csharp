using System;
using NUnit.Framework;
using System.Linq;

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

            var rules = new IRule[] {
                new TranslationRule(3, "Fizz" ),
                new TranslationRule(5, "Buzz" ),
                new InvalidRule(new [] {3, 5})
            };

            var result = rules.Where(rule => rule.IsFor(value))
                              .Aggregate(string.Empty, (res, rule) => res + rule.Translation(value)); 

            return result;
        }

        private bool IsDivisibleBy(int value, int divisor)
        {
            return value % divisor == 0;
        }
    }

    interface IRule
    {
        string Translation(int value);

        bool IsFor(int value);
    }

    class TranslationRule : IRule
    {
        private readonly int _divisor;
        private readonly string _translation;

        public TranslationRule(int divisor, string translation)
        {
            _divisor = divisor;
            _translation = translation;
        }

        public string Translation(int value)
        { 
            return _translation; 
        }

        public bool IsFor(int value)
        {
            return value % _divisor == 0;
        }
    }

    class InvalidRule : IRule
    {
        private readonly int[] _invalidDivisors;

        public InvalidRule(int[] invalidDivisors)
        {
            _invalidDivisors = invalidDivisors;
        }

        public string Translation(int value)
        { 
            return value.ToString(); 
        }

        public bool IsFor(int value)
        {
            return _invalidDivisors.All(divisor => value % divisor != 0);
        }
    }
}

