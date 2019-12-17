using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProject
{
    public class Queue
    {
        int QueueLength;
        int Front = 0;
        int Back = 0;
        public readonly Object[] queue;
        private int MaxSize = 10;

        public Queue(int QueueSize)
        {
            MaxSize = QueueSize;
            queue = new Object[QueueSize];
        }
        public void EnQueue(Queue theQueue)
        {
            if (QueueLength > MaxSize)
            {
                queue[Back] = theQueue;
                Back = Back + 1;
                QueueLength++;
               
            }
        }
        public void DeQueue(Queue theQueue)
        {
            if (QueueLength > 0)
            {
                object found = queue[0];
                Front = Front + 1 % MaxSize;
                QueueLength--;
            }

        }
        public int Length()
        {
            return QueueLength;
        }
        public bool IsQueueEmpty()
        {
            if (QueueLength < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
   
    }
}
