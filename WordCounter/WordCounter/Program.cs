using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your words one per line and end with STOP");
            Console.WriteLine("Typing STOP will display your words counted and in alphabetical order");
            WordCounter dictionary = new WordCounter(100);
            string Word = "";           
           
            while (Word != "STOP")
            {
                Word = Console.ReadLine();
                if (Word != "STOP")
                {
                    dictionary.AddString(Word);
                }
                if (Word != "CLOSE")
                {
                    
                }
            }           
            Console.WriteLine(dictionary);
            Console.ReadLine();

        }    
    }
}
