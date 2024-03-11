using System;

public class Arithmetic
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a First Number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a Second Number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;
        double quotient = num1 / num2;
        double remainder = num1 % num2;
        double exponentiation;
		string exponentiationExpression;
        if (num1 < num2)
        {
        exponentiation = Math.Pow(num2, num1);
		exponentiationExpression = string.Format("{0} ^ {1}", num2, num1);
        }
        else
        {
        exponentiation = Math.Pow(num1, num2);
		exponentiationExpression = string.Format("{0} ^ {1}", num1, num2);
        }
        double squareRoot = Math.Sqrt(num1);

        sum = Math.Round(sum, 4);
        difference = Math.Round(difference, 4);
        product = Math.Round(product, 4);
        quotient = Math.Round(quotient, 4);
        remainder = Math.Round(remainder, 4);
        exponentiation = Math.Round(exponentiation, 4);
        squareRoot = Math.Round(squareRoot, 4);

        Console.WriteLine("Sum of {0} and {1} is: {2}", num1, num2, sum);
        Console.WriteLine("Difference of {0} and {1} is: {2}", num1, num2, difference);
        Console.WriteLine("Product of {0} and {1} is: {2}", num1, num2, product);
        Console.WriteLine("Quotient of {0} and {1} is: {2}", num1, num2, quotient);
        Console.WriteLine("Remainder of {0} and {1} is: {2}", num1, num2, remainder);
        Console.WriteLine("Exponentiation {0} is: {1}", exponentiationExpression, exponentiation);
        Console.WriteLine("Square root of {0} is: {1}", num1, squareRoot);
    }
}
