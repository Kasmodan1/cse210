using System;

class Program
{
    
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Blue", 4);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("yellow", 2, 4);
        shapes.Add(rectangle);

        Circle circle = new Circle("green", 4);
        shapes.Add(circle);
                                
        foreach (Shape item in shapes)
        {
            string color = item.GetColor();

            double area = item.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }   
}