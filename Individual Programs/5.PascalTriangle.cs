using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows for Pascal's Triangle: ");
        int numRows = int.Parse(Console.ReadLine());

        Console.Write("Pascal's Triangle:\n");
        PrintPascalsTriangle(numRows);
    }

    static void PrintPascalsTriangle(int numRows)
    {
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numRows - i - 1; j++)
            {
                Console.Write("   ");
            }
            int number = 1;
            for (int j = 0; j <= i; j++)
            {
                Console.Write("{0,4}   ", number);
                number = number * (i - j) / (j + 1);
            }
            Console.WriteLine();
        }
    }
}
