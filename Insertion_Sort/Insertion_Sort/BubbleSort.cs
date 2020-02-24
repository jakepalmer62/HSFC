using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class BubbleSort
    {
        public void MyBubbleSort(ref int[] theList)
        {
            bool swapMade = true;
            int temp = 0;
            while (swapMade == true)
            {
                swapMade = false;
                for (int position = 0; position <= theList.Length - 2; position++)
                {
                    if (theList[position] > theList[position + 1])
                    {
                        temp = theList[position];
                        theList[position] = theList[position + 1];
                        theList[position + 1] = temp;
                        swapMade = true;
                    }
                }
            }
        }
        public void Display(int[] aList)
        {
            Console.WriteLine("This is the bubblesort list");
            Console.Write("Output of list: ");
            for (int i = 0; i <= aList.Length - 1; i++)
            {
                Console.Write(aList[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
