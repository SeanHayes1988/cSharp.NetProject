using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonsApp
{
    public partial class Bay6 : Form
    {
        public Bay6()
        {
            InitializeComponent();
        }
        private void ChangeLabels()
        {
            StreamReader bay = new StreamReader("C:\\Users\\Administrator\\Documents\\bons\\BayNo6.txt");
            txtBayText.Text = bay.ReadToEnd();
            bay.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bay6_Load(object sender, EventArgs e)
        {
            ChangeLabels();
        }
    }
}
