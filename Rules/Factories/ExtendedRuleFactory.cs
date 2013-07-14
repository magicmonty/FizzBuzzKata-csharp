using System.Collections.Generic;

namespace FizzBuzzKata
{
    class ExtendedRuleFactory : IRuleFactory
    {
        public IRule[] CreateRules(params RuleInitializer[] initializers)
        {
            var result = new List<IRule>();

            var invalidDivisors = new List<int>();

            foreach (var i in initializers) {
                result.Add(new ExtendedTranslationRule(i.Divisor, i.Translation));
                invalidDivisors.Add(i.Divisor);
            }

            result.Add(new ExtendedInvalidRule(invalidDivisors.ToArray()));

            return result.ToArray();
        }
    }
}
