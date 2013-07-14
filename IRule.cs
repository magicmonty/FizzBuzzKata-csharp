using System;
using NUnit.Framework;
using System.Linq;

namespace FizzBuzzKata
{

    interface IRule
    {
        string Translation(int value);

        bool IsFor(int value);
    }

}
