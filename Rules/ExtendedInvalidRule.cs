using System.Linq;

namespace FizzBuzzKata
{
    class ExtendedInvalidRule : InvalidRule
    {
        public ExtendedInvalidRule(int[] invalidDivisors) : base(invalidDivisors)
        {
        }

        public override bool IsFor(int value)
        {
            return base.IsFor(value) 
                && InvalidDivisors.All(d => !value.ToString().Contains(d.ToString()));
        }
    }
}
