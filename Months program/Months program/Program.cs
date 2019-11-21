using System;

namespace Months_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Month");
        }

        int month = Convert.ToInt32 (
            Console.ReadLine());
        
        if (month == 4) | (month == 9)
            Console.WriteLine("30 Days");
        

    }
}
