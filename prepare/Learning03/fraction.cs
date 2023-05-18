using System;

public class Fraction
{
  private int _numerator;
  private int _denominator;

    public Fraction()
    {
      _numerator = 1;
      _denominator =1;
      Console.WriteLine($"{_numerator}/{_denominator}");
    }

    public Fraction(int wholeNumber)
    {
      _numerator = wholeNumber;
      _denominator = 1;
      Console.WriteLine($"{_numerator}/{_denominator}");
    }

    public Fraction(int numerator, int denominator)
    {
      _numerator = numerator;
      _denominator = denominator;
      Console.WriteLine($"{_numerator}/{_denominator}");
    }

    private void GetTop()
    {

    }

    private void SetTop(int numerator)
    {

    }

    private void GetBottom()
    {

    }

    private void SetBottom(int denominator)
    {

    }

    private void GetFractionString()
    {
      //return string
    }

    private void GetDecimalValue()
    {
      //return double
    }
  




}