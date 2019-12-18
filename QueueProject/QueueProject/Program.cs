using System;

namespace QueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueCircular Myqueue = new QueueCircular(10);
            bool running;
            Console.WriteLine("Select which process you would like to run by typing in it's letter in capitals. The maximum size of the queue is 10");
            running = true;

            while (running == true)
            {
                Console.WriteLine("A. Add Person");
                Console.WriteLine("B. Remove Person");
                Console.WriteLine("C. View Queue Length");
                Console.WriteLine("D. Display Queue");
                Console.WriteLine("E. Quit");
                Console.ReadLine();
            }
            
            
            switch (Console.ReadLine())
            {
                case "A": //Enqueue
                    {
                        Console.WriteLine("Type what you want to add to the queue");
                        QueueCircular.EnQueue(Console.ReadLine());
                        break;
                    }

                case "B": //Dequeue
                    {
                        Console.WriteLine("Type what you need to remove from the queue");
                        QueueCircular.DeQueue(Console.ReadLine());
                        break;
                    }

                case "C":
                    {
                        break;
                    }

                case "D":
                    {




                        break;
                    }

                case "E":
                    {

                        running = false;
                        Console.WriteLine("Press enter to exit program");
                        Console.ReadKey();
                        break;
                    }
            }        

        }
    }
}
