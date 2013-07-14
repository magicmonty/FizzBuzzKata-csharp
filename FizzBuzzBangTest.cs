using System;
using NUnit.Framework;

namespace FizzBuzzKata
{
    [TestFixture]
    public class FizzBuzzBangTest
    {
        private RuleBasedTranslator _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = FizzBuzzFactory.CreateFizzBuzzBang();
        }
        /*
         * Rules:
         * - Values divisble by 3 are converted to "Fizz"
         * - Values divisble by 5 are converted to "Buzz"
         * - Values divisble by 5 are converted to "Bang"
         * - Values divisble by 3 and 5 are converted to "FizzBuzz"
         * - Values divisble by 3 and 7 are converted to "FizzBang"
         * - Values divisble by 5 and 7 are converted to "BuzzBang"
         * - Values divisble by 3, 5 and 7 are converted to "FizzBuzzBang"
         * - All other values are converted to their string representations
         */
        [Test]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(7, "Bang")]
        [TestCase(8, "8")]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(11, "11")]
        [TestCase(12, "Fizz")]
        [TestCase(13, "13")]
        [TestCase(14, "Bang")]
        [TestCase(3*5, "FizzBuzz")]
        [TestCase(3*7, "FizzBang")]
        [TestCase(5*7, "BuzzBang")]
        [TestCase(3*5*7, "FizzBuzzBang")]
        public void ShouldReturnCorrectValue(int valueToTranslate, string expectedResult)
        {
            var translation = _sut.Translate(valueToTranslate);

            Assert.That(translation, Is.EqualTo(expectedResult));
        }
    }
}

