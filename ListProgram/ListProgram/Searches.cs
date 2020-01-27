using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProgram
{
    class Searches
    {
        public int binaryChop(String[] theList, String SearchItem)
        {
            int min = 0;
            int max = theList.Length - 1;
            int mid;

            while (min <= max)
            {
                mid = (min + max) / 2;
                if (SearchItem == theList[mid])
                {
                    return mid;
                }
                else if (SearchItem.CompareTo(theList[mid]) < 0)   //Item Found
                {
                    max = mid - 1;
                }

                else
                {
                    min = mid + 1;
                }
            }
            return -1;   //Error Code
        }
        public int Serialsearch(String[] theList, String SearchItem)

        {
            if (theList.Length == 0)
            {
                return -1;  //Error Code
            }

            int counter;
            for (counter = 0; counter < theList.Length; counter++)
            {
                if (SearchItem == theList[counter])
                {
                    return counter;
                }
            }
            //Item not found, returns error code
            return -1;
        }

        public int LinearSearch(String[] theList, String SearchItem)
        {

        }

        public int
    }
}
