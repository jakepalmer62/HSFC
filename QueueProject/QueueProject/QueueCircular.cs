using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProject
{
    public class QueueCircular // this queue repeats along a circle so that it doesn't continually creep backwards.
    {
        public Object[] theItems;
        public int front = 0;                 
        public int back = 0;                 
        public int maxSize = 10;              
        public int length = 0;

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

        public void DeQueue(Object theObject) // remove an item from the queue
        {
            Object temp = null;
            if (length > 0)
            {
                temp = theItems[front];         
                front = (front + 1) % maxSize;    
                length--;
            }                        
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