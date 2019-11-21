namespace Slot_Machine
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
            this.nudgeButton1 = new System.Windows.Forms.Button();
            this.nudgeButton2 = new System.Windows.Forms.Button();
            this.nudgeButton3 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.spinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nudgeButton1
            // 
            this.nudgeButton1.BackColor = System.Drawing.Color.Blue;
            this.nudgeButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudgeButton1.ForeColor = System.Drawing.Color.GreenYellow;
            this.nudgeButton1.Location = new System.Drawing.Point(114, 268);
            this.nudgeButton1.Name = "nudgeButton1";
            this.nudgeButton1.Size = new System.Drawing.Size(162, 48);
            this.nudgeButton1.TabIndex = 0;
            this.nudgeButton1.Text = "Nudge 1";
            this.nudgeButton1.UseVisualStyleBackColor = false;
            // 
            // nudgeButton2
            // 
            this.nudgeButton2.BackColor = System.Drawing.Color.Blue;
            this.nudgeButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudgeButton2.ForeColor = System.Drawing.Color.GreenYellow;
            this.nudgeButton2.Location = new System.Drawing.Point(320, 268);
            this.nudgeButton2.Name = "nudgeButton2";
            this.nudgeButton2.Size = new System.Drawing.Size(162, 48);
            this.nudgeButton2.TabIndex = 1;
            this.nudgeButton2.Text = "Nudge 2";
            this.nudgeButton2.UseVisualStyleBackColor = false;
            this.nudgeButton2.Click += new System.EventHandler(this.nudgeButton2_Click);
            // 
            // nudgeButton3
            // 
            this.nudgeButton3.BackColor = System.Drawing.Color.Blue;
            this.nudgeButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudgeButton3.ForeColor = System.Drawing.Color.GreenYellow;
            this.nudgeButton3.Location = new System.Drawing.Point(544, 268);
            this.nudgeButton3.Name = "nudgeButton3";
            this.nudgeButton3.Size = new System.Drawing.Size(162, 48);
            this.nudgeButton3.TabIndex = 2;
            this.nudgeButton3.Text = "Nudge 3";
            this.nudgeButton3.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Blue;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.exitButton.Location = new System.Drawing.Point(460, 371);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(246, 57);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit Program";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(331, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Slot Master";
            // 
            // spinButton
            // 
            this.spinButton.BackColor = System.Drawing.Color.Blue;
            this.spinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinButton.ForeColor = System.Drawing.Color.GreenYellow;
            this.spinButton.Location = new System.Drawing.Point(114, 371);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(246, 57);
            this.spinButton.TabIndex = 5;
            this.spinButton.Text = "Spin!";
            this.spinButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 509);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nudgeButton3);
            this.Controls.Add(this.nudgeButton2);
            this.Controls.Add(this.nudgeButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nudgeButton1;
        private System.Windows.Forms.Button nudgeButton2;
        private System.Windows.Forms.Button nudgeButton3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button spinButton;
    }
}

