using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanProject
{
    class Players
    {
        private String Name;
        private int Score;

        public Players(String theName)
        {
            Name = theName;
        }

        public void setName(String theName)
        {
            Name = theName;
        }

        public String getname()
        {
            return Name;
        }

        public void setScore(int theScore)
        {
            Score = theScore;
        }

        public int getScore()
        {
            return Score;
        }
    }
}
