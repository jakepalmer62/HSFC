using System;

namespace QueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Q = new Queue(10);

            Console.WriteLine("Select which process you would like to run by typing in it's number. The maximum size of the queue is 10");

            Console.WriteLine("1. Add Person");
            Console.WriteLine("2. Remove Person");
            Console.WriteLine("3. View Queue Length");
            Console.WriteLine("4. Display Queue");
            Console.WriteLine("5. Quit");
            Console.ReadLine();

            switch (Console.ReadLine())
            {
                case "1":
                    {



                        break;
                    }

                case "2":
                    {



                        break;
                    }

                case "3":
                    {




                        break;
                    }

                case "4":
                    {




                        break;
                    }

                case "5":
                    {




                        break;
                    }
            }        

        }
    }
}
