using System.Linq;

namespace FizzBuzzKata
{
    class InvalidRule : IRule
    {
        protected int[] InvalidDivisors { get; private set; }

        public InvalidRule(int[] invalidDivisors)
        {
            InvalidDivisors = invalidDivisors;
        }

        public string Translation(int value)
        { 
            return value.ToString(); 
        }

        public virtual bool IsFor(int value)
        {
            return InvalidDivisors.All(divisor => value % divisor != 0);
        }
    }

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
