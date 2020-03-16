namespace missPACMAN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.redGhost = new System.Windows.Forms.PictureBox();
            this.yellowGhost = new System.Windows.Forms.PictureBox();
            this.pinkGhost = new System.Windows.Forms.PictureBox();
            this.pacman = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wall2 = new System.Windows.Forms.PictureBox();
            this.wall1 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.wall6 = new System.Windows.Forms.PictureBox();
            this.wall3 = new System.Windows.Forms.PictureBox();
            this.wall5 = new System.Windows.Forms.PictureBox();
            this.wall4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // redGhost
            // 
            this.redGhost.Image = global::missPACMAN.Properties.Resources.red_guy;
            this.redGhost.Location = new System.Drawing.Point(111, 242);
            this.redGhost.Margin = new System.Windows.Forms.Padding(4);
            this.redGhost.Name = "redGhost";
            this.redGhost.Size = new System.Drawing.Size(36, 38);
            this.redGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redGhost.TabIndex = 4;
            this.redGhost.TabStop = false;
            this.redGhost.Tag = "ghost";
            // 
            // yellowGhost
            // 
            this.yellowGhost.Image = global::missPACMAN.Properties.Resources.yellow_guy;
            this.yellowGhost.Location = new System.Drawing.Point(521, 327);
            this.yellowGhost.Margin = new System.Windows.Forms.Padding(4);
            this.yellowGhost.Name = "yellowGhost";
            this.yellowGhost.Size = new System.Drawing.Size(36, 38);
            this.yellowGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowGhost.TabIndex = 5;
            this.yellowGhost.TabStop = false;
            this.yellowGhost.Tag = "ghost";
            // 
            // pinkGhost
            // 
            this.pinkGhost.Image = global::missPACMAN.Properties.Resources.pink_guy;
            this.pinkGhost.Location = new System.Drawing.Point(115, 409);
            this.pinkGhost.Margin = new System.Windows.Forms.Padding(4);
            this.pinkGhost.Name = "pinkGhost";
            this.pinkGhost.Size = new System.Drawing.Size(36, 38);
            this.pinkGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinkGhost.TabIndex = 6;
            this.pinkGhost.TabStop = false;
            this.pinkGhost.Tag = "ghost";
            // 
            // pacman
            // 
            this.pacman.Image = global::missPACMAN.Properties.Resources.Left;
            this.pacman.Location = new System.Drawing.Point(556, 173);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(40, 40);
            this.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacman.TabIndex = 8;
            this.pacman.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Image = global::missPACMAN.Properties.Resources.coint2;
            this.pictureBox27.Location = new System.Drawing.Point(680, 519);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(20, 20);
            this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox27.TabIndex = 28;
            this.pictureBox27.TabStop = false;
            this.pictureBox27.Tag = "coin";
            // 
            // pictureBox28
            // 
            this.pictureBox28.Image = global::missPACMAN.Properties.Resources.coint2;
            this.pictureBox28.Location = new System.Drawing.Point(483, 532);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(20, 20);
            this.pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox28.TabIndex = 29;
            this.pictureBox28.TabStop = false;
            this.pictureBox28.Tag = "coin";
            // 
            // pictureBox32
            // 
            this.pictureBox32.Image = global::missPACMAN.Properties.Resources.coint2;
            this.pictureBox32.Location = new System.Drawing.Point(483, 105);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(20, 20);
            this.pictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox32.TabIndex = 33;
            this.pictureBox32.TabStop = false;
            this.pictureBox32.Tag = "coin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(433, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(549, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 38);
            this.label2.TabIndex = 42;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wall2
            // 
            this.wall2.BackColor = System.Drawing.Color.MidnightBlue;
            this.wall2.Location = new System.Drawing.Point(-1, 1);
            this.wall2.Margin = new System.Windows.Forms.Padding(4);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(810, 71);
            this.wall2.TabIndex = 49;
            this.wall2.TabStop = false;
            this.wall2.Tag = "wall";
            // 
            // wall1
            // 
            this.wall1.BackColor = System.Drawing.Color.MidnightBlue;
            this.wall1.Location = new System.Drawing.Point(744, 1);
            this.wall1.Margin = new System.Windows.Forms.Padding(4);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(65, 651);
            this.wall1.TabIndex = 53;
            this.wall1.TabStop = false;
            this.wall1.Tag = "wall";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::missPACMAN.Properties.Resources.coint2;
            this.pictureBox12.Location = new System.Drawing.Point(115, 107);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(20, 20);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 56;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "coin";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::missPACMAN.Properties.Resources.coint2;
            this.pictureBox15.Location = new System.Drawing.Point(203, 519);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(20, 20);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 57;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "coin";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::missPACMAN.Properties.Resources.coint2;
            this.pictureBox16.Location = new System.Drawing.Point(278, 307);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(20, 20);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 58;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "coin";
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::missPACMAN.Properties.Resources.coint2;
            this.pictureBox17.Location = new System.Drawing.Point(607, 427);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(20, 20);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 59;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "coin";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::missPACMAN.Properties.Resources.coint2;
            this.pictureBox18.Location = new System.Drawing.Point(261, 121);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(20, 20);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 60;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "coin";
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::missPACMAN.Properties.Resources.coint2;
            this.pictureBox19.Location = new System.Drawing.Point(698, 242);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(20, 20);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 61;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "coin";
            // 
            // wall6
            // 
            this.wall6.BackColor = System.Drawing.Color.MidnightBlue;
            this.wall6.Location = new System.Drawing.Point(-1, 1);
            this.wall6.Margin = new System.Windows.Forms.Padding(4);
            this.wall6.Name = "wall6";
            this.wall6.Size = new System.Drawing.Size(65, 651);
            this.wall6.TabIndex = 62;
            this.wall6.TabStop = false;
            this.wall6.Tag = "wall3";
            // 
            // wall3
            // 
            this.wall3.BackColor = System.Drawing.Color.MidnightBlue;
            this.wall3.Location = new System.Drawing.Point(-1, 581);
            this.wall3.Margin = new System.Windows.Forms.Padding(4);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(810, 71);
            this.wall3.TabIndex = 63;
            this.wall3.TabStop = false;
            this.wall3.Tag = "wall4";
            // 
            // wall5
            // 
            this.wall5.BackColor = System.Drawing.Color.MidnightBlue;
            this.wall5.Location = new System.Drawing.Point(374, 2);
            this.wall5.Margin = new System.Windows.Forms.Padding(4);
            this.wall5.Name = "wall5";
            this.wall5.Size = new System.Drawing.Size(65, 139);
            this.wall5.TabIndex = 64;
            this.wall5.TabStop = false;
            this.wall5.Tag = "wall3";
            // 
            // wall4
            // 
            this.wall4.BackColor = System.Drawing.Color.MidnightBlue;
            this.wall4.Location = new System.Drawing.Point(374, 532);
            this.wall4.Margin = new System.Windows.Forms.Padding(4);
            this.wall4.Name = "wall4";
            this.wall4.Size = new System.Drawing.Size(65, 121);
            this.wall4.TabIndex = 65;
            this.wall4.TabStop = false;
            this.wall4.Tag = "wall6";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::missPACMAN.Properties.Resources.coint2;
            this.pictureBox1.Location = new System.Drawing.Point(314, 447);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "coin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::missPACMAN.Properties.Resources.coint2;
            this.pictureBox2.Location = new System.Drawing.Point(638, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "coin";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::missPACMAN.Properties.Resources.coint2;
            this.pictureBox3.Location = new System.Drawing.Point(115, 345);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 68;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "coin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 654);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.wall4);
            this.Controls.Add(this.wall5);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.wall6);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wall1);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.pictureBox32);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pacman);
            this.Controls.Add(this.pinkGhost);
            this.Controls.Add(this.yellowGhost);
            this.Controls.Add(this.redGhost);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Miss Pacman";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox redGhost;
        private System.Windows.Forms.PictureBox yellowGhost;
        private System.Windows.Forms.PictureBox pinkGhost;
        private System.Windows.Forms.PictureBox pacman;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox pictureBox28;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox wall2;
        private System.Windows.Forms.PictureBox wall1;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox wall6;
        private System.Windows.Forms.PictureBox wall3;
        private System.Windows.Forms.PictureBox wall5;
        private System.Windows.Forms.PictureBox wall4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

