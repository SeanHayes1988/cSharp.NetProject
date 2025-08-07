using MongoDB.Bson;
using MongoDB.Driver;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void btnRecovery_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recovery rw = new Recovery();
            rw.Show();
        }
        private void btnDayward_Click(object sender, EventArgs e)
        {
            this.Hide();
          DayWard dw = new DayWard();
           dw.Show();
        }
    }
 
}
