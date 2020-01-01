using System;

namespace StringCount
{
    class Program
    {      
        static void Main(string[] args)
        {          
            Console.WriteLine("This program will count the number of letters in a sentance"); // the program follows through in order with no loops, is that all? could be asked to experiment
            Console.WriteLine("Please enter your sentance");
            string Sentance = Console.ReadLine();
            int maxWords = Sentance.Length;
            string[] split = Sentance.Split(new char[] { ',' });
            Console.WriteLine("Count of letters:" + Sentance.Length);
            Console.WriteLine("Thankyou for using the letter counting program");
            Console.WriteLine("Please press enter to exit");
            Console.ReadKey();
        }
    }
}