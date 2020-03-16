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

        // ghost variables
        int ghost1x;
        int ghost1y;
        int ghost2x;
        int ghost2y;
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
            // end of player movements          

            // moving ghosts and wall collisons
            redGhost.Left += ghost1;
            yellowGhost.Left += ghost2;
            pinkGhost.Left += ghost3x;

            // for loop for ghosts, walls and points
            foreach  (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "ghost") // checks if player hits wall/ghost if so game over
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pacman.Bounds) || score == 12)
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

            // pink ghost
            pinkGhost.Left += ghost3x; // crazy pink ghost (faster than others)
            pinkGhost.Top += ghost3y;

            if (pinkGhost.Left < 1 || pinkGhost.Left + pinkGhost.Width > ClientSize.Width - 2 ||
                (pinkGhost.Bounds.IntersectsWith(wall4.Bounds)) ||
                pinkGhost.Bounds.IntersectsWith(wall3.Bounds) ||
                pinkGhost.Bounds.IntersectsWith(wall2.Bounds) ||
                pinkGhost.Bounds.IntersectsWith(wall1.Bounds) ||
                pinkGhost.Bounds.IntersectsWith(wall5.Bounds)||
                pinkGhost.Bounds.IntersectsWith(wall6.Bounds))
                
            {
                ghost3x = -ghost3x;
            }

            if (pinkGhost.Top < 1 || pinkGhost.Top + pinkGhost.Height > ClientSize.Height - 2)
            {
                ghost3y = -ghost3y;
            }
            
            // yellow ghost
            if (yellowGhost.Left < 1 || yellowGhost.Left + yellowGhost.Width > ClientSize.Width - 2 ||
                (yellowGhost.Bounds.IntersectsWith(wall4.Bounds)) ||
                yellowGhost.Bounds.IntersectsWith(wall3.Bounds) ||
                yellowGhost.Bounds.IntersectsWith(wall2.Bounds) ||
                yellowGhost.Bounds.IntersectsWith(wall1.Bounds) ||
                yellowGhost.Bounds.IntersectsWith(wall5.Bounds) ||
                yellowGhost.Bounds.IntersectsWith(wall6.Bounds))

            {
                ghost1x = -ghost1x;
            }

            if (yellowGhost.Top < 1 || yellowGhost.Top + yellowGhost.Height > ClientSize.Height - 2)
            {
                ghost1y = -ghost1y;
            }

            // red ghost
            if (redGhost.Left < 1 || redGhost.Left + redGhost.Width > ClientSize.Width - 2 ||
                (redGhost.Bounds.IntersectsWith(wall4.Bounds)) ||
                redGhost.Bounds.IntersectsWith(wall3.Bounds) ||
                redGhost.Bounds.IntersectsWith(wall2.Bounds) ||
                redGhost.Bounds.IntersectsWith(wall1.Bounds) ||
                redGhost.Bounds.IntersectsWith(wall5.Bounds) ||
                redGhost.Bounds.IntersectsWith(wall6.Bounds))

            {
                ghost2x = -ghost2x;
            }

            

            

            if (redGhost.Top < 1 || redGhost.Top + redGhost.Height > ClientSize.Height - 2)
            {
                ghost2y = -ghost2y;
            }
        }
    }
}
