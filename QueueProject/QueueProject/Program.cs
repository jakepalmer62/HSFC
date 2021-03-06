﻿using System;

namespace QueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueShunt MyQueueShunt = new QueueShunt(10);
            QueueCreep MyQueueCreep = new QueueCreep(10);
            QueueCircular Myqueue = new QueueCircular(10);
            bool running;

            Console.WriteLine("Select which process you would like to run by typing in it's letter in capitals. The maximum size of the queue is 10");
            running = true;

            while (running == true)
            {
                Console.WriteLine("A. Add Person");
                Console.WriteLine("B. Remove Person");
                Console.WriteLine("C. View Queue Length");
                Console.WriteLine("D. Quit");
                Console.ReadLine();
            }
                        
            switch (Console.ReadLine())
            {
                case "A": //Enqueue
                    {
                        Console.WriteLine("Type what you want to add to the queue");
                        Myqueue.EnQueue(Console.ReadLine());
                        break;
                    }

                case "B": //Dequeue
                    {
                        Console.WriteLine("Type what you need to remove from the queue");
                        Myqueue.DeQueue(Console.ReadLine());
                        break;
                    }

                case "C":
                    {
                        Console.WriteLine("The queue length is:" + Myqueue.length);
                        break;
                    }

                case "D":
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
