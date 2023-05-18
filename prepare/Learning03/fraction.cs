using System;

public class Fraction
{
  private int _numerator;
  private int _denominator;

    public Fraction()
    {
      _numerator = 1;
      _denominator =1;
      //Console.WriteLine($"{_numerator}/{_denominator}");
    }

    public Fraction(int wholeNumber)
    {
      _numerator = wholeNumber;
      _denominator = 1;
      //Console.WriteLine($"{_numerator}/{_denominator}");
    }

    public Fraction(int numerator, int denominator)
    {
      _numerator = numerator;
      _denominator = denominator;
      //Console.WriteLine($"{_numerator}/{_denominator}");
    }

    public int GetTop()
    {
      return _numerator;
    }

    public void SetTop(int numerator)
    {
      _numerator = numerator;
    }

    public int GetBottom()
    {
      return _denominator;
    }

    public void SetBottom(int denominator)
    {
      _denominator = denominator;
    }

    public string GetFractionString()
    {
      //return string
      string value = $"{_numerator}/{_denominator}";
      return value;

    }

    public double GetDecimalValue()
    {
      //return double
      return (double)_numerator / (double)_denominator;
    }

}