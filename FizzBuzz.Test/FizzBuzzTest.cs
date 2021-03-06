using FizzAndBuzz;
using Shouldly;
using System;
using Xunit;

namespace FizzBuzz.Test
{
    public class FizzBuzzTest
    {
        [Fact]
        public void ShowFizzBuzzNumbersTest()
        {
            NumberProcess numberProcess = new NumberProcess();


            numberProcess.ShowFizzBuzzNumbers(0).ShouldBe("the input number must be larger than zero.");

            numberProcess.ShowFizzBuzzNumbers(10).ShouldBe("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz");

            numberProcess.ShowFizzBuzzNumbers(50).ShouldBe("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz Fizz 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 Fizz Fizz Buzz 26 Fizz 28 29 FizzBuzz Fizz Fizz Fizz Fizz FizzBuzz Fizz Fizz Fizz Fizz Buzz 41 Fizz Fizz 44 FizzBuzz 46 47 Fizz 49 Buzz");
        }
    }
}
