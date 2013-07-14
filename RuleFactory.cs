using System.Linq;
using System.Collections.Generic;

namespace FizzBuzzKata
{

    static class RuleFactory
    {
        public static IRule[] CreateRules(params RuleInitializer[] initializers)
        {
            return new List<IRule>(initializers.Select(i => new TranslationRule(i.Divisor, i.Translation))) {
                new InvalidRule(initializers.Select(i => i.Divisor).ToArray())
            }.ToArray();
        }
    }
}
