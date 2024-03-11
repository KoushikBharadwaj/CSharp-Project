using System;

public interface IShape
{
    void Draw();
    void Erase();
}

public class Circle : IShape
{
    private int radius;

    public Circle(int radius)
    {
        this.radius = radius;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing Circle with radius " + radius);
        Console.WriteLine("  ___");
        Console.WriteLine(" /   \\");
        Console.WriteLine("|     |");
        Console.WriteLine(" \\___/");
    }

    public void Erase()
    {
        Console.WriteLine("Erasing Circle with radius " + radius);
        Console.WriteLine("       ");
        Console.WriteLine("       ");
        Console.WriteLine("       ");
    }
}

public class Triangle : IShape
{
    private int sideLength;

    public Triangle(int sideLength)
    {
        this.sideLength = sideLength;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing Triangle with side length " + sideLength);
        Console.WriteLine("   /\\");
        Console.WriteLine("  /  \\");
        Console.WriteLine(" /____\\");
    }

    public void Erase()
    {
        Console.WriteLine("Erasing Triangle with side length " + sideLength);
        Console.WriteLine("       ");
        Console.WriteLine("       ");
        Console.WriteLine("       ");
    }
}

public class Square : IShape
{
    private int sideLength;

    public Square(int sideLength)
    {
        this.sideLength = sideLength;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing Square with side length " + sideLength);
        Console.WriteLine(" _____");
        Console.WriteLine("|     |");
        Console.WriteLine("|_____|");
    }

    public void Erase()
    {
        Console.WriteLine("Erasing Square with side length " + sideLength);
        Console.WriteLine("       ");
        Console.WriteLine("       ");
        Console.WriteLine("       ");
    }
}

public class Program
{
    public static void Main()
    {
        var shapes = new IShape[]
        {
            new Circle(5),
            new Triangle(4),
            new Square(6)
        };

        foreach (var shape in shapes)
        {
            shape.Draw();
            Console.WriteLine();
            shape.Erase();
            Console.WriteLine("-------------------------------");
        }
    }
}
