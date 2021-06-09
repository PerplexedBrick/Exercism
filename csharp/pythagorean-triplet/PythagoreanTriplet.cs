using System;
using System.Collections.Generic;
using System.Linq;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        List<(int, int, int)> primitives = new List<(int, int, int)>();
        List<(int, int, int)> triplets = new List<(int, int, int)>();

        int a, b, c = 0;
        int m = 2;

        while (c < sum)
        {
            for (int n = 1; n < m; ++n)
            {
                a = m * m - n * n;
                b = 2 * m * n;
                c = m * m + n * n;

                if (c > sum) break;

                int[] arr = new int[] { a, b, c };
                Array.Sort(arr);
                primitives.Add((arr[0], arr[1], arr[2]));

            }
            m++;
        }

        foreach ((int x, int y, int z) p in primitives.Distinct())
        {
            int mult = 1;
            while(p.z * mult < sum)
            {
                if (p.x * mult + p.y * mult + p.z * mult == sum) triplets.Add((p.x * mult, p.y * mult, p.z * mult));
                mult++;
            }
        }


        return triplets.Distinct().OrderBy( x => x.Item1);
    }
}