using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Timetable
{
    public class SerialSearch
    {
        public int linearSearch(String[] theDictionary, String itemToSearchFor)
        {

            if (theDictionary.Length == 0)
            {
                return -1;
            }
            int counter;    
            for (counter = 0; counter < theDictionary.Length; counter++)
            {
                // check if item (at current position) is equal to item searched 
                // if item found return the position/index (the value of the counter) 
                if (itemToSearchFor == theDictionary[counter])

                {
                    return counter;
                }
            }
            // If we get here, them item is still not found, return -1 
            return -1;

        }
    }
}
