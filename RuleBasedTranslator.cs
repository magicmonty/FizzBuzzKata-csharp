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
            var translation = string.Empty;

            var enumerator = _rules.GetEnumerator();

            enumerator.Reset();
            while (enumerator.MoveNext()) {
                var rule = enumerator.Current as IRule;

                while (!rule.IsFor(value) && enumerator.MoveNext()) {
                    rule = enumerator.Current as IRule;
                }

                while (rule.IsFor(value)) {
                    translation += rule.Translation(value);
                    break;
                }
            }

            return translation;
        }
    }
}
