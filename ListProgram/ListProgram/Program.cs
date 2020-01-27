using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            WordCounterPair dictionary = new WordCounterPair();
            Searches mySearches = new Searches();
            String[] List;
            int maxSize = 5;
            List = new String[maxSize];
            String CurrentWord = " ";

            Console.WriteLine("Please enter your words ending with STOP.");
            Console.ReadLine();

            while (CurrentWord != "STOP")
            {
                dictionary.AddString(Console.ReadLine());
            }
                    
            if (CurrentWord == "STOP")
            {
                dictionary.AddString(CurrentWord);
            }

            Console.WriteLine("Serial Search (S) or Binary Search (B)");
            Console.WriteLine("=========================================");

            switch (Console.ReadLine())
            {
            case "S":
                {
                    
                    break;
                }

            case "B":
                {
                    Console.WriteLine();
                    break;
                }
            }
                
        }

    }

}
