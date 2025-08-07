using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Data.SqlClient;
using System.Collections;


namespace BonsApp
{
    public partial class DayWard : Form
    {

        public DayWard()
        {
           InitializeComponent();
           var task = DayWard_LoadAsync();
           var task1 = BtnInsert_ClickAsync();     
         // var task2 = RecoveryUpdateAsync();
        }
        
        //set Pasid data
        public string Pasid
        {
            set
            {
                txtPasid.Text = value;
            }
        }

        //set Title data
        public string Title
        {
            set
            {
                txtTitle.Text = value;
            }
        }
        
        //set First Name data
    public string FirstName
    {
        set
        {
            txtFirstName.Text = value;
        }
    }
        //set Surname data
        public string Surname
        {
            set
            {
                txtSurname.Text = value;
            }
        }

        //set Patient Type
        public string PatientType
        {
            set
            {
                txtPatientType.Text = value;
            }
        }

        //set BayNumber
        public string BayNumber
        {
            set
            {
                txtBayNo.Text = value;
            }
        }

        //set Transfer data ?????
              public  string Transfer
        {
           get
            {
                return cmbRecovery.Text;
            }
        }

        public string EstimateTime
        {
            get
            {
                return txtEstimateTime.Text;
            }
            
        }

        //Connect to the servver on load and retrieve the data
        private async Task DayWard_LoadAsync()
        {
            try
            {
                {
                    //connect the database and the collection 
                    var client = new MongoClient("mongodb+srv://testBonSecours:5isqbv73@bonssecours1-anhjy.mongodb.net/test");
                    var database = client.GetDatabase("testBonSecours");
                    var collection = database.GetCollection<BsonDocument>("Recovery");

                    //add new data columns with names to the DataGridView
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Pasid", typeof(String));
                    dt.Columns.Add("Title", typeof(String));
                    dt.Columns.Add("First Name", typeof(String));
                    dt.Columns.Add("Surname", typeof(String));
                    dt.Columns.Add("Patient Type", typeof(String));
                    dt.Columns.Add("Bay Number", typeof(String));
                    dt.Columns.Add("Request Send Time", typeof(String));
                    dt.Columns.Add("Request Send Date", typeof(String));
                    dt.Columns.Add("Estimate Time", typeof(String));
                    dt.Columns.Add("Transfer", typeof(String));
                    dt.Columns.Add("Reason for Delay", typeof(String));

                    /*find the required info and add the data to the DataGridView
                     Convert to string type*/
                    var filter = new BsonDocument();
                    using (var cursor = await collection.Find(filter).ToCursorAsync())
                    {
                        while (await cursor.MoveNextAsync())
                        {
                            foreach (var item in cursor.Current)
                            {
                                dt.Rows.Add(item["Pasid"], item["Title"], item["First Name"], item["Surname"], item["Patient Type"], item["Bay Number"],
                                    item["Request Send Time"], item ["Request Send Date"], item["Estimate Time"], item["Transfer"], item["Reason for Delay"]);

                                Console.Write(dt.ToString());
                                dtvRecovery.DataSource = dt;
                                Console.ReadLine();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No Connection");
            }
        }

        private void DayWard_Load(object sender, EventArgs e)
        {
            try
            {
                var task1 = BtnInsert_ClickAsync();
                //  var task = DayWard_LoadAsync();
                Console.WriteLine("Current Value" + cmbRecovery.Text);
                cmbRecovery.SelectedIndex = 0;
                //BtnInsert_ClickAsync();
            }
            catch
            {
                MessageBox.Show("No Connection HELLO");
            }
        }

        private async Task RecoveryUpdateAsync()
        {
            //  try
            //    {
            var client = new MongoClient("mongodb+srv://testBonSecours:5isqbv73@bonssecours1-anhjy.mongodb.net/test");
            var database = client.GetDatabase("testBonSecours");
            var collection = database.GetCollection<BsonDocument>("Recovery");

            int pasid = Int32.Parse(txtPasid.Text);

            Console.WriteLine("Current Value" + cmbRecovery.Text);
            await collection.FindOneAndUpdateAsync(MongoDB.Driver.Builders<BsonDocument>.Filter.Eq("Pasid", pasid), MongoDB.Driver.Builders<BsonDocument>.Update.Set
                ("Transfer", cmbRecovery.Text).Set("Reason for Delay", rchBoxReason.Text).Set("Estimate Time", txtEstimateTime.Text));
            MessageBox.Show("Great Success!!");
            //    } 
            ///  catch (Exception)
            //  {
            //      MessageBox.Show("Sorry No Connection Can Be Made");
            //  }

        }

        private void btnUpdateRecovery_Click(object sender, EventArgs e)
        {
            var task = RecoveryUpdateAsync();
            Recovery rw = new Recovery();
            //  cmbRecovery.Text = "No";
            // cmbRecovery.ToString();
            rw.Transfer = Transfer;
            rw.EstimateTime = EstimateTime;
             rw.Show();

          //  this.Hide();
        }

        private async Task BtnInsert_ClickAsync()
        {
           // try
         //   {
                var client = new MongoClient("mongodb+srv://testBonSecours:5isqbv73@bonssecours1-anhjy.mongodb.net/test");
                var database = client.GetDatabase("testBonSecours");
                var collection = database.GetCollection<BsonDocument>("Recovery");

                DataTable dt = new DataTable();
                dt.Columns.Add("Pasid", typeof(String));
                dt.Columns.Add("Title", typeof(String));
                dt.Columns.Add("First Name", typeof(String));
                dt.Columns.Add("Surname", typeof(String));
                dt.Columns.Add("Patient Type", typeof(String));
                dt.Columns.Add("Bay Number", typeof(String));
                dt.Columns.Add("Request Send Time", typeof(String));
                dt.Columns.Add("Request Send Date", typeof(String));
                dt.Columns.Add("Estimate Time", typeof(String));
                dt.Columns.Add("Transfer", typeof(String));
                dt.Columns.Add("Reason for Delay", typeof(String));
                  
                var filter = new BsonDocument();
                using (var cursor = await collection.Find(filter).ToCursorAsync())
                {
                    while (await cursor.MoveNextAsync())
                    {
                        foreach (var item in cursor.Current)
                        {
                            dt.Rows.Add(item["Pasid"], item["Title"], item["First Name"], item["Surname"], item["Patient Type"],item["Bay Number"],
                                item["Request Send Time"], item["Request Send Date"], item["Estimate Time"], item["Transfer"], item["Reason for Delay"]);
               
                            Console.Write(dt.ToString());
                            dtvRecovery.DataSource = dt;
                            Console.ReadLine();
                        }
                    }
                }
           // }
          //  catch (Exception)
          //  {
          //      MessageBox.Show("No Connection HELLO");
          //  }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var task = BtnInsert_ClickAsync();
            }
            catch
            {
                MessageBox.Show("Sorry No Connection Can Be Made");
            }     
        }

        private void dtvRecovery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                int Rowindex = e.RowIndex;
                int CellIndex = e.ColumnIndex;
                dtvRecovery.Rows[Rowindex].Cells[CellIndex].Style.Font = new Font("Arial", 11, FontStyle.Regular);

            if(txtPasid.DataBindings.Count > 0)
            {
                txtPasid.DataBindings.RemoveAt(0);
            }
            txtPasid.DataBindings.Add(new Binding("Text", dtvRecovery[0, e.RowIndex], "Value", false));
            }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Show();
        }
    }
}

   
 