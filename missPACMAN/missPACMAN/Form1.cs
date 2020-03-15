using System;
using System.Windows.Forms;

namespace missPACMAN
{
    public partial class Form1 : Form
    {
        // variables
        bool godown;
        bool goleft;
        bool goright;
        bool goup;
        int speed = 5;
        int score = 0;

        // g1 and g2 variables
        int ghost1 = 8;
        int ghost2 = 8; //speed of ghosts, since they are going in different directions we need 2 variables

        // g3 variables (harder ghost, faster speed in different directions)
        int ghost3x = 8;
        int ghost3y = 8;

        // game code
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                pacman.Image = Properties.Resources.Left;
            }   

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                pacman.Image = Properties.Resources.Right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                pacman.Image = Properties.Resources.Up; 
            }

            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                pacman.Image = Properties.Resources.down;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Score: " + score; // shows the score to the player

            // player movement            
            if (goleft)
            {
                pacman.Left -= speed; 
                // moves player to the left
            }

            if (goright)
            {
                pacman.Left += speed;
                // moving player to the right
            }
            
            if (goup)
            {
                pacman.Top -= speed;
                // moving player to the top
            }

            if (godown)
            {
                pacman.Top += speed;
                // moves the player to the bottom
            }
            // end of player movements code            

            // moving ghosts and wall collisons
            redGhost.Left += ghost1;
            yellowGhost.Left += ghost2;

            if (redGhost.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                ghost1 = -ghost1;
            }

            else if (redGhost.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                ghost1 = -ghost1;
            }

            if (yellowGhost.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                ghost2 = -ghost2;
            }

            else if (yellowGhost.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                ghost2 = -ghost2;
            }
            // end

            // for loop for ghosts, walls and points
            foreach  (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag =="wall" || x.Tag =="ghost") // checks if player hits wall/ghost if so game over
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds) || score == 30)
                    {
                        pacman.Left = 0;
                        pacman.Top = 25;
                        label2.Text = "Game Over";
                        label2.Visible = true;
                        timer1.Stop();
                    }
                }
                if (x is PictureBox && x.Tag == "coin")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds))
                    {
                        this.Controls.Remove(x);
                        score++; 
                    }                    
                }
            }
            // end of checking loop

            pinkGhost.Left += ghost3x; // crazy pink ghost (faster than others)
            pinkGhost.Top += ghost3y;

            if (pinkGhost.Left < 1 || pinkGhost.Left + pinkGhost.Width > ClientSize.Width -2 || 
                (pinkGhost.Bounds.IntersectsWith(pictureBox4.Bounds)) || 
                pinkGhost.Bounds.IntersectsWith(pictureBox3.Bounds) || 
                pinkGhost.Bounds.IntersectsWith(pictureBox2.Bounds) || 
                pinkGhost.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                ghost3x = -ghost3x;
            }

            if (pinkGhost.Top < 1 || pinkGhost.Top + pinkGhost.Height > ClientSize.Height - 2)
            {
                ghost3y = -ghost3y;
            }            
        }
    }
}
