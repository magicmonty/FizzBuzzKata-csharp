using System.Linq;

namespace FizzBuzzKata
{
    class RuleBasedTranslator
    {
        private readonly IRule[] _rules;

        public RuleBasedTranslator(IRule[] rules)
        {
            _rules = rules;
        }

        public string Translate(int value)
        {
            return _rules.Where(rule => rule.IsFor(value))
                         .Aggregate(string.Empty, (res, rule) => res + rule.Translation(value)); 
        }
    }
}
