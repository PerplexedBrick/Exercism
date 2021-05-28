using System;
using System.Collections.Generic;
using System.Linq;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        if (rows == 0) return new List<int[]>();        

        int[] row = new int[rows];

        row[0] = 1;
        row[row.Length - 1] = 1;

        if( rows > 1)
        {
            IEnumerable < IEnumerable<int> > previousRows = Calculate(rows - 1);
            int[] previousRow = (int[])previousRows.Last();

            if( rows > 2)
            {
                for (int j = 1; j < rows-1; j++)
                {
                    row[j] = previousRow[j - 1] + previousRow[j];
                }
            }

            return previousRows.Append(row);
        }

        var x = new List<int[]>();
        x.Add(row);

        return x;        
    }

}