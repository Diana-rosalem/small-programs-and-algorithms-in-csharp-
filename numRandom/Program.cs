using System;



    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; 
            
            Console.Write("\n\t\t      ==== Solver's game  ====");
            Console.Write("\n     ______________");
            Console.Write("\n    /  ()      () /|");
            Console.Write("\n   /             / |");
            Console.Write("\n  /  ()     ()  /()| \t There is a secret number, try to guess it. ");
            Console.Write("\n +—————————————+   | \t Be careful, you only have 16 chances!!!");
            Console.Write("\n |             |   |");
            Console.Write("\n |             |   |");
            Console.Write("\n |     ( )     |()/ \t\t  GOOD LUCK");
            Console.Write("\n |             | / ");
            Console.Write("\n +_____________+/ ");


        string name;
            Console.ResetColor();
            Console.Write("\n\n\t Enter your name: ");
            name = Console.ReadLine();

            for (int tries = 16; tries > 0; tries--)
            {

                Console.Write($"\n\t {tries} attempts left ");

                int guess;
                Console.Write("\n\t Type your guess: ");
               guess = int.Parse(Console.ReadLine());


                if (guess == 10)
                {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t    - ****** -\n");
                Console.WriteLine("\t\t  --  ******  --\n");
                Console.WriteLine("\t\t     - **** -\n");
                Console.WriteLine("\t\t        **  \n");
                Console.WriteLine("\t\t        **  \n");
                Console.WriteLine("\t\t      ******\n");
                Console.ResetColor();
                Console.WriteLine($"\n\t\t Congratulations {name}, you got it right!!");

                    break;
                }

                else
                {
                         Console.WriteLine($"\n\t You missed {name}, try again!!");
                        if (11 <= tries && tries <= 13)
                        {
                            Console.WriteLine("\n\t Hint 1: try a number between 1 and 1000 ");
                        }
                        else if (6 <= tries && tries <= 8)
                        {
                            Console.WriteLine("\n\t Hint 2: try a number between 1 and 100");
                        }
                        else if (tries <= 3 )
                        {
                            Console.WriteLine("\n\t Hint 3: try a number between 1 and 10 ");
                        }
                        else if ( tries == 0)
                        {
                            Console.WriteLine("\n\t Your attempts are over ");
                        }

                    
             
                }
            }
        }
    }

