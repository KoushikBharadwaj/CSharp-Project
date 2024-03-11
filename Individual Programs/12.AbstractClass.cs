using System;

public abstract class Shape
{
    public abstract double GetPerimeter();
    public abstract double GetArea();
}

public class Circle : Shape
{
    private double radius;
    private readonly double pi = Math.PI;

    public Circle()
    {
        this.radius = 1;
    }

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return pi * Math.Pow(radius, 2);
    }

    public override double GetPerimeter()
    {
        return 2 * pi * radius;
    }
}

public class Triangle : Shape
{
    private double width, height;

    public Triangle()
    {
        this.width = 1;
        this.height = 1;
    }

    public Triangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height / 2;
    }

    public override double GetPerimeter()
    {
        return width + height + Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
    }
}

public class ShapeClient
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the width of the triangle:");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the triangle:");
        double height = Convert.ToDouble(Console.ReadLine());

        Shape triangle = new Triangle(width, height);
        Console.WriteLine("\nThe width of the triangle is: " + width
            + "\nThe height of the triangle is: " + height
            + "\nThe area of the triangle is: " + triangle.GetArea()
            + "\nThe perimeter of the triangle is: " + triangle.GetPerimeter() + ".");

        Console.WriteLine("\nEnter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        Shape circle = new Circle(radius);
        Console.WriteLine("\nThe radius of the circle is: " + radius
            + "\nThe area of the circle is: " + circle.GetArea()
            + "\nThe perimeter of the circle is: " + circle.GetPerimeter() + ".");
    }
}
