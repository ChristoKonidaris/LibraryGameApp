using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19013888_PROG7312_Task1
{
    class SortClass
    { 

        public void bubblesort(int[] array) //bubble sort to sort list of call numbers 
        {
            int len = array.Length;

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    int a = array[j];
                    if (a != array[len - 1])
                    {
                        int b = array[j + 1];
                        if (a > b)
                        {
                            array[j] = b;
                            array[j + 1] = a;
                        }
                    }
                }
            }
        }
    }
}
