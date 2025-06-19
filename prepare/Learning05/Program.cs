using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square(3, "Red");
        shapes.Add(s1);

        Rectangle s2 = new Rectangle(4, 5, "Blue");
        shapes.Add(s2);

        Circle s3 = new Circle(6, "Green");
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has and area of {area}.");
        }
    }
}