using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProject
{
    class Queue
    {
        int NextFreeLocation;
        int QueueLength;
        int Front = 0;
        int Back = 0;
        public Object[] QueueItems;
        private int MaxSize = 10;

        public Queue(int QueueSize)
        {
            MaxSize = QueueSize;
            QueueItems = new Object[QueueSize];
        }
        public void EnQueue(Object theObject)
        {
            if (QueueLength > MaxSize)
            {
                QueueItems[Back] = theObject;
                Back = Back + 1;
                QueueLength++;
            }
        }
        public void DeQueue(Object theObject)
        {
            if (QueueLength > 0)
            {
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
