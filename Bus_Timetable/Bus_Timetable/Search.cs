using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Timetable
{
    public class Search
    {
        public int linearSearch(String[] theDictionary, String itemToSearchFor)
        {
            int Counter;  

            if (theDictionary.Length == 0)
            {
                return -1;
            }
              
            for (Counter = 0; Counter < theDictionary.Length; Counter++)
            {
                // check if item (at current position) is equal to item searched 
                // if item found return the position/index (the value of the counter) 
                if (itemToSearchFor == theDictionary[Counter])

                {
                    return Counter;
                }
            }
            // If we get here, them item is still not found, return -1 
            return -1;



        }
    }
}
