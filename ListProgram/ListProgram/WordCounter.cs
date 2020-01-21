using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProgram
{
    class WordCounter
    {
        private int Counter;
        private string Word;

        public void setWord(string theWord)
        {
            Word = theWord;
        }

        public void setCounter(int theCounter)
        {
            Counter = theCounter;
        }

        public String getWord()
        {
            return Word;
        }

        public int getCount()
        {
            return Counter;
        }

        public int CompareTo(string theWord)
        {
            return Word.CompareTo(theWord);
        }
    }
    
}
