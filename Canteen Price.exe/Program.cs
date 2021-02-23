using System;
using System.Collections.Generic;

namespace Canteen_Price.exe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***************");
            Console.WriteLine("Welcome to the Canteen Price! ");
            Console.WriteLine("****************");
            Console.WriteLine("Press 1 to buy something , Press 2 to show price of products");
            int input = int.Parse(Console.ReadLine());
            if (input == 2)
            {
                Showing();
            }
            else if (input == 1)
            {
                buying();
            }
        }

        private static void buying()
        {
            Console.Clear();
            while (true)
            {
                Console.Write("Enter your Money: ");
                float money = float.Parse(Console.ReadLine());
                Console.Write(" ");
                Console.Write("What do you want: ");
                string input = Console.ReadLine();
                Console.Write(" ");
                Console.Write("How much Do you want for this item: ");
                int times = int.Parse(Console.ReadLine());

                float juice = 1.65f;
                float toast = 2.50f;
                float cola = 3.45f;
                float nuggets = 6.99f;
                float honey = 25.55f;
                float sandwich = 5.45f;
                float kebap = 7.50f;

                switch (input)
                {
                    case "orange juice":
                        {
                            Console.Clear();
                            float leftCash = (money - (times * juice));
                            float leftMoney = ((times * juice) - money);
                            Console.WriteLine(Math.Round(leftCash, 2));
                            if (leftCash < 0)
                            {
                                Console.WriteLine("Sorry bu you need " + Math.Round(leftMoney, 2) + "$ If you want to buy anything else ");
                            }
                            else
                            {
                                Console.WriteLine("Cahs left over is above  If you want to buy anything else ");
                            }
                            break;
                        }
                    case "cola":
                        {
                            Console.Clear();
                            float leftCash = (money - (times * cola));
                            float leftMoney = ((times * cola) - money);
                            Console.WriteLine(Math.Round(leftCash, 2));
                            if (leftCash < 0)
                            {
                                Console.WriteLine("Sorry bu you need " + Math.Round(leftMoney, 2) + "$ If you want to buy anything else ");
                            }
                            else
                            {
                                Console.WriteLine("Cahs left over is above  If you want to buy anything else ");
                            }
                            break;
                        }
                    case "toast":
                        {
                            Console.Clear();
                            float leftCash = (money - (times * toast));
                            float leftMoney = ((times * toast) - money);
                            Console.WriteLine(Math.Round(leftCash, 2));
                            if (leftCash < 0)
                            {
                                Console.WriteLine("Sorry bu you need " + Math.Round(leftMoney, 2) + "$ If you want to buy anything else ");
                            }
                            else
                            {
                                Console.WriteLine("Cahs left over is above  If you want to buy anything else ");
                            }
                            break;
                        }
                    case "nuggets":
                        {
                            Console.Clear();
                            float leftCash = (money - (times * nuggets));
                            float leftMoney = ((times * nuggets) - money);
                            Console.WriteLine(Math.Round(leftCash, 2));
                            if (leftCash < 0)
                            {
                                Console.WriteLine("Sorry bu you need " + Math.Round(leftMoney, 2) + "$ If you want to buy anything else ");
                            }
                            else
                            {
                                Console.WriteLine("Cahs left over is above  If you want to buy anything else ");
                            }
                            break;
                        }
                    case "kebap":
                        {
                            Console.Clear();
                            float leftCash = (money - (times * kebap));
                            float leftMoney = ((times * kebap) - money);
                            Console.WriteLine(Math.Round(leftCash, 2));
                            if (leftCash < 0)
                            {
                                Console.WriteLine("Sorry bu you need " + Math.Round(leftMoney, 2) + "$ If you want to buy anything else ");
                            }
                            else
                            {
                                Console.WriteLine("Cahs left over is above  If you want to buy anything else ");
                            }
                            break;
                        }
                    case "honey":
                        {
                            Console.Clear();
                            float leftCash = (money - (times * honey));
                            float leftMoney = ((times * honey) - money);
                            Console.WriteLine(Math.Round(leftCash, 2));
                            if (leftCash < 0)
                            {
                                Console.WriteLine("Sorry bu you need " + Math.Round(leftMoney, 2) + "$ If you want to buy anything else ");
                            }
                            else
                            {
                                Console.WriteLine("Cahs left over is above  If you want to buy anything else ");
                            }
                            break;
                        }
                    case "sandwich":
                        {
                            Console.Clear();
                            float leftCash = (money - (times * sandwich));
                            float leftMoney = ((times * sandwich) - money);
                            Console.WriteLine(Math.Round(leftCash, 2));
                            if (leftCash < 0)
                            {
                                Console.WriteLine("Sorry bu you need " + Math.Round(leftMoney, 2) + "$ If you want to buy anything else ");
                            }
                            else
                            {
                                Console.WriteLine("Cahs left over is above  If you want to buy anything else ");
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
        }
        public static void Showing()
        {
            Console.Clear();
            List<string> price = new List<string>();
            price.Add("Orange juice: 1.65");
            price.Add("Toast: 2.50");
            price.Add("Cola: 3.45");
            price.Add("Nuggets: 6.99");
            price.Add("Honey: 25,55");
            price.Add("Sandwich: 5.45");
            price.Add("Kebap: 7.50");

            foreach (var products in price)
            {
                Console.WriteLine(products);
            }
           
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to buy something?");
            string choosen = Console.ReadLine();
            if (choosen ==""+"")
            {
                buying();
            }
        }  
    }
}
