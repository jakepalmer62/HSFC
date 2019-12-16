using System;
using WordCounter;

namespace Word_Counter
{
    public class Program
    {
        static void Main(string[] args)
        {
            WordCounterPair dictionary = new WordCount(100);
            string currentWord = "";


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
