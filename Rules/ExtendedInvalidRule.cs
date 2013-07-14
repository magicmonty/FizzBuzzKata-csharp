namespace FizzBuzzKata
{
    class ExtendedInvalidRule : InvalidRule
    {
        public ExtendedInvalidRule(int[] invalidDivisors) : base(invalidDivisors)
        {
        }

        public override bool IsFor(int value)
        {
            var result = base.IsFor(value);

            foreach (var d in InvalidDivisors) {
                result = result && !value.ToString().Contains(d.ToString());
            }

            return result;
        }
    }
}
