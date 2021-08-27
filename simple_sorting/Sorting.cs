using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;



namespace simple_sorting
{
    class Sorting
    {
        public void Bubblesort(int[] vet)
        {
            bool change = false;
            for (int j = 0; j < vet.Length; j++)
            {
                change = false;
                for (int i = 0; i < vet.Length - 1 - j; i++)
                {
                    if (vet[i] > vet[i + 1])
                    {
                        int ass = vet[i];
                        vet[i] = vet[i + 1];
                        vet[i + 1] = ass;
                        change = true;
                    }
                }
                if (!change)
                    return;
            }
        }
        public void Insertionsort(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                int ass = vet[i];
                int index = i;
                while (index > 0 && ass < vet[index - 1])
                {
                    vet[index] = vet[index - 1];
                    index--;
                }
                vet[index] = ass;
            }

        }
        public void Selectionsort(int[] vet)
        {
            for (int j = 0; j < vet.Length; j++)
            {
                int lowerIndex = j;
                for (int i = j + 1; i < vet.Length; i++)
                {
                    if (vet[i] < vet[lowerIndex])
                    {
                        lowerIndex = i;
                    }
                }
                int ass = vet[j];
                vet[j] = vet[lowerIndex];
                vet[lowerIndex] = ass;
            }

        }
    }

}

