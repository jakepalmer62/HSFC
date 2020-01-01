using System;
using System.Collections.Generic;
using System.Text;

namespace WordCounter
{
    class WordCountPair
    {
        private String Sentance;
        private int count;

        //creates word count pair
        public WordCountPair(string theWord, int theCount)
        {
            Sentance = theWord;
            count = theCount;
        }
        public void SetSentance(String theSentance)
        {
            Sentance = theSentance;

        }
        public void SetCount(int theCount)
        {
            count = theCount;
        }
        public String GetSentance()
        {
            return Sentance;
        }
        public int GetCount()
        {
            return count;
        }

        public override string ToString()
        {
            return Sentance + "  " + count;
        }
        public int CompareTo(String theWord)
        {
            return Sentance.CompareTo(theWord);
        }

    }
}
