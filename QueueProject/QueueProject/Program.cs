using System;

namespace QueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueCircular Myqueue = new QueueCircular(10);
            bool running;
            Console.WriteLine("Select which process you would like to run by typing in it's number. The maximum size of the queue is 10");
            running = true;

            while (running == true)
            {
                Console.WriteLine("1. Add Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. View Queue Length");
                Console.WriteLine("4. Display Queue");
                Console.WriteLine("5. Quit");
                Console.ReadLine();
            }
            
            
            switch (Console.ReadLine())
            {
                case "1": //Enqueue
                    {
                        Console.WriteLine("Type what you want to add to the queue");
                        QueueCircular.EnQueue(Console.ReadLine());
                        break;
                    }

                case "2": //Dequeue
                    {
                        Console.WriteLine("Type what you need to remove from the queue");
                        QueueCircular.DeQueue(Console.ReadLine());
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

                        running = false;
                        Console.WriteLine("Press enter to exit program");
                        Console.ReadKey();
                        break;
                    }
            }        

        }
    }
}
