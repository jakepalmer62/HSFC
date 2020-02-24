using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bus_Timetable.Properties;
using System.IO;


namespace Bus_Timetable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            String fileContent = Resources.data;
            StringReader reader = new StringReader(fileContent);
            String line;
            String[] theTimeTable = new String[100];
            String theText = "";
            int nextFreeLocation = 0;
            String beginningTown;
            String beginningTime;
            String endTime;
            bool townFound;
            Console.WriteLine(fileContent);
       
            // loop to display timetable items
            while ((line = reader.ReadLine()) != null)
            {
                theTimeTable[nextFreeLocation] = line;
                nextFreeLocation++;
            }

            for (int i = 0; i < nextFreeLocation; i++)
            {
                theText = theText + theTimeTable[i] + Environment.NewLine;
            }

            // User input:                                   
            Console.WriteLine("Please enter your current town");
            beginningTown = Console.ReadLine();
            Console.WriteLine("Enter your departure start time");
            beginningTime = Console.ReadLine();
            Console.WriteLine("Please enter your departure end time");
            endTime = Console.ReadLine();
            char[] delimiter = { ' ' };
            String[] SearchToken;
            townFound = false;
            String currentLine = " ";
            
            // Loops for comparing timetable elements
            for (int row = 0; row > nextFreeLocation; row++) 
            {
                currentLine = theTimeTable[row];

            if (beginningTown.CompareTo(currentLine.Substring(0, beginningTown.Length)) == 0)
            {
                SearchToken = currentLine.Split(delimiter);

                for (int timeToken = 2; timeToken < SearchToken.Length; timeToken++)
                {
                    // test to see if a time is within range
                    if ((SearchToken[timeToken].CompareTo(beginningTime) > 0) &
                        (SearchToken[timeToken].CompareTo(endTime) < 0))
                    {
                        Console.WriteLine(SearchToken[timeToken] + " ");
                        Console.WriteLine(SearchToken[1]);
                        townFound = true;  // record that we are on a new town

                    }
                }
                if (!townFound)
                {
                    Console.WriteLine("Sorry, no buses found that met your time/destination");
                }
                Console.ReadLine();
            }              

            }
        }    
    }
}