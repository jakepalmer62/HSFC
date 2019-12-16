using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your words one per line and end with STOP");
            Console.WriteLine("Typing STOP will display your words counted in alphabetical order");
            Console.WriteLine("Typing close at the end will close the program");
            WordCounter dictionary = new WordCounter(100);
            string Sentance = "";                       
            Sentance = Console.ReadLine();
            while (Sentance != "STOP")
            {
                dictionary.AddString(Sentance);
            }
            if (Sentance == "STOP")
            {
                Console.WriteLine(dictionary);
                Console.WriteLine("Thankyou for using the program, Press Enter to Close.");
                Console.ReadKey();
            }                             
                
            

        }    
    }
}
