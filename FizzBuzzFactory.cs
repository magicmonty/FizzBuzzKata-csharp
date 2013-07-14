namespace FizzBuzzKata
{
    static class FizzBuzzFactory
    {
        public static RuleBasedTranslator CreateFizzBuzz()
        {
            return CreateFizzBuzz(new RuleFactory());
        }

        public static RuleBasedTranslator CreateFizzBuzz(IRuleFactory ruleFactory)
        {
            var rules = ruleFactory.CreateRules(
                new RuleInitializer { Divisor = 3, Translation = "Fizz" }, 
                new RuleInitializer { Divisor = 5, Translation = "Buzz" });

            return new RuleBasedTranslator(rules);
        }

        public static RuleBasedTranslator CreateFizzBuzzBang()
        {
            return CreateFizzBuzzBang(new RuleFactory());
        }

        public static RuleBasedTranslator CreateFizzBuzzBang(IRuleFactory ruleFactory)
        {
            var rules = ruleFactory.CreateRules(
                new RuleInitializer { Divisor = 3, Translation = "Fizz" }, 
                new RuleInitializer { Divisor = 5, Translation = "Buzz" }, 
                new RuleInitializer { Divisor = 7, Translation = "Bang" });

            return new RuleBasedTranslator(rules);
        }
    }
}
