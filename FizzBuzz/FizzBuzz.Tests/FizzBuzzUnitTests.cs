using FluentAssertions;

namespace FizzBuzz.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(120)]
    public void FizzBuzz_ShouldReturnListWithRightAmountOfValues(int rounds)
    {
        var sut = new App.FizzBuzz();
        var result = sut.Play(rounds);

        result.Should().HaveCount(rounds);
    }

    [Theory]
    [InlineData(100, 2, 98, "Fizz")]
    [InlineData(100, 4, 99, "Buzz")]
    [InlineData(100, 14, 89, "FizzBuzz")]
    public void FizzBuzz_ShouldReturnListWithRightValues(
        int rounds,
        int firstOccurrance,
        int lastOccurrance,
        string expectedValue
    )
    {
        var sut = new App.FizzBuzz();
        var result = sut.Play(rounds);

        result
            .Should()
            .HaveElementAt(firstOccurrance, expectedValue)
            .And.HaveElementAt(lastOccurrance, expectedValue);
    }
}
