using System;
using System.Diagnostics;

namespace simple_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 100;
            //Inicializar vetor
            int[] vector1 = new int[size];
            Random rand = new Random();
            for (int i = 0; i < vector1.Length; i++)
            {
                vector1[i] = rand.Next(0, size);
            }

            int[] vector2 = new int[size];
            vector1.CopyTo(vector2, 0);
            int[] vector3 = new int[size];
            vector1.CopyTo(vector3, 0);
            int[] vector4 = new int[size];
            vector1.CopyTo(vector4, 0);

            Sorting sorting = new Sorting();


            int op = 0;
            while (op != 6)
            {
                Console.WriteLine("\n\n\t\t===== MENU =====");
                Console.WriteLine("\tType 1 to sort the vector using Bubblesort,Insertionsort and Selectionsort methods.");
                Console.WriteLine("\tType 2 to sort the vector using only the Bubblesort method.");
                Console.WriteLine("\tType 3 to sort the vector using only the Insertionsort method.");
                Console.WriteLine("\tType 4 to sort the vector using only the Selectionsort method.");
                Console.WriteLine("\tType 5 to calculate the sorting time of the methods.");
                Console.WriteLine("\tType 6 to exit the program.");
                Console.WriteLine("\tType your choice:");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        //Sorting Bubblesort

                        sorting.Bubblesort(vector1);

                        //View
                        Console.WriteLine("\n\tBubblesot:");
                        foreach (var item in vector1)
                        {
                            Console.Write($"{item} - ");
                        }

                        //Sorting Insertionsort
                        sorting.Insertionsort(vector2);

                        //View
                        Console.WriteLine("\n\tInsertionsort:");
                        foreach (var item in vector2)
                        {
                            Console.Write($"{item} - ");
                        }

                        //Sorting Selectionsort
                        sorting.Selectionsort(vector3);

                        //View
                        Console.WriteLine("\n\tSelectionsort:");
                        foreach (var item in vector3)
                        {
                            Console.Write($"{item} - ");
                        }

                        break;

                    case 2:
                        //Sorting Bubblesort

                        sorting.Bubblesort(vector1);

                        //View
                        Console.WriteLine("\n\tBubblesot:");
                        foreach (var item in vector1)
                        {
                            Console.Write($"{item} - ");
                        }
                        break;

                    case 3:
                        //Sorting Insertionsort
                        sorting.Insertionsort(vector2);

                        //View
                        Console.WriteLine("\n\tInsertionsort:");
                        foreach (var item in vector2)
                        {
                            Console.Write($"{item} - ");
                        }
                        break;

                    case 4:
                        //Sorting Selectionsort
                        sorting.Selectionsort(vector3);

                        //View
                        Console.WriteLine("\n\tSelectionsort:");
                        foreach (var item in vector3)
                        {
                            Console.Write($"{item} - ");
                        }
                        break;

                    case 5:
                        Stopwatch sw = new Stopwatch();

                        sw.Start();
                        sorting.Bubblesort(vector1);
                        sw.Stop();
                        Console.WriteLine($"Bubble: {sw.Elapsed.ToString()}");
                        sw.Start();
                        sorting.Insertionsort(vector2);
                        sw.Stop();
                        Console.WriteLine($"Insertion: {sw.Elapsed.ToString()}");
                        sw.Start();
                        sorting.Selectionsort(vector3);
                        sw.Stop();
                        Console.WriteLine($"Selection: {sw.Elapsed.ToString()}");
                        break;
                }
            }

        }

    }
}

