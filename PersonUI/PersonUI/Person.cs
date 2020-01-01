using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonUI
{
    class Person
    {
        private String Name = "";

        private int Age = 0;

        public Person(String theName)
        {
            Name = theName;
        }

        public void setName(String theString)
        {
            Name = theString;
        }

        public String getName()
        {
            return Name;
        }

        public void setAge(int theAge)
        {
            Age = theAge;
        }

        public int getAge()
        {
            return Age;
        }
    }
}
