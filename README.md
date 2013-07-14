## FizzBuzz Kata

**Goal**: Convert integers into a string with specific rules

**Rules**: 
- Values divisble by 3 are converted to "Fizz"
- Values divisble by 5 are converted to "Buzz"
- Values divisble by 3 and 5 are converted to "FizzBuzz"
- All other values are converted to their string representations

**Test cases**:
```
1 -> "1"
2 -> "2"
3 -> "Fizz"
4 -> "4"
5 -> "Buzz"
6 -> "Fizz"
7 -> "7"
8 -> "8"
9 -> "Fizz"
10 -> "Buzz"
11 -> "11"
12 -> "Fizz"
13 -> "13"
14 -> "14"
15 -> "FizzBuzz"
```

### Extension 1 - FizzBuzzBang

**Rules**: 
- The same rules as for FizzBuzz, but with the following additions: 
- Values divisble by 7 are converted to "Bang"
- Values divisble by 3 and 7 are converted to "FizzBang"
- Values divisble by 5 and 7 are converted to "BuzzBang"
- Values divisble by 3, 5 and 7 are converted to "FizzBuzzBang"
- All other values are converted to their string representations

This version is written in C# with Xamarin Studio (should be able to open in Visual Studio too) with Mono.
