// Copyright 2023 Yurii Litvinov.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

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
