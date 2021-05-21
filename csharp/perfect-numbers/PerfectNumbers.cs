using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1) throw new ArgumentOutOfRangeException();

        if (number == 1) return Classification.Deficient;

        int DivisorsSum = 1;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                DivisorsSum += i;
                if (number / i != i) DivisorsSum += number / i;
            }
        }

        if (number  > DivisorsSum) return Classification.Deficient;
        if (number  < DivisorsSum) return Classification.Abundant;
        return Classification.Perfect;
    }
}
