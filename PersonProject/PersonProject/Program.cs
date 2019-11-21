using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Jake Palmer", 16);
            Console.WriteLine("The name is " + p1.GetName());
            Console.WriteLine("The age is " + p1.GetAge());
            Console.WriteLine("What would you like the name to be set to?");
            p1.SetName(Console.ReadLine());
            Console.WriteLine("What would you like the age to be set to?");
            p1.SetAge(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("What would you like the address to be set to?");
            Console.WriteLine("The address is " + p1.GetAddress());
            p1.SetAddress(Console.ReadLine());

            Console.WriteLine(p1);
            Console.ReadLine();
        }
    }
}
