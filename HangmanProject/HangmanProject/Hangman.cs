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
        private Random rand = new Random();

        //Word used in game
        private String getRandomWord()
        {
            return dictionary[rand.Next(0, dictionary.Length)].ToUpper();
        }

        public void RestartWithNewWord(String theWord)
        {
            theWord = getRandomWord();
            CurrentReveal = new StringBuilder(theWord);
            for (int i = 0; i < theWord.Length; i++)
            {
                CurrentReveal[i] = '_';
            }
        }

        public String GetWord()//
        {
            return CurrentReveal.ToString();
        }

        public String GetLettersUsed()
        {
            return LettersUsed;
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
