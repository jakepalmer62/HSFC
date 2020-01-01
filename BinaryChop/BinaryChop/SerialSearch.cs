﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryChop
{
    class SerialSearch
    {
        public int Serialsearch(String[] theList, String itemToSearchFor)

        {
            // check if the array is empty, if so return an error 
            if (theList.Length == 0)
            {
                return -1;  // we'll use this as an error code 
            }
            // Use a for loop, initialise counter = 0 (first position/index in array)   
            // set the number of iterations the same as the last position/index of the array  
            // (so to that each location in the array can be checked) 
            int counter;    // counter defined outside loop, so I can use it later 
            for (counter = 0; counter < theList.Length; counter++)
            {
                // check if item (at current position) is equal to item searched 
                // if item found return the position/index (the value of the counter) 
                if (itemToSearchFor == theList[counter])
                {
                    return counter;
                }
            }
            // If we get here, them item is still not found, return -1 
            return -1;
        }
    }
}
