using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    public class Person
    {
        private String name = "";
        private int age = 0;
        private String Address = "";

        public Person(String name, int anAge)
        {
            this.SetName(name);
        }
        public Person()
        {

        }
        public void SetName(String theString)
        {
            name = theString;
        }
        public String GetName()
        {
            return name;
        }
        public void SetAge(int theAge)
        {
            age = theAge;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAddress(String theString)
        {
            Address = theString;
        }
        public override String ToString()
        {
            return this.GetName() +
                   " is aged " + 
                   this.GetAge() +
                   " and lives at " +
                   Address;
        }

        

    }
}
