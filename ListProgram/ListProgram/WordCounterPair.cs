using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProgram
{
    class WordCounterPair
    {
        private WordCounter[] Collection;
        public String WordCounter(int maxSize)
        {
            Collection = new WordCounter[maxSize];
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
