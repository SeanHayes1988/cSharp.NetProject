using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonsApp
{
    public partial class mainMenu : Form
    {
        frmDisplay display = new frmDisplay();
        public static string valueName = "";

        public mainMenu()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valueName = txtName.Text;
            frmDisplay display = new frmDisplay();
           // display.g
            display.ShowDialog();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
