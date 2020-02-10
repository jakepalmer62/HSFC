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
            String[] theDictionary = new String[100];
            int nextFreeLocation = 0;
            String theText = "";
            SerialSearch mySearching = new SerialSearch();

            while ((line = reader.ReadLine()) != null)
            {
                theDictionary[nextFreeLocation] = line;
                nextFreeLocation++;
            }


            for (int i = 0; i < nextFreeLocation; i++)
            {
                theText = theText + theDictionary[i] + Environment.NewLine;
            }
            
            Console.WriteLine(theText);
            Console.WriteLine("What Bus are you looking for? Please enter it exactly as it is shown.");
            String itemToSearchFor = Console.ReadLine();

            int result = mySearching.serialSearch(theDictionary, itemToSearchFor);
            if (result == -1)
            {
                Console.WriteLine("Bus not found.");
            }

            else
            {
                Console.WriteLine("Bus found at position: ");
                Console.WriteLine(result.ToString());
            }
            Console.WriteLine("Thanks for using the bus timetable program, press any key to exit.");
            Console.ReadLine();

        }
    }
}
