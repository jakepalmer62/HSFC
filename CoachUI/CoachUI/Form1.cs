using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // create a person with correct name and age
            Person p1 = new Person(nameTextBox.Text, Convert.ToInt32(ageTextBox.Text));
            Coach coach = new Coach();
            // add to coach
            int seat = coach.AddPerson(p1);
            seatTextBox.Text = seat + "";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
