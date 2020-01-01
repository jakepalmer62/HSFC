using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryChop
{
    class BinarySearch
    {
        public int binarySearch(String[] theList, String itemToSearchFor)
        {
            int min = 0;                   // the start of the array 
            int max = theList.Length - 1;  // the end of the array 
            int mid;

            while (min <= max)
            {
                mid = (min + max) / 2;
                if (itemToSearchFor == theList[mid])
                {
                    return mid;
                }
                else if (itemToSearchFor.CompareTo(theList[mid]) < 0)   // found the item 
                {
                    max = mid - 1;
                }

                else
                {
                    min = mid + 1;
                }
            }
            return -1;   // if we get here, we haven't found it, so return -1 
        }
    }
}
