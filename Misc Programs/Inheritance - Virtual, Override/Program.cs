//learning areas - Inheritance, Overriding functions, Protected access
using System;

class Shape
{
    public string Name { get; set; }

    public Shape(string name)
    {
        Name = name;
    }

    public virtual double Area()
    {
        return 0;
    }

    public virtual double Perimeter()
    {
        return 0;
    }
}

class Rectangle : Shape
{
    protected double Length { get; set; }
    protected double Width { get; set; }

    public Rectangle(double length, double width, string name) : base(name)
    {
        Length = length;
        Width = width;
    }

    public override double Area()
    {
        return Length * Width;
    }

    public override double Perimeter()
    {
        return 2 * (Length + Width);
    }
}

class Circle : Shape
{
    protected double Radius { get; set; }

    public Circle(double radius, string name) : base(name)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(8, 4, "Rectangle");
        Circle circle = new Circle(4.0, "Circle");

        Console.WriteLine($"Shape: {rectangle.Name}");
        Console.WriteLine($"Area: {rectangle.Area()}");
        Console.WriteLine($"Perimeter: {rectangle.Perimeter()}\n");

        Console.WriteLine($"Shape: {circle.Name}");     
        Console.WriteLine($"Area (2 decimal places): {circle.Area():F2}");
        Console.WriteLine($"Perimeter (2 decimal places): {circle.Perimeter():F2}");
    }
}
