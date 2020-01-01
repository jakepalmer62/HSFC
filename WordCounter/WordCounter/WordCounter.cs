using System;
using System.Collections.Generic;
using System.Text;

namespace WordCounter
{
    class WordCounter
    {
       
        private WordCountPair[] collection;
        private int nextFreeLocation = 0;      
        public WordCounter(int maxSize)
        {
            collection = new WordCountPair[maxSize];
        }
        public int AddString(String newWord)
        {

            if (nextFreeLocation > collection.Length)
                return -1;
            int position = FindPositionOfName(newWord);

            if (position != -1) // name exists
            {
                collection[position].SetCount(collection[position].GetCount() + 1);
                return collection[position].GetCount();
            }
            return collection[AddNewNameToList(newWord)].GetCount();
        }
        public int AddNewNameToList(string theWord)
        {
            int position = 0;

            while ((position < nextFreeLocation) &&
                   (collection[position].CompareTo(theWord) < 0))
            {
                position = position + 1;
            }
            for (int i = nextFreeLocation; i > position; i--)
            {
                collection[i] = collection[i - 1];
            }
            collection[position] = new WordCountPair(theWord, 1);
            nextFreeLocation++;
            return position;
        }
        public int FindPositionOfName(string theNewWord)
        {
            for (int i = 0; i < nextFreeLocation; i++)
            {
                if (collection[i].CompareTo(theNewWord) == 0)
                    return i;
            }
            return -1;
        }

        public override string ToString()
        {
            String theString = "";
            for (int i = 0; i < nextFreeLocation; i++)
            {
                theString = theString + collection[i] + Environment.NewLine;
            }
            return theString;
        }
    }
}
