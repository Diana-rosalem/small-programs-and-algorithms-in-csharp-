using System;


    class Program { 

        public static void Menu()
        {
            Console.WriteLine("\n===================== MENU =====================");
            Console.WriteLine("--> Select an option to use the Linked List program ");
            Console.WriteLine("Enter 1 to Linked List ");
            Console.WriteLine("Enter 2 to Circular List (Not Implemented)");
            Console.WriteLine("Enter 3 to Dual List (Not Implemented)");
            Console.WriteLine("Enter 4 for exit");
            Console.WriteLine("===================================================\n");
            Console.Write("Enter your choice:");
        }
        
        public static void menuList()
        {
            Console.WriteLine("\n===================== MENU =====================");
            Console.WriteLine("--> Select an option  ");
            Console.WriteLine("Enter 1 to AddFirst ");
            Console.WriteLine("Enter 2 to AddOrdered ");
            Console.WriteLine("Enter 3 to AddLast");
            Console.WriteLine("Enter 4 to Remove ");
            Console.WriteLine("Enter 5 for Print");
            Console.WriteLine("Enter 6 for Count");
            Console.WriteLine("Enter 7 for back to start menu");
            Console.WriteLine("===================================================\n");
            Console.Write("Enter your choice:");
        }

    
        static void Main(string[] args)
        {
        int op;
        int listOPCL;
        int listOPLL;
        int listOPDL;
        int ValueLL;
        int ValueCL;
        int ValueDL;



        do
        {

            Menu();
            op = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (op)
            {
                case 1:
                    LinkedList ll = new LinkedList();

                    do
                    {
                        
                        menuList();
                        listOPLL = int.Parse(Console.ReadLine());
                        Console.Clear();

                        ValueLL = 0;
                        switch (listOPLL)
                        {
                            case 1:
                                Console.Clear();
                                Console.Write("Enter the value you wish to add (only int numbers): ");
                                ValueLL = int.Parse(Console.ReadLine());
                                ll.AddFirst(ValueLL);
                                break;
                            case 2:
                                Console.Clear();
                                Console.Write("Enter the value you wish to add (only int numbers): ");
                                ValueLL = int.Parse(Console.ReadLine());
                                ll.AddOrdered(ValueLL);
                                
                                break;
                            case 3:
                                Console.Clear();
                                Console.Write("Enter the value you wish to add (only int numbers): ");
                                ValueLL = int.Parse(Console.ReadLine());
                                ll.AddLast(ValueLL);
                                
                                break;
                            case 4:
                                Console.Clear();
                                Console.Write("Enter the value you wish to remove: ");
                                ValueLL = int.Parse(Console.ReadLine());
                                ll.Remove(ValueLL);
                                ValueLL = 0;
                                break;
                           
                            case 5:
                                Console.Clear();
                                ll.Print();
                                break;
                            case 6:
                                Console.Clear();
                                Console.WriteLine($"there are {ll.Count()} elements in your list");
                                break;
                        }
                    } while (listOPLL != 7);
                  break;

                case 2:
                    CircularList Cl = new CircularList();
                    do
                    {

                        menuList();
                        listOPCL = int.Parse(Console.ReadLine());
                        Console.Clear();

                        ValueLL = 0;
                        switch (listOPCL)
                        {
                            case 1:
                                Console.Clear();
                                Console.Write("Enter the value you wish to add (only int numbers): ");
                                ValueCL = int.Parse(Console.ReadLine());
                                Cl.AddFirst();
                                break;
                            case 2:
                                Console.Clear();
                                Console.Write("Enter the value you wish to add (only int numbers): ");
                                ValueCL = int.Parse(Console.ReadLine());
                                Cl.AddOrdered(ValueCL);

                                break;
                            case 3:
                                Console.Clear();
                                Console.Write("Enter the value you wish to add (only int numbers): ");
                                ValueCL = int.Parse(Console.ReadLine());
                                Cl.AddLast(ValueCL);

                                break;
                            case 4:
                                Console.Clear();
                                Console.Write("Enter the value you wish to remove: ");
                                ValueCL = int.Parse(Console.ReadLine());
                                Cl.Remove(ValueCL);
                               
                                break;

                            case 5:
                                Console.Clear();
                                Cl.Print();
                                break;
                            case 6:
                                Console.Clear();
                                Console.WriteLine($"there are {Cl.Count()} elements in your list");
                                break;
                        }
                    } while (listOPCL != 7);
                    break;

                case 3:
                    DualList Dl = new DualList();
                    do
                    {

                        menuList();
                        listOPDL = int.Parse(Console.ReadLine());
                        Console.Clear();

                        ValueDL = 0;
                        switch (listOPDL)
                        {
                            case 1:
                                Console.Clear();
                                Console.Write("Enter the value you wish to add (only int numbers): ");
                                ValueDL = int.Parse(Console.ReadLine());
                                Dl.AddFirst();
                                break;
                            case 2:
                                Console.Clear();
                                Console.Write("Enter the value you wish to add (only int numbers): ");
                                ValueDL = int.Parse(Console.ReadLine());
                                Dl.AddOrdered(ValueDL);

                                break;
                            case 3:
                                Console.Clear();
                                Console.Write("Enter the value you wish to add (only int numbers): ");
                                ValueDL = int.Parse(Console.ReadLine());
                                Dl.AddLast(ValueDL);

                                break;
                            case 4:
                                Console.Clear();
                                Console.Write("Enter the value you wish to remove: ");
                                ValueDL = int.Parse(Console.ReadLine());
                                Dl.Remove(ValueDL);

                                break;

                            case 5:
                                Console.Clear();
                                Dl.Print();
                                break;
                            case 6:
                                Console.Clear();
                                Console.WriteLine($"there are {Dl.Count()} elements in your list");
                                break;
                        }
                    } while (listOPDL != 7);
                    break;



            }

        } while (op != 4);

        }
    }
    
