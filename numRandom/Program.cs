using System;



    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n === Solver's game: there is a secret number, try to guess it. Be careful, you only have 16 chances!!! ===");
            string name;
            Console.Write("\n\t Enter your name: ");
            name = Console.ReadLine();

            for (int tries = 16; tries > 0; tries--)
            {

                Console.Write($"\n\t {tries} attempts left ");

                int guess;
                Console.Write("\n\t Type your guess: ");
               guess = int.Parse(Console.ReadLine());


                if (guess == 10)
                {
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
                    else if (tries <= 3)
                    {
                        Console.WriteLine("\n\t Hint 3: try a number between 1 and 10 ");
                    }
                    else if (tries == 0)
                    {
                        Console.WriteLine("\n\t Your attempts are over ");
                    }

                }
            }
        }
    }

