using System;
using System.Diagnostics;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        return Math.Pow(realNumber, (double)r.Numerator / r.Denominator);
    }

    public static RationalNumber Denominate(this RationalNumber r)
    {
        if (r.Numerator == 0) return new RationalNumber(0, 1);

        int a = Math.Abs(r.Numerator);
        int b = Math.Abs(r.Denominator);

        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        int gcd = a | b;

        return new RationalNumber(r.Numerator / gcd, r.Denominator / gcd);
    }
        
}

public struct RationalNumber
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public RationalNumber(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }
        
    public override string ToString() => $"{Numerator} : {Denominator}";

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator, r1.Denominator * r2.Denominator).Denominate();
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator, r1.Denominator * r2.Denominator).Denominate();
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator).Denominate();
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        if (r1.Numerator < 0 && r2.Numerator > 0) return new RationalNumber(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator).Denominate();
        if (r2.Numerator < 0 && r1.Numerator > 0) return new RationalNumber(r1.Numerator * r2.Denominator * -1, r1.Denominator * r2.Numerator * -1).Denominate();
        if (r2.Numerator < 0 && r1.Numerator < 0) return new RationalNumber(r1.Numerator * r2.Denominator * -1, r1.Denominator * r2.Numerator * -1).Denominate();

        return new RationalNumber(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator).Denominate();
    }

    public RationalNumber Abs()
    {
        return new RationalNumber(Math.Abs(Numerator), Math.Abs(Denominator));
    }

    public RationalNumber Reduce()
    {
        if(Denominator < 0)
        {
            Denominator *= -1;
            Numerator *= -1;
        }

        return this.Denominate();
    }

    public RationalNumber Exprational(int power)
    {
        return new RationalNumber((int)Math.Pow(Numerator, power), (int)Math.Pow(Denominator, power));
    }

}