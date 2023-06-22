using System;

class Square : Shape
{
    double _side;
    
    public Square(string color, double sides) : base (color)
    {
        _side = sides;
    }

    public override double GetArea()
    {
        return _side * _side;
    }

}