using System.Linq;

namespace FizzBuzzKata
{
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
