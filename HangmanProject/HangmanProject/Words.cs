using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanProject
{
    class WordList
    {
        public String[] Words;
        Random rnd = new Random();

        List<string> words = new List<string>();

        public void ListOfWords()
        {
            words.Add("test");         // Contains: test
            words.Add("dog");          // Contains: test, dog
            words.Insert(1, "shit"); // Contains: test, shit, dog

            words.Sort();
            foreach (string word in words) // Display for verification
            {
                Console.WriteLine(word);

            }

        string pickWord()
            {
                string returnword = "";
                returnword = ListOfWords[rnd.Next(0, Words.Count - 1)];
                return returnword;
            }
            
                
            






        }
    }
}

     



