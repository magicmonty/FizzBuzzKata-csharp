using System;
using NUnit.Framework;

namespace FizzBuzzKata
{
    [TestFixture]
    public class ExtendedFizzBuzzTest
    {
        private RuleBasedTranslator _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = FizzBuzzFactory.CreateFizzBuzz(new ExtendedRuleFactory());
        }
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
        [TestCase(13, "Fizz")]
        [TestCase(14, "14")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(25, "Buzz")]
        [TestCase(31, "Fizz")]
        [TestCase(52, "Buzz")]
        [TestCase(53, "FizzBuzz")]
        public void ShouldReturnCorrectValue(int valueToTranslate, string expectedResult)
        {
            var translation = _sut.Translate(valueToTranslate);

            Assert.That(translation, Is.EqualTo(expectedResult));
        }
    }
}

