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
            var result = true;
            foreach (var divisor in InvalidDivisors) {
                result &= value % divisor != 0;
            }

            return result;
        }
    }
}
