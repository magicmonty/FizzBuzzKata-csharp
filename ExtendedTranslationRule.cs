namespace FizzBuzzKata
{
    class ExtendedTranslationRule : TranslationRule
    {
        public ExtendedTranslationRule(int divisor, string translation): base(divisor, translation)
        {
        }

        public override bool IsFor(int value)
        {
            return base.IsFor(value)
                || value.ToString().Contains(Divisor.ToString());
        }
    }
}
