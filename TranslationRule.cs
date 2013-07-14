namespace FizzBuzzKata
{
    class TranslationRule : IRule
    {
        private readonly int _divisor;
        private readonly string _translation;

        public TranslationRule(int divisor, string translation)
        {
            _divisor = divisor;
            _translation = translation;
        }

        public string Translation(int value)
        { 
            return _translation; 
        }

        public bool IsFor(int value)
        {
            return value % _divisor == 0;
        }
    }
}
