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
            String[] theStrings = new String[100];            
            String theText = "";
            Search mySearching = new Search();
            int nextFreeLocation = 0;

            while ((line = reader.ReadLine()) != null)
            {
                theStrings[nextFreeLocation] = line;
                nextFreeLocation++;
            }

            for (int i = 0; i < nextFreeLocation; i++)
            {
                theText = theText + theStrings[i] + Environment.NewLine;
            }
            
            
        }
    }
}