namespace Fibonacci.Tests;

public class Tests
{
    [TestCase(0, ExpectedResult = 1)]
    [TestCase(1, ExpectedResult = 1)]
    [TestCase(2, ExpectedResult = 2)]
    [TestCase(3, ExpectedResult = 3)]
    [TestCase(4, ExpectedResult = 5)]
    [TestCase(5, ExpectedResult = 8)]
    public int FibonacciOfGivenNumbersCalculatesCorrectly(int n)
        => FibonacciCalculator.Fibonacci(n);

    [Test]
    public void FibonacciOfNegativeNumberThrowsAnException()
        => Assert.Throws<ArgumentOutOfRangeException>(() => FibonacciCalculator.Fibonacci(-1));
}