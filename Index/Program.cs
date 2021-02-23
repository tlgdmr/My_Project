using System;

namespace Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("***************************");
            Console.WriteLine("Hİ WELCOME TO THE INDEX CALCULATOR");
            Console.WriteLine("***************************");
            Console.WriteLine("***************************");
            Console.WriteLine(" ");
            Console.WriteLine("PRESS SOMETHING TO CALCULATE");
            String input = Console.ReadLine();
            if (input == "" + "")
            {
                calculator();
            }
            else
            {
                calculator();
            }
        }

        private static void calculator()
        {
            Console.Clear();
            Console.WriteLine("Use comma when your write your height please ");
            Console.WriteLine(" ");
            Console.Write("Enter Your Weight: ");
            byte weight = byte.Parse(Console.ReadLine());
            Console.Write("Enter Your Height: ");
            float height = float.Parse(Console.ReadLine());

            float calc = weight / (height * height);
            if (calc == 18.5 || calc < 18.5)
            {
                Console.WriteLine(calc);
                Console.WriteLine(" ");
                Console.WriteLine("You Should Gain Weight");
            }
            else if (calc > 18.5 && calc < 24.9)
            {
                Console.WriteLine(calc);
                Console.WriteLine("You Are Normal , No problem");
            }
            else if (calc > 25 && calc < 29.9)
            {
                Console.WriteLine(calc);
                Console.WriteLine("You are owerweight");
            }
            else if (calc < 40 && calc > 30)
            {
                Console.WriteLine(calc);
                Console.WriteLine("You are obese ");
            }
            else if (calc > 40)
            {
                Console.WriteLine(calc);
                Console.WriteLine("You immediately have to loose weight");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" >>Press Enter to Calculate Again ");
            string choosen = Console.ReadLine();

            if (choosen == "" + "")
            {
                calculator();
            }


        }


    }
}
