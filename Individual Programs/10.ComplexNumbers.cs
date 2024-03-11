using System;

public struct Complex
{
    private int real;
    private int imaginary;

    public int Real 
    {
        get { return real; }
        set { real = value; }
    }

    public int Imaginary 
    {
        get { return imaginary; }
        set { imaginary = value; }
    }

    public Complex(int real, int imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public static Complex operator +(Complex one, Complex two)
    {
        return new Complex(one.Real + two.Real, one.Imaginary + two.Imaginary);
    }

    public override string ToString()
    {
        if (Imaginary >= 0)
            return Real + " + " + Imaginary + "i";
        else
            return Real + " - " + (-Imaginary) + "i";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the real part of the first complex number:");
        int real1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the imaginary part of the first complex number:");
        int imaginary1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the real part of the second complex number:");
        int real2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the imaginary part of the second complex number:");
        int imaginary2 = Convert.ToInt32(Console.ReadLine());

        Complex val1 = new Complex(real1, imaginary1);
        Complex val2 = new Complex(real2, imaginary2);
        Complex sum = val1 + val2;

        Console.WriteLine("First complex number: " + val1);
        Console.WriteLine("Second complex number: " + val2);
        Console.WriteLine("Sum: " + sum);

        Console.ReadLine(); 
    }
}
