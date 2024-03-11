using System;

public class Armstrong
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int originalNumber = number;
        int numberOfDigits = (int)Math.Floor(Math.Log10(number)) + 1;

        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, numberOfDigits);
            number /= 10;
        }

        if (originalNumber == sum)
        {
            Console.WriteLine("{0} is an Armstrong number.", originalNumber);
        }
        else
        {
            Console.WriteLine("{0} is not an Armstrong number.", originalNumber);
        }
    }
}
