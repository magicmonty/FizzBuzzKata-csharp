namespace FizzBuzzKata
{
    class TranslationRule : IRule
    {
        private readonly string _translation;

        public TranslationRule(int divisor, string translation)
        {
            Divisor = divisor;
            _translation = translation;
        }

        protected int Divisor { get; private set; }

        public string Translation(int value)
        { 
            return _translation; 
        }

        public virtual bool IsFor(int value)
        {
            return value % Divisor == 0;
        }
    }
}
