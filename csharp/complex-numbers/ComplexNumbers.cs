using System;

public struct ComplexNumber
{
    public double _real { get; set; }
    public double _imaginary { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
        _real = real;
        _imaginary = imaginary;
    }

    public double Real()
    {
        return _real;
    }

    public double Imaginary()
    {
        return _imaginary;
    }

    public ComplexNumber Mul(ComplexNumber other)
    {
        return new ComplexNumber((this._real * other._real - this._imaginary * other._imaginary), (this._imaginary * other._real + this._real * other._imaginary));
    }

    public ComplexNumber Add(ComplexNumber other)
    {
        return new ComplexNumber((this._real + other._real), (this._imaginary + other._imaginary));
    }

    public ComplexNumber Sub(ComplexNumber other)
    {
        return new ComplexNumber((this._real - other._real), (this._imaginary - other._imaginary));
    }

    public ComplexNumber Div(ComplexNumber other)
    {
        return new ComplexNumber((this._real * other._real + this._imaginary * other._imaginary) / (other._real * other._real + other._imaginary * other._imaginary)
            , (this._imaginary * other._real - this._real * other._imaginary) / (other._real * other._real + other._imaginary * other._imaginary));
    }

    public double Abs()
    {
        return Math.Abs(Math.Sqrt(_real * _real + _imaginary * _imaginary));
    }

    public ComplexNumber Conjugate()
    {
        return new ComplexNumber(_real, _imaginary * -1);
    }
    
    public ComplexNumber Exp()
    {
        return new ComplexNumber(Math.Pow(Math.E, _real) * (Math.Cos(_imaginary) + Math.Sin(_imaginary)), Math.Sin(_imaginary));
    }
}