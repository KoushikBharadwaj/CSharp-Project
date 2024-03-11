using System;

namespace ConsoleApplication
{
    public class Stack : StackADT
    {
        private int stackSize;
        public int StackSize
        {
            get { return stackSize; }
            set { stackSize = value; }
        }
        private int top;
        private object[] item;

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

    public interface StackADT
    {
        bool isEmpty();
        void Push(object element);
        object Pop();
        object Peek();
        void Display();
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Stack st = new Stack();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nStack MENU(size -- 10)");
                Console.WriteLine("1. Add an element");
                Console.WriteLine("2. See the Top element.");
                Console.WriteLine("3. Remove top element.");
                Console.WriteLine("4. Display stack elements.");
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
                        Console.WriteLine("Enter an Element : ");
                        st.Push(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Top element is: {0}", st.Peek());
                        break;
                    case 3:
                        Console.WriteLine("Element removed: {0}", st.Pop());
                        break;
                    case 4:
                        st.Display();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }
        }
    }
}
