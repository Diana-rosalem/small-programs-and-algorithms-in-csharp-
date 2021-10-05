using System;


class Program
{
    public static void Menu()
    {
        Console.WriteLine("\n===================== MENU =====================");
        Console.WriteLine("--> Select an option  ");
        Console.WriteLine("Enter 1 to add a new phone number");
        Console.WriteLine("Enter 2 to search the phone number");
        Console.WriteLine("Enter 3 to show the complete Phone Book");
        Console.WriteLine("Enter 4 to remove the phone number");
        Console.WriteLine("Enter 5 exit");
        Console.WriteLine("================================================\n");
        Console.Write("Enter your choice:");
    }
    static void Main(string[] args)
    {
        int op;
        phoneBook pb1 = new phoneBook();

        do
        {
            Console.Clear();
            Menu();
            op = int.Parse(Console.ReadLine());
            

            switch (op)
            {
                case 1:
                    Console.Clear();
                    pb1.addPhoneNumber();
                    break;
                case 2:
                    Console.Clear();
                    pb1.search();
                    break;
                case 3:
                    Console.Clear();
                    pb1.allBook();
                    break;
                case 4:
                    Console.Clear();
                    pb1.remove();
                    break;

            }
        } while (op != 5);


    }
}

