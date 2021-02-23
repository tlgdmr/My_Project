using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("&&&&&&&&&&&&&&");
            Console.WriteLine("Choose Option: ");
            Console.WriteLine("1) Start , 2) How to Play ? ");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                start();
            }
            else if (input == 2)
            {
                HowToPlay();
            }
        }
        private static void HowToPlay()
        {
            Console.WriteLine(@"Firstly You write your own number and 
computer will tell you write it higher bumner or lower Good Luck :)");
            Console.WriteLine("&&&&&&&&&&&&&&&");
            Console.WriteLine("Press Enter to Play");
            string key = Console.ReadLine();
            if (key == ""+"")
            {
                start();
            }
        }
        private static void start()
        {
            int time = 0;
            int input = 0;
            int num;
            Random number = new Random();
            num = number.Next(1,10);

            while (num != input)
            {
                time++;

                Console.Write("Enter number: ");
                input = int.Parse(Console.ReadLine());
                if (num == input)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("You Found it {0}. attempting", time);
                }
                else if (input > num)
                {
                    Console.Write("(Lower)");
                }
                else if(input< num)
                {
                    Console.Write("(Higher)");
                }
            }
        }
    }
}
