using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate your BMI");

            string name;
            Console.WriteLine("What is your first name?");
            name = Console.ReadLine();
            Console.WriteLine("Your name is");

            double weight;
            Console.WriteLine("How much do you weigh in kilograms?");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You weigh");

            double height;
            Console.WriteLine("What is your height in metres^2?");
            height = Convert.ToDouble(Console.ReadLine()) 
            Console.WriteLine("Your height is");


            double BMI;
            Console.WriteLine("Your BMI is");
            BMI = Console.WriteLine(height/weight);








        }
    }
}
