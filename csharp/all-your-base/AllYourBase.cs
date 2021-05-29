using System;
using System.Collections.Generic;
using System.Linq;

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase) => (new bool()) switch
    {
        false when inputBase < 2 | outputBase < 2 => throw new ArgumentException("No bases <2 allowed"),
        false when inputDigits.Any(d => d < 0) => throw new ArgumentException("No to negative numbers"),
        false when inputDigits.Any(d => d >= inputBase) => throw new ArgumentException("Digit bigger then its base"),
        false when inputBase == 10 => ConvertFromDecimal(outputBase, inputDigits),
        false when outputBase == 10 => ConvertToDecimal(inputBase, inputDigits),
        _ => ConvertFromDecimal(outputBase, ConvertToDecimal(inputBase, inputDigits))
    };
    

    private static int[] ConvertToDecimal(int inputBase, int[] inputDigits)
    {
        int decimalValue = 0;

        for (int i = 0; i < inputDigits.Length; i++)
        {
            decimalValue += inputDigits[^(i + 1)] * (int)Math.Pow(inputBase, i);
        }

        return (decimalValue.ToString()).Select(a => a - '0').ToArray();
    }

    private static int[] ConvertFromDecimal(int outputBase, int[] inputDigits)
    {
        int value = int.Parse(string.Join("", inputDigits));

        if (value == 0) return new int[] { 0 };

        List<int> convertedValue = new List<int>();


        while(value > 0)
        {
            convertedValue.Add(value % outputBase);

            value /= outputBase;
        }

        convertedValue.Reverse();

        return convertedValue.ToArray();
    }
}