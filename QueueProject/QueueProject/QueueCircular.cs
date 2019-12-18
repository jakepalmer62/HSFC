using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProject
{
    public class QueueCircular // this queue repeats along a circle so that it doesn't continually creep backwards.
    {
        private Object[] theItems;
        private int front = 0;                 
        private int back = 0;                 
        private int maxSize = 10;              
        private int length = 0;

        public QueueCircular(int theSize)
        {
            maxSize = theSize; // sets the max size of the queue to 10
            theItems = new Object[theSize];
        }

        public void EnQueue(Object theObject) // adds the item to the queue
        {
            if (length < maxSize)
            {
                theItems[back] = theObject;      
                back = (back + 1) % maxSize;
                length++;
            }
        }

        public Object DeQueue() // remove an item from the queue
        {
            Object temp = null;
            if (length > 0)
            {
                temp = theItems[front];         
                front = (front + 1) % maxSize;    
                length--;
            }
            return temp;                          
        }

        public int Length()
        {
            return length;
        }

        public bool IsEmpty()
        {
            return (this.length == 0);
        }
    }
    
}
