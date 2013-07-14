using System.Linq;
using System.Collections.Generic;

namespace FizzBuzzKata
{
    class ExtendedRuleFactory : IRuleFactory
    {
        public IRule[] CreateRules(params RuleInitializer[] initializers)
        {
            return new List<IRule>(initializers.Select(i => new ExtendedTranslationRule(i.Divisor, i.Translation))) {
                new ExtendedInvalidRule(initializers.Select(i => i.Divisor).ToArray())
            }.ToArray();
        }
    }
}
