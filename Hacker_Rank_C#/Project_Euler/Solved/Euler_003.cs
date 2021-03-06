﻿using C = System.Console;
using M = System.Math;

class S
{
    public static bool IsPrime6(ulong number)
    {
        // Get the quick checks out of the way.
        if (number < 2) { return false; }
        // Dispense with multiples of 2 and 3.
        if (number % 2 == 0) { return (number == 2); }
        if (number % 3 == 0) { return (number == 3); }

        // Another quick check to eliminate known composites.
        // http://programmers.stackexchange.com/questions/120934/best-and-most-used-algorithm-for-finding-the-primality-of-given-positive-number/120963#120963
        if (!(((number - 1) % 6 == 0) || ((number + 1) % 6 == 0)))
        {
            return false;
        }

        // Quick checks are over.  Number is at least POSSIBLY prime.
        // Must iterate to determine the absolute answer.
        // We loop over 1/6 of the required possible factors to check,
        // but since we check twice in each iteration, we are actually
        // checking 1/3 of the possible divisors.  This is an improvement
        // over the typical naive test of odds only which tests 1/2
        // of the factors.

        // Though the whole number portion of the square root of ulong.MaxValue
        // would fit in a uint, there is better performance inside the loop
        // if we don't need to implicitly cast over and over a few million times.
        ulong root = (ulong)(uint)M.Sqrt(number);
        // Corner Case: Math.Sqrt error for really HUGE ulong.
        if (root == 0) root = (ulong)uint.MaxValue;

        // Start at 5, which is (6k-1) where k=1.
        // Increment the loop by 6, which is same as incrementing k by 1.
        for (ulong factor = 5; factor <= root; factor += 6)
        {
            // Check (6k-1)
            if (number % factor == 0) { return false; }
            // Check (6k+1)
            if (number % (factor + 2UL) == 0) { return false; }
        }

        return true;
    }

    static void Main()
    {
        for (int l = int.Parse(C.ReadLine()); l-- > 0; )
        {
            ulong TestNumber = (ulong)long.Parse(C.ReadLine());

            ulong SecondFactor = 0, MaxPrime = 0;
            ulong root = (ulong)(uint)M.Sqrt(TestNumber);

            for (ulong i = 1; i <= root + 1; i++)
            {
                if (TestNumber % i == 0)
                {
                    SecondFactor = TestNumber / i;
                    if (IsPrime6(SecondFactor))
                    {
                        MaxPrime = SecondFactor;
                        break;
                    }
                    if (IsPrime6(i))
                        MaxPrime = i;
                }
            }
            C.WriteLine(MaxPrime);
        }
    }
}
