using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachUI
{
    public class Coach
    {
        
            public const int maxSize = 52;
            private Person[] contents;
            private int nextFreeLocation = 0;

            public Coach()
            {
                contents = new Person[maxSize];
            }

            // GetNumOfPassengers returns the current number of items in the structure
            public int GetNumOfPassengers()
            {
                return nextFreeLocation;
            }


            // addPerson adds an existing Person to the collection, if there is space
            // returns -1 if insufficient space, 0 otherwise
            public int AddPerson(Person thePerson)
            {
                if (nextFreeLocation < contents.Length)
                {
                    contents[nextFreeLocation] = thePerson;
                    nextFreeLocation++;
                    return nextFreeLocation - 1; // pass back insertion location
                }
                return -1; // if full, return error code
            }

            public int GetSeatByName(String theName)   // just added this one 
            {
                // pass back –1 if name is not found in the array 
                for (int position = 0; position < nextFreeLocation; position++)
                {
                    if (contents[position].GetName() == theName)
                    {
                        return position;
                    }
                }
                return -1;   /// if we got here then we didn’t find the name 

            }

            public bool RemovePersonByName(String theName)
            {
                // first find out whener the Person is
                int location = GetSeatByName(theName);
                if (location < 0)
                {
                    // name was not found, so cannot be removed
                    return false;
                }
                else
                {
                    // now we move the Person in the end position (which is NextFreeLocation -1)
                    // to that of the Person to be removed, thereby replacing
                    // first move nextFreeLocation back a position
                    nextFreeLocation--;
                    contents[location] = contents[nextFreeLocation];
                    // I now rest the seat at the end location
                    contents[nextFreeLocation] = null; // not really necessary but tidy
                    return true;
                }
            }

            //redefine the ToString which defines how Person will be displayed
            public override String ToString()
            {
                String tempString = "People on Bus: ";
                for (int i = 0; i < nextFreeLocation; i++)
                {
                    tempString = tempString + contents[i].ToString() + Environment.NewLine;
                }

                return tempString;
            }
        
    }
}

