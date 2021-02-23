using System;

namespace Calculator.exe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator.exe ");
            Console.WriteLine("↓↓↓↓↓↓↓↓↓↓");
            Console.WriteLine(" ");
            Console.WriteLine(@"Firstly enter your first number then choose mathematical operation
finally enter your last number");
            Console.WriteLine("------------------");
            Console.WriteLine("Press Enter to Calculate ");
            string input = Console.ReadLine();
            if (input == ""+"")
            {
                Calculator();
            }
            
        }

        public static void Calculator()
        {
            Console.Clear();
            Console.Write("First number: ");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.Write("Operation: ");
            string operation = Console.ReadLine();
            Console.Write("Second Number: ");
            float secondNumber = float.Parse(Console.ReadLine());
            switch (operation)
            {
                case "+":
                    {
                        Console.WriteLine((float) firstNumber + secondNumber);
                        break;
                    }
                    
                case "-":
                    {
                        Console.WriteLine((float) firstNumber - secondNumber);
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine((float) firstNumber / secondNumber);
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine((float) firstNumber* secondNumber);
                        break;
                    }
            }
            Console.WriteLine("Enter to calculate again");
            string input = Console.ReadLine();
            if (input == "" + "")
            {
                Calculator();
            }

        }
    }
}
