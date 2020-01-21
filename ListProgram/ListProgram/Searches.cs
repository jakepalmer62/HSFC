using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProgram
{
    class Searches
    {
        public int binarySearch(String[] theList, String itemToSearchFor)
        {
            int min = 0;
            int max = theList.Length - 1;
            int mid;

            while (min <= max)
            {
                mid = (min + max) / 2;
                if (itemToSearchFor == theList[mid])
                {
                    return mid;
                }
                else if (itemToSearchFor.CompareTo(theList[mid]) < 0)   //Item Found
                {
                    max = mid - 1;
                }

                else
                {
                    min = mid + 1;
                }
            }
            return -1;   //error code, return -1 
        }
        public int Serialsearch(String[] theList, String itemToSearchFor)

        {
            if (theList.Length == 0)
            {
                return -1;  //error code, return -1
            }

            int counter;
            for (counter = 0; counter < theList.Length; counter++)
            {
                if (itemToSearchFor == theList[counter])
                {
                    return counter;
                }
            }
            //Item not found, returns error code
            return -1;
        }
    }
}
