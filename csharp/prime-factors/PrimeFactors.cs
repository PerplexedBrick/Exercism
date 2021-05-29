using System;
using System.Collections.Generic;

public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        List<long> factors = new List<long>();        
        if( number < 2) return factors.ToArray();
        if (number == 2)
        {
            factors.Add(2);
            return factors.ToArray();
        }
        long primeFactor = 2;

        while ( primeFactor <= number)
        {
            if (number % primeFactor != 0)
            {
                primeFactor = NextPrime(primeFactor, number);
            }

            if (number % primeFactor == 0)
            {
                factors.Add(primeFactor);
                number /= primeFactor;
            }            
        }



        return factors.ToArray();
    }

    private static long NextPrime(long primeFactor, long number)
    {
        if (primeFactor == 2) return 3;

        long divisor = default;

        for (long i = primeFactor; i < primeFactor + 10; i++)
        {
            if (i % 6 == 0)
            {
                divisor = i;
                break;
            }
        }

        while (primeFactor <= Math.Sqrt(number) + 1)
        {
            if (number % (divisor - 1) == 0)
            {
                primeFactor = divisor - 1;
                return primeFactor;
            }

            if (number % (divisor + 1) == 0)
            {
                primeFactor = divisor + 1;
                return primeFactor;
            }
            divisor += 6;
        }

        return number;
    }

    private static bool IsPrime(int number)
    {

        if (number == 2 || number == 3)
            return true;

        if (number % 2 == 0 || number % 3 == 0)
            return false;

        int divisor = 6;
        while (divisor * divisor - 2 * divisor + 1 <= number)
        {

            if (number % (divisor - 1) == 0)
                return false;

            if (number % (divisor + 1) == 0)
                return false;

            divisor += 6;

        }

        return true;

    }
}