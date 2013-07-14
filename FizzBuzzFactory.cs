namespace FizzBuzzKata
{
    static class FizzBuzzFactory
    {
        public static RuleBasedTranslator CreateFizzBuzz()
        {
            var rules = new IRule[] {
                new TranslationRule(3, "Fizz" ),
                new TranslationRule(5, "Buzz" ),
                new InvalidRule(new [] {3, 5})
            };

            return new RuleBasedTranslator(rules);
        }

        public static RuleBasedTranslator CreateFizzBuzzBang()
        {
            var rules = new IRule[] {
                new TranslationRule(3, "Fizz" ),
                new TranslationRule(5, "Buzz" ),
                new TranslationRule(7, "Bang" ),
                new InvalidRule(new [] {3, 5, 7})
            };

            return new RuleBasedTranslator(rules);
        }
    }
}
