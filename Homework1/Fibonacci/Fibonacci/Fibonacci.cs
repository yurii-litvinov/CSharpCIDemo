namespace Fibonacci;

/// <summary>
/// Utility class for calculating Fibonacci numbers.
/// </summary>
public static class FibonacciCalculator
{
    /// <summary>
    /// Calculates nth Fibonacci number.
    /// </summary>
    /// <param name="n">Integer for which Fibonacci number will be calculated.</param>
    /// <returns>nth Fibonacci number.</returns>
    /// <exception cref="ArgumentOutOfRangeException">n is less than 1.</exception>
    public static int Fibonacci(int n)
    {
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException("Argument can not be negative", nameof(n));
        }

        return Fib(n).current;

        (int current, int previous) Fib(int i)
        {
            if (i == 0)
            {
                return (1, 0);
            }

            var (p, pp) = Fib(i - 1);
            return (p + pp, p);
        }
    }
}
