using System;
using System.Collections.Generic;
using System.Text;

namespace WordCount
{
    public class Counter
    {
        public int Count(string theWord)
        {
            int Count = 0;
            int maWords = theWord.Length;
            theWord = theWord.Trim();

            if (theWord == "")
            {
                return 0;
            }
            while (theWord.Contains ("  "))
            {
                theWord = theWord.Replace("  ", " ");
            }
            foreach (theWord) 
            {
                theWord.Split();
                Count++;
            }
            if (theWord == "STOP")
            {
                return Count;
            }
            
        }
    }
}
