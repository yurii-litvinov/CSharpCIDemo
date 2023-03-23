namespace Factorial.Tests;

public class Tests
{
    [TestCase(6, ExpectedResult = 720)]
    [TestCase(1, ExpectedResult = 1)]
    public int FactorialOfGivenNumbersCalculatesCorrectly(int n)
        => FactorialCalculator.Factorial(n);

    [Test]
    public void FactorialOf0ThrowsAnException()
        => Assert.Throws<ArgumentOutOfRangeException>(() => FactorialCalculator.Factorial(0));
}