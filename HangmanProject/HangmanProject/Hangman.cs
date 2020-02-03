using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanProject
{
    class Hangman
    {
        private String LettersUsed = " ";
        private String theWord = " ";
        private String[] dictionary;
        private Players[] thePlayers;
        private StringBuilder CurrentReveal;
        private Random rnd = new Random();

        //Word used in game
        private String GetRandomWord()
        {           
             string[] theWord = new string[] { "will", "physics", "science", "apple", "computer", "hello" };
             return theWord[rnd.Next(0, theWord.Length)];            
        }

        public void restartWithNewWord()
        {
            theWord = GetRandomWord();
            CurrentReveal = new StringBuilder(theWord);
            for (int i = 0; i < theWord.Length; i++)
            {
                CurrentReveal[i] = '_';
            }
        }

        public String GetWord()
        {
            return CurrentReveal.ToString();
        }

        public String GetLettersUsed()
        {
            return LettersUsed;
        }

        //guesses
        public int MakeGuess(char Letter)
        {
            int Count = 0;
            if (LettersUsed.Contains(Letter))
            {
                return -1;
            }
            if (theWord.Contains(Letter))
            {
                LettersUsed = LettersUsed + Letter;

                // now replace the _ with correctly guessed letters
                for (int i = 0; i < theWord.Length; i++)
                {
                    if (theWord[i] == Letter)
                    {
                        CurrentReveal[i] = Letter;
                        Count++;
                    }
                }
            }
            return Count;   // will still be zero if not found
        }
        //players
        public Hangman (String Player1, String Player2)
        {
            thePlayers = new Players[2];
            thePlayers[0] = new Players(Player1);
            thePlayers[1] = new Players(Player2);
        }
    }
}
