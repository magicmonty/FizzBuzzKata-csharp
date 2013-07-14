namespace FizzBuzzKata
{
    static class FizzBuzzFactory
    {
        public static RuleBasedTranslator CreateFizzBuzz()
        {
            var rules = RuleFactory.CreateRules(
                new RuleInitializer { Divisor = 3, Translation = "Fizz" }, 
                new RuleInitializer { Divisor = 5, Translation = "Buzz" });

            return new RuleBasedTranslator(rules);
        }

        public static RuleBasedTranslator CreateFizzBuzzBang()
        {
            var rules = RuleFactory.CreateRules(
                new RuleInitializer { Divisor = 3, Translation = "Fizz" }, 
                new RuleInitializer { Divisor = 5, Translation = "Buzz" }, 
                new RuleInitializer { Divisor = 7, Translation = "Bang" });

            return new RuleBasedTranslator(rules);
        }
    }
}
