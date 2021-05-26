using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> multipliers = new List<int>();

        foreach (int m in multiples)
        {
            if (m < 1 || m >= max ) continue;
            multipliers.AddRange(Enumerable.Range(m, max - 1).Where(n => n < max).Where(n => n % m == 0));
        }

        return multipliers.Distinct().Sum();
    }
 
}