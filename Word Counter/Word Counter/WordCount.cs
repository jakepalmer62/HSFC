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
        public WordCounterPair(int maxSize)
        {
            Collection = new WordCounterPair[maxSize];
        }

        // AddWord takes in a new word, adds it to the collection and returns current count for that word
        // Passes back -1 if it can't be added
        public int AddString(String newWord)
        {
            // check length of array, if full return -1
            // search through array
            // if newWord is found then simply add 1 to the existing count, return new count
            // if newWord is not found then add into collection maintaining order, return 1
            return 1;
        }

        public override string ToString()
        {
            String theString = "";
            //  go through array, and for each entry add Word,Count and newline to String
            return theString;
        }
    }
}
