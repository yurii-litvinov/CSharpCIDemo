namespace Factorial;

/// <summary>
/// Utility class for calculating factorial.
/// </summary>
public static class FactorialCalculator
{
    /// <summary>
    /// Calculates factorial of a given integer.
    /// </summary>
    /// <param name="n">Integer whose factorial will be calculated.</param>
    /// <returns>Factorial of n.</returns>
    /// <exception cref="ArgumentOutOfRangeException">n is less than 1.</exception>
    public static int Factorial(int n)
        => n <= 0 ? throw new ArgumentOutOfRangeException("Argument can not be less than zero", nameof(n))
           : n == 1 ? 1
           : n * Factorial(n - 1);
}
