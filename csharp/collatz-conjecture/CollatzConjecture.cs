using System;

public static class CollatzConjecture
{
    public static int Steps(int number, int counter = 0)
    {
        if (number < 1) throw new ArgumentOutOfRangeException();

        if (number > 1)
        {
            if (number % 2 == 0) { counter = Steps(number / 2); }

            if (number % 2 != 0) { counter = Steps(number * 3 + 1); }

            counter++;
        }

        return counter;
    }

}