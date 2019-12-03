using System;
using WordCounter;

namespace Word_Counter
{
    public class Program
    {
        static void Main(string[] args)
        {
            WordCounterPair dictionary = new WordCounterPair(100);
            string currentWord = "";

            // I should read in line of text
            // process line of text, looking for individual words
            // for each word for WordCounter AddString

            // start with just a word at a time :-)
            while (currentWord != "STOP")
            {
                currentWord = Console.ReadLine();
                if (currentWord != "STOP")
                {
                    dictionary.AddString(currentWord);

                }
            }

        }
    }
}
