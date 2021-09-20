using System;

namespace Stack
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("\n===================== MENU =====================");
            Console.WriteLine("--> Select an option  ");
            Console.WriteLine("Enter 1 to Push ");
            Console.WriteLine("Enter 2 to Pop");
            Console.WriteLine("Enter 3 to check if it is empty");
            Console.WriteLine("Enter 4 to Clear ");
            Console.WriteLine("Enter 5 to Peek");
            Console.WriteLine("Enter 6 to print");
            Console.WriteLine("Enter 7 exit");
            Console.WriteLine("===================================================\n");
            Console.Write("Enter your choice:");
        }
        
        static void Main(string[] args)
        {
            int op;
            char value;
            Stack stack = new Stack();
            


            do
            {
                Menu();
                op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Enter the value you wish to push: ");
                        value = Console.ReadKey().KeyChar;
                        stack.Push(value);
                        Console.Write("\nadd successfully,press enter to continue");
                        Console.ReadLine();
                        break;

                    case 2:
                        
                        stack.Pop();
                        Console.Write("\nsuccessfully,press enter to continue");
                        Console.ReadLine();
                        break;
                    case 3:
                        ;
                        if(stack.IsEmpty() == true)
                        {
                            Console.Write("\nThe stack is empty");
                        }
                        else
                        {
                            Console.Write("\nThe stack isnt empty");
                        }
                        Console.Write("\nPress enter to continue");
                        Console.ReadLine();
                        break;
                    case 4:
                        stack.Clear();
                        Console.Write("\n Clear successfully,press enter to continue");
                        Console.ReadLine();
                        break;
                    case 5:
                        stack.Peek();
                        Console.Write("\nPress enter to continue");
                        Console.ReadLine();
                        break;
                    case 6:
                        stack.Print();
                        Console.Write("\nPress enter to continue");
                        Console.ReadLine();
                        break;
                    
                        
                }

            } while (op != 7);

        }
       
        
    }
}
