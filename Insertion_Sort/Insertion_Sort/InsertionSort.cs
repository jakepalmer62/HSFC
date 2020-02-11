using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class InsertionSort
    {
        public void InsertSort(ref int[] theList)
        {
            int nextItem, i;

            for (int j = 1; j < theList.Length; j++)
            {
                nextItem = theList[j];
                i = j - 1;
                while ((i >= 0) && theList[i] > nextItem)
                {
                    theList[i + 1] = theList[i];
                    i = i - 1;
                }
                theList[i + 1] = nextItem; // this inserts 
            }
        }

        public void DisplayList(int[] aList)
        {
            Console.WriteLine("This is the insertionsort list");
            Console.Write("Output of list: ");
            for (int i = 0; i <= aList.Length - 1; i++)
            {
                Console.Write(aList[i] + ", ");
            }
            Console.WriteLine();

        }
    }
}
