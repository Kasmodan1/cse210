using System;

class Rectangle : Shape
{
    double _Lside;
    double _Wside;
    
    public Rectangle(string color, double length, double width) : base (color)
    {
        _Lside = length;
        _Wside = width;
    }

    public override double GetArea()
    {
        return _Lside * _Wside;
    }

}