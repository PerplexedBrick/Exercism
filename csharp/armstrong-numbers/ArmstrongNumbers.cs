using System;
using System.Collections.Generic;
using System.Linq;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        if (number >= 0 && 9 >= number) return true;

        var digits = NumbersIn(number);

        int sum = (int)digits.Sum(x => Math.Pow(x, digits.Length));

        return sum == number;
    }

    public static int[] NumbersIn(int value)
    {
        var numbers = new Stack<int>();

        for (; value > 0; value /= 10)
            numbers.Push(value % 10);

        return numbers.ToArray();
    }

}