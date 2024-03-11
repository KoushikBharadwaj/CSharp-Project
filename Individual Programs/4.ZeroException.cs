using System;

public class Divide
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number: ");
            int divisor = int.Parse(Console.ReadLine());

            int result = 15 / divisor;
            Console.WriteLine(result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("DivideByZeroException caught: Cannot divide by zero.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("OverflowException caught: Result exceeds the maximum value of an integer.");
        }
        catch (FormatException)
        {
            Console.WriteLine("FormatException caught: Invalid input. Please enter a valid integer.");
        }
        catch (Exception e)
        {
            Console.WriteLine("An unexpected error occurred: " + e.Message);
        }
    }
}
