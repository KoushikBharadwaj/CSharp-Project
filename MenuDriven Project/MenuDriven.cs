using System;
using System.IO;

public class MenuDrivenProgram
{
	public interface StackADT
    {
        bool isEmpty();
        void Push(object element);
        object Pop();
        object Peek();
        void Display();
    }

    public class Stack : StackADT
    {
        private int stackSize;
        private int top;
        private object[] item;
		
		  public int StackSize
        {
        get { return stackSize; }
        set { stackSize = value; }
        }

        public Stack()
        {
            StackSize = 10;
            item = new object[StackSize];
            top = -1;
        }

        public Stack(int capacity)
        {
            StackSize = capacity;
            item = new object[StackSize];
            top = -1;
        }

        public bool isEmpty()
        {
            return top == -1;
        }

        public void Push(object element)
        {
            if (top == (StackSize - 1))
            {
                Console.WriteLine("Stack is full!");
            }
            else
            {
                item[++top] = element;
                Console.WriteLine("Item pushed successfully!");
            }
        }

        public object Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return null;
            }
            else
            {
                return item[top--];
            }
        }

        public object Peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return null;
            }
            else
            {
                return item[top];
            }
        }

        public void Display()
        {
            for (int i = top; i > -1; i--)
            {
                Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
            }
        }
    }
	
//************************************************************************************************************************************************************************************************

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

//************************************************************************************************************************************************************************************************
	
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

//************************************************************************************************************************************************************************************************

public abstract class Shape
{
    public abstract double GetPerimeter();
    public abstract double GetArea();
}

public class CircleShape : Shape
{
    private double radius;
    private readonly double pi = Math.PI;

    public CircleShape()
    {
        this.radius = 1;
    }

    public CircleShape(double radius)
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

public class TriangleShape : Shape
{
    private double width, height;

    public TriangleShape()
    {
        this.width = 1;
        this.height = 1;
    }

    public TriangleShape(double width, double height)
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
	
//************************************************************************************************************************************************************************************************

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

	
//************************************************************************************************************************************************************************************************	
	
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            DisplayMenu();

            string input = Console.ReadLine();
            int choice;

            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        ExecuteArithmeticOperations();
                        break;
                    case 2:
                        ExecuteArmstrongOfANumber();
                        break;
                    case 3:
                        ExecuteSubstringsOfString();
                        break;
                    case 4:
                        ExecuteZeroException();
                        break;
                    case 5:
                        ExecutePascalsTriangle();
                        break;
                    case 6:
                        ExecuteFloydsTriangle();
                        break;
                    case 7:
                        ExecutePascalAndFloyd();
                        break;
					case 8:
                        ExecuteReadTextFile();
						break;
					case 9:
                        ExecuteStackOperations();
                        break;
					case 10:
                        ExecuteComplexNumbers();
                        break;
					case 11:
                        ImplementPolymorphismConcept();
                        break;
					case 12:
                        ImplementAbstractClass();
                        break;
					case 13:
                        ImplementInterfaceForResizable();
                        break;						
                    case 0:
                        Console.WriteLine("Exiting the menu.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
	
//************************************************************************************************************************************************************************************************	

    static void DisplayMenu()
    { 
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("================================================================================================================");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("= Name: Koushik Bharadwaj R                                                                                    =");
		Console.WriteLine("= USN: 4MH21CS041                                                                                              =");
		Console.WriteLine("= Sec : A                                                                                                      =");
		Console.WriteLine("= Instructor : Mr.Victor Ikechukwu Agughasi                                                                    =");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("================================================================================================================");
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("=                                         Welcome to the Main Menu                                             =");
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("================================================================================================================");
        Console.ResetColor();
		Console.WriteLine("================================================================================================================");
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("= 1. Execute Arithmetic Operations                                                                             =");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("================================================================================================================");
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("= 2. Execute Armstrong Of A Number                                                                             =");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("================================================================================================================");
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("= 3. Execute Substrings O fString                                                                              =");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("================================================================================================================");
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("= 4. Execute Zero Exception                                                                                    =");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("================================================================================================================");
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("= 5. Execute Pascal's Triangle                                                                                 =");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("================================================================================================================");
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("= 6. Execute Floyd's Triangle                                                                                  =");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("================================================================================================================");
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("= 7. Execute Pascal And Floyd                                                                                  =");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("================================================================================================================");
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("= 8. Read and copy a text file                                                                                 =");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("================================================================================================================");
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("= 9. Implement Stack Operation                                                                                 =");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("================================================================================================================");	
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("= 10. Execute Complex Numbers                                                                                  =");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("================================================================================================================");
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("= 11. Implement Polymorphism Concepts                                                                          =");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("================================================================================================================");
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("= 12. Implement Abstract Class                                                                                 =");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("================================================================================================================");
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("= 13. Implement Interface For Resizable                                                                        =");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("================================================================================================================");		
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("= 0. Exit                                                                                                      =");
		Console.WriteLine("=                                                                                                              =");
        Console.WriteLine("================================================================================================================");
		Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("================================================================================================================");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("= Copyright (c) 2024 Koushik Bharadwaj R. All Rights Reserved.                                                 =");
		Console.WriteLine("= Permission is hereby granted for educational purposes only.                                                  =");
		Console.WriteLine("=                                                                                                              =");
		Console.WriteLine("================================================================================================================");
        Console.Write("Enter your choice: ");
    }
	
//************************************************************************************************************************************************************************************************	

    static void ExecuteArithmeticOperations()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("***************************************************");
        Console.WriteLine("*       Executing Arithmetic Operations....       *");
        Console.WriteLine("***************************************************");

        RunArithmeticProgram();
        Console.WriteLine("execution complete.");

        Console.ResetColor();
        Console.WriteLine("***************************************");
        Console.WriteLine();
    }

