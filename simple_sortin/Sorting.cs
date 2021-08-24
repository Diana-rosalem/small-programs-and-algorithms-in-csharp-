using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;



namespace simple_sortin
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
                        int aux = vet[i];
                        vet[i] = vet[i + 1];
                        vet[i + 1] = aux;
                        change = true;
                    }
                }
                if (!change)
                    return;
            }
        }
        public void Insertionsort(int[] vet)
        {

        }
        public void Selectionsort(int[] vet)
        {

        }
    }

    }
