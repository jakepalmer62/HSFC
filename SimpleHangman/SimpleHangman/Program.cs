﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("==============================");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            //WordList
            string[] listwords = new string[10];
            listwords[0] = "hello";
            listwords[1] = "computer";
            listwords[2] = "college";
            listwords[3] = "america";
            listwords[4] = "watermelon";
            listwords[5] = "icecream";
            listwords[6] = "alex";
            listwords[7] = "pineapple";
            listwords[8] = "orange";
            listwords[9] = "mango";
            Random rand = new Random();

            //selecting word
            var WordLength = rand.Next(0, 9);
            string mysteryWord = listwords[WordLength];
            char[] guess = new char[mysteryWord.Length];
            Console.Write("Please enter your guess: ");

            for (int i = 0; i < mysteryWord.Length; i++)
            {
                guess[i] = '*';
            }

            while (true)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int e = 0; e < mysteryWord.Length; e++)
                {
                    if (playerGuess == mysteryWord[e])
                    {
                        guess[e] = playerGuess;
                    }


                }
                Console.WriteLine(guess);
            }
        }
    }
}
