using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Timetable
{
    public class Search
    {
        public String BusSearch(String[] theDictionary, String itemToSearchFor)
        {
            // Let's start with our user input
            String startTown;
            String startTime;
            String endTime;
            Console.WriteLine("Please enter your current town");
            startTown = Console.ReadLine();
            Console.WriteLine("Please enter your preferred departure window start");
            startTime = Console.ReadLine();
            Console.WriteLine("Please enter your preferred departure window end");
            endTime = Console.ReadLine();

            char[] delimiter = { ' ' }; // we use space as a delimiter for split below
            String[] tokens;          // holds individual words (tokens) in a string
            String currentLine;
            bool foundATown = false;
            // Now let's process the timetable, one line at a time
            for (int row = 0; row < nextFreeLocation; row++)
            {
                currentLine = theTimeTable[row];
                // First we search the timetable for the town to search for
                // Console.WriteLine("Processing: " + currentLine);
                if (startTown.CompareTo(currentLine.Substring(0, startTown.Length)) == 0)
                {
                    // Console.WriteLine("Found an entry...... ");

                    // we have the town we are looking for, so let's process the line

                    tokens = currentLine.Split(delimiter);
                    // Note than tokens[0] is start town, tokens[1] is end town
                    for (int timeToken = 2; timeToken < tokens.Length; timeToken++)
                    {
                        // test to see if a time is within range
                        if ((tokens[timeToken].CompareTo(startTime) > 0) &
                            (tokens[timeToken].CompareTo(endTime) < 0))
                        {
                            Console.Write(tokens[timeToken] + " ");
                            Console.WriteLine(tokens[1]);



                            foundATown = true;  // record that we are on a new town
                        }
                    }

                }
            }
            if (!foundATown)
                Console.WriteLine("Sorry no buses were found that met your requirements");
            Console.ReadLine();
        }
    }
    }
}
