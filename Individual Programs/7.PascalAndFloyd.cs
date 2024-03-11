using System;

namespace TriangleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows for Pascal's and Floyd's Triangle: ");
            int numRows = Convert.ToInt32(Console.ReadLine());

            
            PrintPascalsTriangle(numRows);

            
            PrintFloydsTriangle(numRows);

            
            PrintPascalsTriangle(numRows);

            
            PrintFloydsTriangle(numRows);
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
            Console.WriteLine();
        }

        static void PrintFloydsTriangle(int numRows)
        {
            int num = 1;
            for (int i = 1; i <= numRows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