    static void ExecuteArmstrongOfANumber()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("***************************************************");
        Console.WriteLine("*        Executing Armstrong operation...         *");
        Console.WriteLine("***************************************************");

        RunArmstrongOfNumber();
        Console.WriteLine("execution complete.");

        Console.ResetColor();
        Console.WriteLine("***************************************");
        Console.WriteLine();
    }

    static void ExecuteSubstringsOfString()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("***************************************************");
        Console.WriteLine("*        Executing Substrings of string...        *");
        Console.WriteLine("***************************************************");

        Console.WriteLine("Enter a String :");
        string input_string = Console.ReadLine();
        RunSubstringsOfString(input_string);
        Console.WriteLine("execution complete.");

        Console.ResetColor();
        Console.WriteLine("***************************************");
        Console.WriteLine();
    }

    static void ExecuteZeroException()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("***************************************************");
        Console.WriteLine("*           Executing Zero Exception...           *");
        Console.WriteLine("***************************************************");

        RunZeroException();
        Console.WriteLine("execution complete.");

        Console.ResetColor();
        Console.WriteLine("***************************************");
        Console.WriteLine();
    }

    static void ExecutePascalsTriangle()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("***************************************************");
        Console.WriteLine("*         Executing Pascal's Triangle...          *");
        Console.WriteLine("***************************************************");

        RunPascalsTriangle();
        Console.WriteLine("execution complete.");

        Console.ResetColor();
        Console.WriteLine("***************************************");
        Console.WriteLine();
    }

    static void ExecuteFloydsTriangle()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("****************************************************");
        Console.WriteLine("*          Executing Floyd's Triangle...           *");
        Console.WriteLine("****************************************************");

        RunFloydsTriangle();
        Console.WriteLine("execution complete.");

        Console.ResetColor();
        Console.WriteLine("***************************************");
        Console.WriteLine();
    }

    static void ExecutePascalAndFloyd()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("*****************************************************");
        Console.WriteLine("*           Executing Pascal and Floyd...           *");
        Console.WriteLine("*****************************************************");

        Console.Write("Enter the number of rows for Pascal's and Floyd's Triangle: ");
        int numRows = Convert.ToInt32(Console.ReadLine());

        PrintPascalAndFloyd(numRows);

        Console.WriteLine("execution complete.");

        Console.ResetColor();
        Console.WriteLine("***************************************");
        Console.WriteLine();
    }
	
    static void ExecuteReadTextFile()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("******************************************************");
        Console.WriteLine("*            Executing Read Text File...             *");
        Console.WriteLine("******************************************************");

        RunReadTextFile();
        Console.WriteLine("execution complete.");

        Console.ResetColor();
        Console.WriteLine("***************************************");
        Console.WriteLine();
    }
	
    static void ExecuteStackOperations()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("*******************************************************");
		Console.WriteLine("*            Executing Stack operations...            *");
		Console.WriteLine("*******************************************************");

		RunStackOperations();
		Console.WriteLine("execution complete.");

		Console.ResetColor();
		Console.WriteLine("***************************************");
		Console.WriteLine();
    }

    static void ExecuteComplexNumbers()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
		Console.WriteLine("*******************************************************");
        Console.WriteLine("*            Executing Complex Numbers...             *");
		Console.WriteLine("*******************************************************");

        RunComplexNumbers();
        Console.WriteLine("execution complete.");

        Console.ResetColor();
        Console.WriteLine("***************************************");
        Console.WriteLine();
    }
	
    static void ImplementPolymorphismConcept()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
		Console.WriteLine("*******************************************************");
        Console.WriteLine("*         Executing Polymorphism Concepts...          *");
		Console.WriteLine("*******************************************************");

        RunPolymorphismConcept();
        Console.WriteLine("execution complete.");

        Console.ResetColor();
        Console.WriteLine("***************************************");
        Console.WriteLine();
    }
	
    static void ImplementAbstractClass()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
		Console.WriteLine("*******************************************************");
        Console.WriteLine("*             Executing Abstract Class...             *");
		Console.WriteLine("*******************************************************");

        RunAbstractClass();
        Console.WriteLine("execution complete.");

        Console.ResetColor();
        Console.WriteLine("***************************************");
        Console.WriteLine();
    }
		
    static void ImplementInterfaceForResizable()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
		Console.WriteLine("*******************************************************");
        Console.WriteLine("*           Executing Resizable Interface...          *");
		Console.WriteLine("*******************************************************");

        RunResizeableInterface();
        Console.WriteLine("execution complete.");

        Console.ResetColor();
        Console.WriteLine("***************************************");
        Console.WriteLine();
    }
	
