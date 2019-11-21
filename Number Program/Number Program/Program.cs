using System;

namespace Number_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to guess the number! The computer is going to pick a random number between 0 and 101 and you have to guess what that number is!");

            Random rnd = new Random(); //generate a seed for a random number
            int Number = rnd.Next(0, 101); //delivers a random value from 1-100
            int Guess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your guess between 1 and 100");
            int Guess1 = Convert.ToInt32(Console.ReadLine());

            if (int Guess1 > int Number ) {
                Console.WriteLine("Too High");
            }
            if (int Guess1 < int Number) {
                Console.WriteLine("Too Low");

            }
            if (int Guess1 == int Number) {
                Console.WriteLine("You got it!");
            }








        }    




    
    
    }
}
