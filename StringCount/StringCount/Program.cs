using System;

namespace StringCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will count the number of letters in a sentance");
            Console.WriteLine("Please enter your sentance");
            string Sentance = Console.ReadLine();
            int maxWords = Sentance.Length;                       
            string[] split = Sentance.Split(new char[] { ',' });
            Console.WriteLine("Count of letters:" + Sentance.Length);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}