using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words one per line and end with STOP");
            WordCounter dictionary = new WordCounter(100);
            string currentWord = "";           
           
            while (currentWord != "STOP")
            {
                currentWord = Console.ReadLine();
                if (currentWord != "STOP")
                {
                    dictionary.AddString(currentWord);
                }
            }           
            Console.WriteLine(dictionary);
            Console.ReadLine();
        }    
    }
}
