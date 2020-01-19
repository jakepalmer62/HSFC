using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryChop
{
    
    public partial class Form1 : Form
    {
        private Searches mySearching = new Searches();
        private String[] List;
        public bool SwitchSearch;
        private int ListMaxSize = 10; //the max size of the list is 10

        public Form1()
        {
            InitializeComponent();
            List = new String[ListMaxSize];
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void SearchForButton_Click(object sender, EventArgs e)
        {

        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
