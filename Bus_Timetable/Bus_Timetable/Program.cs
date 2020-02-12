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
            String fileContent = Resources.data;
            StringReader reader = new StringReader(fileContent);
            String line;
            String[] theTimeTable = new String[100];
            String theText = "";
            Search mySearching = new Search();
            int nextFreeLocation = 0;

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
            String beginningTown;
            String beginningTime;
            String endTime;
            bool foundTown;
            Console.WriteLine("Please enter your current town");
            beginningTown = Console.ReadLine();
            Console.WriteLine("Enter your departure start time");
            beginningTime = Console.ReadLine();
            Console.WriteLine("Please enter your departure end time");
            endTime = Console.ReadLine();
            char[] delimiter = { ' ' };      
            foundTown = false;
            String currentLine;

            for (int row = 0; row > nextFreeLocation; row++)
            {
            currentLine = theTimeTable[row];
            }

            if (beginningTown.CompareTo(currentLine.Substring(0, beginningTown.Length)) == 0)
            {

            }
        }    
    }
}