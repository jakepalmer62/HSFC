using System;
using System.Collections.Generic;
using System.Text;

namespace WordCounter
{
    class WordCountPair
    {
        private String word;
        private int count;

        //creates a word count pair
        public WordCountPair(string theWord, int theCount)
        {
            word = theWord;
            count = theCount;
        }
        public void SetWord(String theWord)
        {
            word = theWord;

        }
        public void SetCount(int theCount)
        {
            count = theCount;
        }
        public String GetWord()
        {
            return word;
        }
        public int GetCount()
        {
            return count;
        }

        public override string ToString()
        {
            return word + "  " + count;
        }
        public int CompareTo(String theWord)
        {
            return word.CompareTo(theWord);
        }

    }
}
