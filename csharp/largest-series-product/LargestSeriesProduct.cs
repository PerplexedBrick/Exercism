using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        int product = 0;
        
        Regex regex = new Regex("[^0-9]");

        if (digits.Length < span || span < 0 ) throw new ArgumentException("Invalid span length");
        if (regex.IsMatch(digits)) throw new ArgumentException("Only digits must be passed");
        if (!string.IsNullOrEmpty(digits) & span == 0) return 1;
        if (string.IsNullOrEmpty(digits) & span == 0) return 1;
        if (string.IsNullOrEmpty(digits) || span == 0) return 0;
        

        int temp = 0;

        for (int i = 0; i <= digits.Length - span; i++)
        {
            temp = digits.Substring(i, span).Select(x => (int)char.GetNumericValue(x)).Aggregate(1, (x, y) => x * y);
            if (temp > product) product = temp;
        }

        return product;
    }
}