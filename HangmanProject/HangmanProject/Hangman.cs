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
        private Players[] thePlayers;
        public StringBuilder CurrentReveal;
        private static Random rnd = new Random();

        //Word used in game       
        static string[] wordBank = { "Blue", "Black", "Yellow", "Orange", "Green", "Purple" };
        static Random Rand = new Random();
        private static string wordToGuess = wordBank[Rand.Next(0, wordBank.Length)];
        string wordToGuessUppercase = wordToGuess.ToUpper();

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
            if (wordToGuess.Contains(Letter))
            {
                LettersUsed = LettersUsed + Letter;

                // now replace the _ with correctly guessed letters
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == Letter)
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
