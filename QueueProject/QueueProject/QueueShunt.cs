using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProject
{
    public class QueueShunt
    {
        public Object[] ShuntingQueue;
        public int back;
        public int front;

        public QueueShunt(int Length)
        {
            ShuntingQueue = new object[Length];
        }

        public void Enqueue(Object theObject) // adds items to the queue
        {

        }

        public void Dequeue(Object theObject) // adds the items to dequeue
        {

        }
    }
}
