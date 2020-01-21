using System;
using System.Collections.Generic;
using System.Text;
using WordCounter;

namespace WordCount
{
    class WordCounter
    {
        private WordCounterPair[] Collection;
        private int nextFreeLocation = 0;

        // constructor takes a parameter to specify how big the array should be
        public String WordCounterPair(int maxSize)
        {
            Collection = new WordCounterPair[maxSize];
        }

        public int AddString(String newWord)
        {

            return 1;
        }

        public override string ToString()
        {
            String theString = "";
            return theString;
        }
    }
}
