using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Slot_Machine.Properties;


namespace Slot_Machine
{
    public partial class Form1 : Form
    {
        private Random Rand = new Random();
        private Image[] wheelImages = { Resources.apple, Resources.banana, Resources.bar, Resources.grape, Resources.orange, Resources.pear, Resources.raspberry, Resources.strawberry };
        private wheeloffruit[] theWheel = new wheeloffruit[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void nudgeButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void nudgeButton2_Click(object sender, EventArgs e)
        {

        }

        private void nudgeButton3_Click(object sender, EventArgs e)
        {

        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < theWheel.Length; i++)
            {
                theWheel[i].Spin(Rand.Next(5, 50));
            }
            updatePictureBoxes();  // redraw the images
            
        }        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            theWheel[0].Nudge(1);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            theWheel[1].Nudge(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            theWheel[2].Nudge(1);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void updatePictureBoxes()
        {
            pictureBox1.Image = wheelImages[(int)theWheel[0].GetCurrentFruit()];
            pictureBox2.Image = wheelImages[(int)theWheel[1].GetCurrentFruit()];
            pictureBox3.Image = wheelImages[(int)theWheel[2].GetCurrentFruit()];
            pictureBox1.Update();
            pictureBox2.Update();
            pictureBox3.Update();
        }
    }
}
