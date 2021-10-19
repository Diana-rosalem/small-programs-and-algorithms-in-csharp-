using System;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queues Priority = new Queues();
            Queues normal = new Queues();
            int countP = 1;
            int countN = 1;
            int op = -1;
            while (op != 0)
            {
                Console.WriteLine("\nWelcome to the queue, choose a password and wait ");
                Console.WriteLine("\n\n\t\t===== MENU =====");
                Console.WriteLine("\tType 0 to exit.");
                Console.WriteLine("\tType 1 to Priority Password.");
                Console.WriteLine("\tType 2 to Normal Password.");
                Console.WriteLine("\tType 3 call the next in line");
                Console.WriteLine("\tType your choice:");
              
                op = int.Parse(Console.ReadLine());

                Console.Clear();
                if (op == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Priority.Insert(new Person("P", countP));
                    Console.WriteLine($"Generated password: P{countP}");
                    countP++;
                    Console.ResetColor();
                }
                else if (op == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    normal.Insert(new Person("N", countN));
                    Console.WriteLine($"Generated password: N{countN}");
                    countN++;
                    Console.ResetColor();
                }
                else if (op == 3)
                {
                    Person prox;
                    if (!Priority.IsEmpty())
                    {
                        prox = Priority.Remove();
                    }
                    else
                    {
                        prox = normal.Remove();
                    }
                    if (prox != null)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Next:{prox.Name}{prox.Passw}");
                        Console.ResetColor();
                    }


                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Queue is empty");
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}

