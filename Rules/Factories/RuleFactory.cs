using System.Collections.Generic;

namespace FizzBuzzKata
{
    class RuleFactory : IRuleFactory
    {
        public IRule[] CreateRules(params RuleInitializer[] initializers)
        {
            var result = new List<IRule>();

            var invalidDivisors = new List<int>();

            foreach (var i in initializers) {
                result.Add(new TranslationRule(i.Divisor, i.Translation));
                invalidDivisors.Add(i.Divisor);
            }
           
            result.Add(new InvalidRule(invalidDivisors.ToArray()));

            return result.ToArray();
        }
    }
}
