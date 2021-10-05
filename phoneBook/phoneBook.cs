using System;
using System.Collections.Generic;
using System.Text;


    class phoneBook
    {
    string name;
    int number;
    private Dictionary<string, int> pBook = new Dictionary<string, int>();

        
        public void addPhoneNumber()
        {
        
                Console.Write("Enter the name:");
                name = Console.ReadLine();
                Console.Write("Enter the phone number: ");
                number = int.Parse(Console.ReadLine());


                pBook.Add(name, number);
                Console.WriteLine("\nsuccessfully added, press enter to continue");
                Console.ReadLine();


                name = "";
                number = 0;
      
        }

        public void search()
        {
            string searchName;
            Console.Write("Enter the name:");
            searchName = Console.ReadLine();

            int searchNumber;
                if (pBook.TryGetValue(searchName, out searchNumber))
                {
                    Console.WriteLine($"{searchName}:{searchNumber}");
                    Console.WriteLine("\npress enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Could not find the number for the specified name, press enter ");
                    Console.ReadLine();
                }
        }
        public void allBook()
        {
            int count;
            count = pBook.Count;
            Console.WriteLine($"\nThere are {count} registered numbers.");

            foreach(KeyValuePair<string, int> item in pBook)
            {
                Console.WriteLine("\nName: {0}, Number: {1}", item.Key, item.Value);
            }
            Console.WriteLine("\npress enter to continue");
            Console.ReadLine();

        }

        public void remove() 
        {
            string RemoveName;
            Console.Write("Enter the name:");
            RemoveName = Console.ReadLine();
            if(pBook.ContainsKey(RemoveName) == true)
            {
                pBook.Remove(RemoveName);
                Console.WriteLine("\nsuccessfully removed, press enter to continue");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Could not find the specified name");
                Console.WriteLine("\npress enter to continue");
                Console.ReadLine();
            }
        

        }
        
       

}

