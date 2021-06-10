using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double vectorLength = Math.Abs(Math.Sqrt(x * x + y * y));

        if (vectorLength <= 1) return 10;
        if (vectorLength <= 5) return 5;
        if (vectorLength <= 10) return 1;
        return 0;
    }
}
