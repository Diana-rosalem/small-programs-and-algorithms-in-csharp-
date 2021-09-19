using System;

namespace rock_paper_scissors
{
    class Program
    {

        static void Main(string[] args)
        {
            Thing rock = new Rock();
            Thing paper = new Paper();
            Thing scissors = new Scissors();

            int op;
            int botWin = 0;
            int playerWin = 0;
            int tied = 0;
            int play = 10;


            do
            {
                Console.WriteLine("\n===================== GAME MENU =====================");
                Console.WriteLine("--> welcome to the game Rock-Paper-Scissors ");
                Console.WriteLine("Enter 1 to play Rock ");
                Console.WriteLine("Enter 2 to play paper ");
                Console.WriteLine("Enter 3 to play Scissors ");
                Console.WriteLine("Enter 4 for exit");
                Console.WriteLine("=====================================================\n");
                Console.WriteLine("===================== SCORE =========================");
                Console.WriteLine($"You win:{playerWin}");
                Console.WriteLine($"Bot Win:{botWin}");
                Console.WriteLine($"draws:{tied}");
                Console.WriteLine("\n=====================================================");
                Console.WriteLine($"{play} moves left");
                Console.Write("type your move:");

                op = int.Parse(Console.ReadLine());
                play--;

                Thing playerOP = null;
                Thing botOP = null;

                Random rand = new Random();
                int random = rand.Next(1, 4);

                switch(random)
                {
                    case 1:
                        botOP = rock;
                        break;

                    case 2:
                        botOP = paper;
                        break;

                    case 3:
                        botOP = scissors;
                        break;

                }

                Console.Clear();

                switch (op)
                {
                    case 1:
                        playerOP = rock;

                        if (botOP.winRock == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("the bot threw paper! You lose :(");
                            botWin++;
                            Console.ResetColor();
                        }
                        else if (botOP.winRock == false && botOP.loseRock == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("The bot threw scissors! You win :)");
                            playerWin++;
                            Console.ResetColor();
                        }
                        else if (botOP.winRock == false && botOP.loseRock == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("The bot threw rock! It tied :|");
                            tied++;
                            Console.ResetColor();
                        }


                        break;
                    case 2:
                        playerOP = paper;

                        if (botOP.winPaper == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("the bot threw scissors! You lose :( ");
                            tied++;
                            Console.ResetColor();
                        }
                        else if (botOP.winPaper == false && botOP.losePaper == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("The bot threw rock ! You win :)");
                            playerWin++;
                            Console.ResetColor();
                        }
                        else if (botOP.winRock == false && botOP.loseRock == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("The bot threw paper ! It tied :|");
                            tied++;
                            Console.ResetColor();
                        }

                        break;
                    case 3:
                        playerOP = scissors;

                        if (botOP.winScissors == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("the bot threw rock! You lose :( ");
                            tied++;
                            Console.ResetColor();
                        }
                        else if (botOP.winScissors == false && botOP.loseScissors == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("The bot threw paper! You win :)");
                            playerWin++;
                            Console.ResetColor();
                        }
                        else if (botOP.winScissors == false && botOP.loseScissors == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("The bot threw scissors ! It tied :|");
                            tied++;
                            Console.ResetColor();
                        }
                        break;

                    case 4:
                        Console.WriteLine("leaving the game");
                        break;

                    default:
                        Console.WriteLine("please enter a valid number");
                        break;
                }

            } while (op != 4 && play >= 0);  

            
           
        }
    }
}
