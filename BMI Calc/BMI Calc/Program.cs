using System;

namespace BMI_Calc
{
    class Program
    {
        private const string V = "Your BMI is ";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my BMI calculator.");
            Console.WriteLine("===========");
            Console.WriteLine();

            
            Console.WriteLine("What is your name?");
            string name = (Console.ReadLine());


            Console.Write("Please enter your weight in kg: ");
            double kg;
            kg = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your height in cm: ");
            double cm;
            cm = Convert.ToInt32(Console.ReadLine());


            double sum =
                kg / cm;
            Console.WriteLine( (name) "your BMI is"  + sum);
            Console.WriteLine("Thankyou for using my BMI calculator, press any key to exit");
            Console.ReadKey();

                 


          


            
        }
    }
}
    
