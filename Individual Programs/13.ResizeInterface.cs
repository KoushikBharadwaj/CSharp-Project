using System;

public interface IResizable
{
    void ResizeWidth(int width);
    void ResizeHeight(int height);
}

public class Rectangle : IResizable
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void ResizeWidth(int width)
    {
        this.width = width;
    }

    public void ResizeHeight(int height)
    {
        this.height = height;
    }

    public void PrintSize()
    {
        Console.WriteLine("Width: " + width + ", Height: " + height);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the width of the rectangle:");
        int width = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the height of the rectangle:");
        int height = Convert.ToInt32(Console.ReadLine());

        Rectangle rectangle = new Rectangle(width, height);

        Console.WriteLine("\nInitial size of the rectangle:");
        rectangle.PrintSize();
		
        rectangle.ResizeWidth(width * 2);
        rectangle.ResizeHeight(height * 2);

        Console.WriteLine("\nUpdated size of the rectangle:");
        rectangle.PrintSize();
    }
}
