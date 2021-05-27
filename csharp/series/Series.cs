using System;
using System.Collections.Generic;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (1 > numbers.Length || numbers.Length < sliceLength) throw new ArgumentException();
        if (sliceLength < 1) throw new ArgumentException();

        string[] slices = new string[numbers.Length - sliceLength + 1];

        for (int i = 0; i <= numbers.Length - sliceLength; i++)
        {
            slices[i] = numbers.Substring(i, sliceLength);
        }
 
        return slices;
    }
    
}