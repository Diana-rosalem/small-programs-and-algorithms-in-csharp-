using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShip
{
    class BattleshipBoard
    {


        public void DisplayBoard(char[,] Board)
        {
            int Row;
            int Column;

            Console.WriteLine("  ¦ 0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("--+---------------------");
            for (Row = 0; Row <= 9; Row++)
            {
                Console.Write((Row).ToString() + " ¦ ");
                for (Column = 0; Column <= 9; Column++)
                {
                    Console.Write(Board[Column, Row] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");
        }
    }

    class Player
    {
        char[,] Grid = new char[10, 10];
        public int HitCount = 0;
        public int MissCount = 0;
        public int Count = 40;
        int x = 0;
        int y = 0;

        public int getHitCount()
        {
            return HitCount;
        }
        public int getMissCount()
        {
            return MissCount;
        }
        public void AskCoordinates()
        {

           
            {
                Console.WriteLine($"There are only {Count} moves left");
                Console.WriteLine("Enter X");
                string line = Console.ReadLine();
                int value;
                if (int.TryParse(line, out value))
                {
                    x = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not an integer!");
                    Console.ResetColor();
                }

                Console.WriteLine("Enter Y");
                line = Console.ReadLine();
                if (int.TryParse(line, out value))
                {
                    y = value;
                    Count--;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not an integer!");
                    Console.ResetColor();
                }

                try
                {
                    if (Grid[x, y].Equals(' '))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Grid[x, y] = 'H';
                        Console.Clear();
                        Console.WriteLine("\t\tHit!\r\n");
                        HitCount += 1;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Grid[x, y] = 'M';
                        Console.Clear();
                        Console.WriteLine("\t\tMiss!\r\n");
                        MissCount += 1;
                        Console.ResetColor();
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Error: Please enter numbers between 0 and 9. (Inclusive)");
                    Console.ResetColor();
                }
            }
            
        }
            public char[,] GetGrid()
            {
                return Grid;
            }
            public void SetGrid(int q, int w)
            {
                Grid[q, w] = ' ';
            }
            public void Randomize()
            {

                Random r = new Random(2);
                //1 of Patrol Boat (length 2)
                SetGrid(1, 2);
                SetGrid(2, 2);
                //2 of Destroyer (length 3)
                SetGrid(4, 3);
                SetGrid(4, 4);
                SetGrid(4, 5);

                SetGrid(5, 0);
                SetGrid(6, 0);
                SetGrid(7, 0);
                //1 Battleship(length 4)
                SetGrid(0, 8);
                SetGrid(1, 8);
                SetGrid(2, 8);
                SetGrid(3, 8);
                //1 Carrier(length 5)
                SetGrid(7, 4);
                SetGrid(7, 5);
                SetGrid(7, 6);
                SetGrid(7, 7);
                SetGrid(7, 8);
            }

        }
    

    class Program
    {


        static void Main(string[] args)
        {

            Console.Title = "Battleship!";

            int op = 0;
            while (op != 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\t              __\n");
                Console.Write("\t             -__-\n");
                Console.Write("\t       __     --     __             BATTLESHIP\n");
                Console.Write("\t         ------------\n");
                Console.Write("\t              --            Welcome to the Battle Ship!!\n");
                Console.Write("\t              --            Type 1 to Play\n ");
                Console.Write("\t      =       --       =    Type 2 to see the rules\n");
                Console.Write("\t       ==     --     ==     type 3 to exit the game \n");
                Console.Write("\t         ==   --   ==       Type your choice:\n");
                Console.Write("\t           ===--===\n");
                Console.Write("\t              ==\n");
                Console.Write("\t");
                op = Convert.ToInt32(Console.ReadLine());
                Console.ResetColor();

                switch (op)
                {

                    case 1:
                        Console.WriteLine("What is your name?");
                        string name = System.Console.ReadLine();
                        Console.WriteLine();
                        BattleshipBoard b = new BattleshipBoard();
                        Player p = new Player();
                        p.Randomize();
                        while (p.getHitCount() < 17 && p.Count > 0 )
                        {
                         
                            b.DisplayBoard(p.GetGrid());
                            p.AskCoordinates();
                        }
                        if (p.Count == 0)
                        {
                            Console.WriteLine("GAME OVER - You have exhausted the number of moves");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\t\t    - ****** -\n");
                            Console.WriteLine("\t\t  --  ******  --\n");
                            Console.WriteLine("\t\t     - **** -\n");
                            Console.WriteLine("\t\t        **  \n");
                            Console.WriteLine("\t\t        **  \n");
                            Console.WriteLine("\t\t      ******\n");
                            Console.ResetColor();
                            Console.WriteLine("Congratulations, " + name + "! You Win!\r\n");
                            Console.WriteLine("You missed: " + p.getMissCount() + " times\r\n");
                            Console.WriteLine("Thanks for playing BerdShip. Press enter back to menu.");
                            System.Console.ReadLine();
                        }
                            break;
                        

                    case 2:
                        Console.WriteLine("\n  BattleShip is an adaptation of the classic game, which involves guessing and strategy.");
                        Console.WriteLine("  It is played on 9x9 grids ruled by a fleet of ships, hidden.");
                        Console.WriteLine("  The player's objective is to find and sink the opponent's ships until the entire fleet is eliminated.\n");
                        Console.WriteLine("  To play, just type the location you want to shoot (row x column).\n");
                        Console.WriteLine("\t- Only numbers from 0 to 9 are valid.\n");
                        Console.WriteLine("\t- The fleet consists of: \n\t\t* 1 of Patrol boat(length 2),\n\t\t * 2 of Destroyer (length 3),\n\t\t * 1 Battleship(length 4),\n\t\t * 1 Carrier(length 5)\n");
                        Console.WriteLine("\t- The player has only 40 moves to defeat the entire fleet.\n");
                        Console.WriteLine("\t\tI hope you have fun playing");
                        Console.WriteLine("\nPress enter back to menu.");
                        System.Console.ReadLine();
                        break;
                }
            }

            
    }
      
    }
}