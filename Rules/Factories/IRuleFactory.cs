namespace FizzBuzzKata
{
    interface IRuleFactory
    {
        IRule[] CreateRules(params RuleInitializer[] initializers);
    }
}
