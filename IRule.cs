namespace FizzBuzzKata
{
    interface IRule
    {
        string Translation(int value);

        bool IsFor(int value);
    }
}
