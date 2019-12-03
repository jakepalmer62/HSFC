using System;
using System.Collections.Generic;
using System.Text;

namespace WordCounter
{
    class WordCounterPair
    {
        private int Counter;
        private string Word;

        public void SetWord(string theWord)
        {
            Word = theWord;
        }
        public void SetCounter(int theCounter)
        {
            Counter = theCounter;
        }
        public string GetWord()
        {
            return Word;
        }
        public int GetCount()
        {
            return Counter;
        }
        public int CompareTo(string theWord)
        {
            return Word.CompareTo(theWord);
        }
    }
}
