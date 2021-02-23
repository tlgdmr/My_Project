using System;

namespace Rock_Scissors_Paper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine(">>> Welcome to the Rock Scissors Paper game");
            
            Console.WriteLine(" ");

            Console.WriteLine("1= Start the game ");
            Console.WriteLine("2= Who created it ?");
            Console.WriteLine("3= Exit");

            int input = int.Parse(Console.ReadLine());


            switch (input)
            {
                case 1:
                    Start();
                    break;
                case 2:
                    aboutAuthor();
                    break;
                case 3:
                    Exit();
                    break;

            }
            static void Exit()
            {
                Console.Clear();
                Console.WriteLine("Did you enjoy? \n 1=Yes , 2=No ");

                int enjoyOrNot = int.Parse(Console.ReadLine());

                if (enjoyOrNot == 1)
                {
                    Start();
                }
                else if (enjoyOrNot == 2)
                {
                    Console.WriteLine("May we meet again");
                }
            }
            static void Start()
            {
                Console.Clear();

                Console.WriteLine("1) Rock , 2) Paper 3) Scissors");
                int playerInput = int.Parse(Console.ReadLine());
                int computer;
                Random game = new Random();
                computer = game.Next(1, 4);
                
                
                    switch (computer)
                     {
                        case 1:
                            Console.WriteLine("Computer Choose Rock ");
                            if (playerInput == 2)
                            {
                                Console.WriteLine("You Won");
                            }
                            else if (playerInput == 3)
                            {
                                Console.WriteLine("You Loose");
                            }
                            else if (playerInput== 1)
                            {
                                Console.WriteLine("Draw");
                            }
                            else
                            {
                                Start();
                            }
                              break;

                    case 2:
                            Console.WriteLine("Computer Choose Paper");

                            if (playerInput == 2)
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (playerInput == 3)
                            {
                                Console.WriteLine("You Won");
                            }
                            else if(playerInput== 1)
                            {
                                Console.WriteLine("Loose");
                            }
                            else
                            {
                            Start();
                            }
                               break;

                    case 3:
                            Console.WriteLine("Computer Choose Scissors");

                            if (playerInput == 2)
                            {
                                Console.WriteLine("Loose");
                            }
                            else if (playerInput == 3)
                            {
                                Console.WriteLine("Draw");
                            }
                            else if(playerInput == 1)
                            {
                                Console.WriteLine("Won");
                            }
                            else
                            {
                                Start();
                            }
                               break;

                }

                Console.WriteLine("Press enter the countinue");
                string input = Console.ReadLine();
                if (input == "" + "")
                {
                    Start();
                }


            }
            static void aboutAuthor()
            {
                Console.Clear();
                Console.WriteLine(@">>> Hi Guys I know you have been asking for person 
    who created it I am Tolga I have been learning C# One day I will earn my money by myselfy 
    only then everything will change Enjoy the Game :)");

                Console.WriteLine(" ");

                Console.WriteLine(@">>> Press 'enter' to get back to Main Menü
    or press P to play the game");

                string choosen = Console.ReadLine();
               
                 if (choosen == "" + "")
                 {
                      Main(null);
                 }
                  else if (choosen.ToLower() == "p")
                  {
                    Start();
                  }
            }
        }
    }
}
