using System.Diagnostics;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }
    
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetNumerator()
    {
        return _top;
    }

    public void SetNumerator(int numerator)
    {
        _top = numerator;
    }

    public int GetDenominator()
    {
        return _bottom;
    }

    public void SetDenominator(int denominator)
    {
        _bottom = denominator;
    }

    public string GetFractionString()
    {
        string fractionText = $"{_top}/{_bottom}"; 
        return fractionText;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}