using System;

namespace simple_sortin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializar vetor
            int[] vector1 = new int[100];
            Random rand = new Random();
            for (int i = 0; i < vector1.Length; i++)
            {
                vector1[i] = rand.Next(0, 100);
            }

            //Sorting
            Sorting sorting = new Sorting();
            sorting.Bubblesort(vector1);

            //View
            foreach (var item in vector1)
            {
                Console.Write($"{item} - ");
            }
        }

    }
}
