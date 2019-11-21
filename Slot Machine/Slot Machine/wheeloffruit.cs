using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace Slot_Machine
{
    public class wheeloffruit
    {
        public Random rand = new Random();
        public enum Fruits { Apple, Banana, Bar, Grape, Orange, Pear, Raspberry, Strawberry } //adds images 
        private Fruits[] theWheel = new Fruits[8]; //array for fruit images
        const int wheelPosition = 3; //maintains the wheel at a certain image (the Bar image)     

        public wheeloffruit()
        {
            for (int i = 0; i < theWheel.Length; i++)
            {
                theWheel[i] = (Fruits)i;
            }
            this.Spin(); 
        }    

        public void Nudge(int num) //nudges the image by one each time
        {
           Fruits Front; 
           for (int nudge = 0; nudge < num; nudge++)
           {
                Front = theWheel[0];
                for (int i = 0; i < theWheel.Length - 1; i++)
                    
                {
                    theWheel[i] = theWheel[i + 1];
                }
                theWheel[theWheel.Length - 1] = Front;
           }
                                       
        }

        public Fruits GetCurrentFruit() //returns the current image
        {
            return theWheel[wheelPosition]; 
        }

        public void Spin()
        {
            int first, second;

            Fruits temp;

            for (first = 0; first < theWheel.Length; first++) 
            {
                second = rand.Next(0, theWheel.Length); //generates a random number to shuffle the pictures

                temp = theWheel[first];
                theWheel[first] = theWheel[second]; //these swap randomly to shuffle the pictures
                theWheel[second] = temp;
            }
        }
        
         
    }
}
