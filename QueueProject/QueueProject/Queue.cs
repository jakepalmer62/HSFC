using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProject
{
    public class QueueCreep // this queue creeps along the array
    {
        int QueueLength;
        int Front = 0;
        int Back = 0;
        public Object[] queueCreep;
        private int MaxSize = 10;

        public QueueCreep(int QueueSize)
        {
            MaxSize = QueueSize;
            queueCreep = new Object[QueueSize];
        }
        public void EnQueue(QueueCreep theQueue)
        {
            if (QueueLength > MaxSize)
            {
                queueCreep[Back] = theQueue;
                Back = Back + 1;
                QueueLength++;
               
            }
        }
        public void DeQueue(QueueCreep theQueue)
        {
            if (QueueLength > 0)
            {
                object found = queueCreep[0];
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
