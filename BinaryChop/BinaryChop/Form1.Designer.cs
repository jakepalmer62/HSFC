namespace BinaryChop
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchForButton = new System.Windows.Forms.Button();
            this.SwitchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your Text:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListTextBox
            // 
            this.ListTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ListTextBox.Location = new System.Drawing.Point(293, 97);
            this.ListTextBox.Name = "ListTextBox";
            this.ListTextBox.Size = new System.Drawing.Size(191, 22);
            this.ListTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Binary and Serial Search";
            // 
            // SearchForButton
            // 
            this.SearchForButton.Location = new System.Drawing.Point(116, 272);
            this.SearchForButton.Name = "SearchForButton";
            this.SearchForButton.Size = new System.Drawing.Size(122, 40);
            this.SearchForButton.TabIndex = 3;
            this.SearchForButton.Text = "Search For";
            this.SearchForButton.UseVisualStyleBackColor = true;
            this.SearchForButton.Click += new System.EventHandler(this.SearchForButton_Click);
            // 
            // SwitchButton
            // 
            this.SwitchButton.Location = new System.Drawing.Point(116, 336);
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.Size = new System.Drawing.Size(122, 41);
            this.SwitchButton.TabIndex = 4;
            this.SwitchButton.Text = "Switch Search";
            this.SwitchButton.UseVisualStyleBackColor = true;
            this.SwitchButton.Click += new System.EventHandler(this.SwitchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SwitchButton);
            this.Controls.Add(this.SearchForButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ListTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchForButton;
        private System.Windows.Forms.Button SwitchButton;
    }
}

