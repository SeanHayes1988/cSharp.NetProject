using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonsApp
{
    public partial class Bay1 : Form
    {
        public Bay1()
        {
            InitializeComponent();
        }

        private void ChangeLabels()
        {
            StreamReader bay = new StreamReader("C:\\Users\\Administrator\\Documents\\bons\\BayNo1.txt");
                txtBayText.Text = bay.ReadToEnd();
                bay.Close();     
        }

        private void Bay1_Load(object sender, EventArgs e)
        {
            ChangeLabels();   
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        
        }
    }
}
