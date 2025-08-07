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
    public partial class MainMenu1 : Form
    {
        public static string nameValue = "";

       // public MainMenu MM1;

       
        public MainMenu1()
        {
            InitializeComponent();
          //  this.MM1 = mm1;
    
        }

        public MainMenu1(frmMenu frmMenu)
        {
        }

        private void Display1_Load(object sender, EventArgs e)
        {
            txtNameB.Text = frmMenu.nameValue;
           
        }

      
        private void btnSend_Click(object sender, EventArgs e)
        {
            nameValue = txtNameA.Text;
            frmMenu display = new frmMenu();
            display.Show();
        }
  
        
    }
}