//************************************************************************************************************************************************************************************************	
	//  1.
    static void RunArithmeticProgram()
    {
        Console.WriteLine("Enter a First Operand: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a Second Operand: ");
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
	
	//  2.
    static void RunArmstrongOfNumber()
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

	//  3.
    static void RunSubstringsOfString(string input_string)
    {
        int j = 0;
        int i = 0;
        for (i = 1; i <= input_string.Length; i++)
        {
            for (j = 0; j <= input_string.Length - i; j++)
            {
                Console.WriteLine(input_string.Substring(j, i));
            }
        }
    }

	//  4.
    static void RunZeroException()
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

	//  5.
    static void RunPascalsTriangle()
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

	//  6.
    static void RunFloydsTriangle()
    {
        Console.Write("Enter the number of rows: ");
        int numRows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        int num = 1;
        for (int i = 1; i <= numRows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine("");
        }
    }
	
	//  7.
	static void PrintPascalAndFloyd(int numRows)
    {

        PrintPascalsTriangle(numRows);
        PrintFloydsTriangle(numRows);
        PrintPascalsTriangle(numRows);
        PrintFloydsTriangle(numRows);
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
            Console.WriteLine("");
        }
    }
	
	//  8.
	static void RunReadTextFile()
    {
		string file = @"H:\MenuDriven Project\qu.txt";
		Console.WriteLine("Reading File using File.ReadAllText()");
		if (File.Exists(file))
		{
			string str = File.ReadAllText(file);
			Console.WriteLine(str);
		}
		Console.WriteLine();
		Console.WriteLine("Reading File using File.ReadAllLines()");
		if (File.Exists(file))
		{
			string[] lines = File.ReadAllLines(file);
			foreach (string ln in lines)
            Console.WriteLine(ln);
		}
		Console.WriteLine();
		Console.WriteLine("Reading File using StreamReader");
		if (File.Exists(file))
		{
        using (StreamReader Textfile = new StreamReader(file))
			{
				string line;
				while ((line = Textfile.ReadLine()) != null)
				{
                Console.WriteLine(line);
				}
			}
		}
    Console.WriteLine();
    }
	
	//  9.
	static void RunStackOperations()
	{
    Stack st = new Stack();
    while (true)
    {
        Console.WriteLine("\nSTACK MENU (size - 10)");
        Console.WriteLine("1. Add an element");
        Console.WriteLine("2. See the top element");
        Console.WriteLine("3. Remove top element");
        Console.WriteLine("4. Display stack elements");
        Console.WriteLine("5. Exit");
        Console.Write("Select your choice: ");
        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            continue;
        }
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter an Element: ");
                st.Push(Console.ReadLine());
                break;
            case 2:
                if (!st.isEmpty())
                    Console.WriteLine("Top element is: {0}", st.Peek());
                else
                    Console.WriteLine("Stack is empty!");
                break;
            case 3:
                if (!st.isEmpty())
                    Console.WriteLine("Element removed: {0}", st.Pop());
                else
                    Console.WriteLine("Stack is empty!");
                break;
            case 4:
                if (!st.isEmpty())
                    st.Display();
                else
                    Console.WriteLine("Stack is empty!");
                break;
            case 5:
                return;
            default:
                Console.WriteLine("Invalid choice. Please enter a valid option.");
                break;
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();
    }
	}
	
	//  10.
	static void RunComplexNumbers()
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
	}
	
	//  11.
	static void RunPolymorphismConcept()
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
	
	//  12.
	static void RunAbstractClass()
	{
		Console.WriteLine("Enter the width of the triangle:");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the triangle:");
        double height = Convert.ToDouble(Console.ReadLine());

        Shape triangle = new TriangleShape(width, height);
        Console.WriteLine("\nThe width of the triangle is: " + width
        + "\nThe height of the triangle is: " + height
		+ "\nThe area of the triangle is: " + triangle.GetArea()
        + "\nThe perimeter of the triangle is: " + triangle.GetPerimeter() + ".");

        Console.WriteLine("\nEnter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        Shape circle = new CircleShape(radius);
        Console.WriteLine("\nThe radius of the circle is: " + radius
        + "\nThe area of the circle is: " + circle.GetArea()
        + "\nThe perimeter of the circle is: " + circle.GetPerimeter() + ".");
	}
	
	//  13.
	static void RunResizeableInterface()
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
//

