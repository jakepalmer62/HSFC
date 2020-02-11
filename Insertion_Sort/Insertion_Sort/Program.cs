using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will read items from a list and then sort them into ascending order.");
            Console.WriteLine("==================================================================================================");
            InsertionSort mySorting = new InsertionSort();
            int[] smallList = { 10, 3, 9, 2, 8, 4, 6, 7, 5, 16, 1, 24, 36, 32, 22, 21, };
            int[] longList = new int[1000];
            Random rnd = new Random();

            mySorting.DisplayList(smallList);
            mySorting.InsertSort(ref smallList);
            mySorting.DisplayList(smallList);

            for (int i = 0; i < longList.Length; i++)
            {
                longList[i] = rnd.Next(1, 101); // creates a number between 1 and 100
            }
            //closes program after displaying lsit.
            Console.WriteLine("The second list is the sorted one. Press enter to terminate the program.");
            Console.ReadLine();
        }
    }
}
