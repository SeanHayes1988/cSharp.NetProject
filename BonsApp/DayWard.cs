using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;


namespace BonsApp
{
    public partial class DayWard : Form
    {
        static String connection = "mongodb+srv://testBonSecours:5isqbv73@bonssecours1-anhjy.mongodb.net/test", cluster = "testBonSecours", table = "Recovery";
        static String pasid = "", title = "", firstName = "", surname = "", patientType = "", bayNumber = "", transfer;
        public int counter;
        bool complete = false;

        public DayWard()
        {
            InitializeComponent();
        }
        private async Task RecoveryUpdateAsync()
        {
            AssignToBay atb = new AssignToBay();
            var client = new MongoClient("mongodb+srv://testBonSecours:5isqbv73@bonssecours1-anhjy.mongodb.net/test");
            var database = client.GetDatabase("testBonSecours");
            var collection = database.GetCollection<BsonDocument>("Recovery");
            int pasid = Int32.Parse(txtPasid.Text);

            if (txtEstimateTime.Text == "0")
            {
                complete = false;
            }
            else
            {
                complete = true;
            }

          //  if ((txtTransfer.Text == "No" && rchBoxReason.Text != "") || txtTransfer.Text == "Yes")
        //    {
                await collection.FindOneAndUpdateAsync(MongoDB.Driver.Builders<BsonDocument>.Filter.Eq("Pasid", pasid), MongoDB.Driver.Builders<BsonDocument>.Update.Set
                    ("Transfer Response Time", atb.RequestedTime).Set("Transfer Response Date", atb.RequestedDate).Set("Transfer", txtTransfer.Text)
                    .Set("Reason for Delay", rchBoxReason.Text).Set("Estimate Time", txtEstimateTime.Text).Set("Complete", complete));
         //   }
        }
        // The next few timers change the bay button color to request sent  orange/dark orange
        public void RequestSent_Tick(object sender, EventArgs e)
        {
            if (btnBay1.BackColor == Color.OrangeRed)
            {
                btnBay1.BackColor = Color.Orange;
            }
            else
                btnBay1.BackColor = Color.OrangeRed;
        }
        public void RequestSent2_Tick(object sender, EventArgs e)
        {
            if (btnBay2.BackColor == Color.OrangeRed)
            {
                btnBay2.BackColor = Color.Orange;
            }
            else
                btnBay2.BackColor = Color.OrangeRed;
        }
        private void RequestSent3_Tick(object sender, EventArgs e)
        {
            if (btnBay3.BackColor == Color.OrangeRed)
            {
                btnBay3.BackColor = Color.Orange;
            }
            else
                btnBay3.BackColor = Color.OrangeRed;
        }
        private void RequestSent4_Tick(object sender, EventArgs e)
        {
            if (btnBay4.BackColor == Color.OrangeRed)
            {
                btnBay4.BackColor = Color.Orange;
            }
            else
                btnBay4.BackColor = Color.OrangeRed;
        }
        private void RequestSent5_Tick(object sender, EventArgs e)
        {
            if (btnBay5.BackColor == Color.OrangeRed)
            {
                btnBay5.BackColor = Color.Orange;
            }
            else
                btnBay5.BackColor = Color.OrangeRed;
        }
        private void RequestSent6_Tick(object sender, EventArgs e)
        {
            if (btnBay6.BackColor == Color.OrangeRed)
            {
                btnBay6.BackColor = Color.Orange;
            }
            else
                btnBay6.BackColor = Color.OrangeRed;
        }
        private void RequestSent7_Tick(object sender, EventArgs e)
        {
            if (btnBay7.BackColor == Color.OrangeRed)
            {
                btnBay7.BackColor = Color.Orange;
            }
            else
                btnBay7.BackColor = Color.OrangeRed;
        }
        private void RequestSent8_Tick(object sender, EventArgs e)
        {
            if (btnBay8.BackColor == Color.OrangeRed)
            {
                btnBay8.BackColor = Color.Orange;
            }
            else
                btnBay8.BackColor = Color.OrangeRed;
        }
        //Assign the values to the form inputs from the button clicked
        private void GrabDataFromDatabase()
        {
            txtPasid.Text = pasid;
            txtBayNo.Text = bayNumber;
            txtTransfer.Text = transfer;
        }
        //the next group will when a certain bay number is clicked then it will display that bay number details from the database
        private async Task DisplayBay1()
        {
            var client = new MongoClient(connection);
            var database = client.GetDatabase(cluster);
            var collection = database.GetCollection<BsonDocument>(table);

            BsonDocument filter = new BsonDocument();
            filter.Add("Bay Number", "1");
            filter.Add("Transfer", "Yes");
            filter.Add("Complete", false);
            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (BsonDocument doc in batch)
                    {
                        pasid = doc["Pasid"].ToString();
                        title = doc["Title"].ToString();
                        firstName = doc["First Name"].ToString();
                        surname = doc["Surname"].ToString();
                        patientType = doc["Patient Type"].ToString();
                        bayNumber = doc["Bay Number"].ToString();
                        transfer = doc["Transfer"].ToString();
                        GrabDataFromDatabase();
                    }
                }
            }
        }
        private async Task DisplayBay2()
        {
            var client = new MongoClient(connection);
            var database = client.GetDatabase(cluster);
            var collection = database.GetCollection<BsonDocument>(table);

            BsonDocument filter = new BsonDocument();
            filter.Add("Bay Number", "2");
            filter.Add("Transfer", "Yes");
            filter.Add("Complete", false);
            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (BsonDocument doc in batch)
                    {
                        pasid = doc["Pasid"].ToString();
                        title = doc["Title"].ToString();
                        firstName = doc["First Name"].ToString();
                        surname = doc["Surname"].ToString();
                        patientType = doc["Patient Type"].ToString();
                        bayNumber = doc["Bay Number"].ToString();
                        transfer = doc["Transfer"].ToString();
                        GrabDataFromDatabase();
                    }
                }
            }
        }
        private async Task DisplayBay3()
        {
            var client = new MongoClient(connection);
            var database = client.GetDatabase(cluster);
            var collection = database.GetCollection<BsonDocument>(table);

            BsonDocument filter = new BsonDocument();
            filter.Add("Bay Number", "3");
            filter.Add("Transfer", "Yes");
            filter.Add("Complete", false);
            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (BsonDocument doc in batch)
                    {
                        pasid = doc["Pasid"].ToString();
                        title = doc["Title"].ToString();
                        firstName = doc["First Name"].ToString();
                        surname = doc["Surname"].ToString();
                        patientType = doc["Patient Type"].ToString();
                        bayNumber = doc["Bay Number"].ToString();
                        transfer = doc["Transfer"].ToString();
                        GrabDataFromDatabase();
                    }
                }
            }
        }
        private async Task DisplayBay4()
        {
            var client = new MongoClient(connection);
            var database = client.GetDatabase(cluster);
            var collection = database.GetCollection<BsonDocument>(table);

            BsonDocument filter = new BsonDocument();
            filter.Add("Bay Number", "4");
            filter.Add("Transfer", "Yes");
            filter.Add("Complete", false);
            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (BsonDocument doc in batch)
                    {
                        pasid = doc["Pasid"].ToString();
                        title = doc["Title"].ToString();
                        firstName = doc["First Name"].ToString();
                        surname = doc["Surname"].ToString();
                        patientType = doc["Patient Type"].ToString();
                        bayNumber = doc["Bay Number"].ToString();
                        transfer = doc["Transfer"].ToString();
                        GrabDataFromDatabase();
                    }
                }
            }
        }
        private async Task DisplayBay5()
        {
            var client = new MongoClient(connection);
            var database = client.GetDatabase(cluster);
            var collection = database.GetCollection<BsonDocument>(table);

            BsonDocument filter = new BsonDocument();
            filter.Add("Bay Number", "5");
            filter.Add("Transfer", "Yes");
            filter.Add("Complete", false);
            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (BsonDocument doc in batch)
                    {
                        pasid = doc["Pasid"].ToString();
                        title = doc["Title"].ToString();
                        firstName = doc["First Name"].ToString();
                        surname = doc["Surname"].ToString();
                        patientType = doc["Patient Type"].ToString();
                        bayNumber = doc["Bay Number"].ToString();
                        transfer = doc["Transfer"].ToString();
                        GrabDataFromDatabase();
                    }
                }
            }
        }
        private async Task DisplayBay6()
        {
            var client = new MongoClient(connection);
            var database = client.GetDatabase(cluster);
            var collection = database.GetCollection<BsonDocument>(table);

            BsonDocument filter = new BsonDocument();
            filter.Add("Bay Number", "6");
            filter.Add("Transfer", "Yes");
            filter.Add("Complete", false);
            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (BsonDocument doc in batch)
                    {
                        pasid = doc["Pasid"].ToString();
                        title = doc["Title"].ToString();
                        firstName = doc["First Name"].ToString();
                        surname = doc["Surname"].ToString();
                        patientType = doc["Patient Type"].ToString();
                        bayNumber = doc["Bay Number"].ToString();
                        transfer = doc["Transfer"].ToString();
                        GrabDataFromDatabase();
                    }
                }
            }
        }
        private async Task DisplayBay7()
        {
            var client = new MongoClient(connection);
            var database = client.GetDatabase(cluster);
            var collection = database.GetCollection<BsonDocument>(table);

            BsonDocument filter = new BsonDocument();
            filter.Add("Bay Number", "7");
            filter.Add("Transfer", "Yes");
            filter.Add("Complete", false);
            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (BsonDocument doc in batch)
                    {
                        pasid = doc["Pasid"].ToString();
                        title = doc["Title"].ToString();
                        firstName = doc["First Name"].ToString();
                        surname = doc["Surname"].ToString();
                        patientType = doc["Patient Type"].ToString();
                        bayNumber = doc["Bay Number"].ToString();
                        transfer = doc["Transfer"].ToString();
                        GrabDataFromDatabase();
                    }
                }
            }
        }
        private async Task DisplayBay8()
        {
            var client = new MongoClient(connection);
            var database = client.GetDatabase(cluster);
            var collection = database.GetCollection<BsonDocument>(table);

            BsonDocument filter = new BsonDocument();
            filter.Add("Bay Number", "8");
            filter.Add("Transfer", "Yes");
            filter.Add("Complete", false);
            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (BsonDocument doc in batch)
                    {
                        pasid = doc["Pasid"].ToString();
                        title = doc["Title"].ToString();
                        firstName = doc["First Name"].ToString();
                        surname = doc["Surname"].ToString();
                        patientType = doc["Patient Type"].ToString();
                        bayNumber = doc["Bay Number"].ToString();
                        transfer = doc["Transfer"].ToString();
                        GrabDataFromDatabase();
                    }
                }
            }
        }
        private void TransferChanges()
        {
            txtTransfer.Text = "Yes";
            rchBoxReason.Visible = false;
        }
    private void btnBay1_Click(object sender, EventArgs e)
        {
            var task = DisplayBay1();
            TransferChanges();
        }
        private void btnBay2_Click(object sender, EventArgs e)
        {
            var task = DisplayBay2();
            TransferChanges();
        }
        private void btnBay3_Click(object sender, EventArgs e)
        {
            var task = DisplayBay3();
            TransferChanges();
        }
        private void btnBay4_Click(object sender, EventArgs e)
        {
            var task = DisplayBay4();
            TransferChanges();
        }
        private void btnBay5_Click(object sender, EventArgs e)
        {
            var task = DisplayBay5();
            TransferChanges();
        }
        private void btnBay6_Click(object sender, EventArgs e)
        {
            var task = DisplayBay6();
            TransferChanges();
        }
        private void btnBay7_Click(object sender, EventArgs e)
        {
            var task = DisplayBay7();
            TransferChanges();
        }
        private void btnBay8_Click(object sender, EventArgs e)
        {
            var task = DisplayBay8();
            TransferChanges();
        }
        //The following timers check if the details enterdd and starts the counter compared to the entered the time
        public void btnUpdate_Click(object sender, EventArgs e)
        { 
            Recovery r = new Recovery();
           
             if (btnBay1.Text=="Bay 1\r\nTransfer\r\nRequested"|| btnBay2.Text=="Bay 2\r\nTransfer\r\nRequested"|| btnBay3.Text== "Bay 3\r\nTransfer\r\nRequested" 
                  || btnBay4.Text=="Bay 4\r\nTransfer\r\nRequested" || btnBay5.Text=="Bay 5\r\nTransfer\r\nRequested" || btnBay6.Text=="Bay 6\r\nTransfer\r\nRequested"
                  || btnBay7.Text=="Bay 7\r\nTransfer\r\nRequested" || btnBay8.Text=="Bay 8\r\nTransfer\r\nRequested")
               { 
             if(MessageBox.Show("Do You Want Update Bay Information?, Recovery Bay Will Be Notified", "WARNING!!!",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                counter = int.Parse(txtEstimateTime.Text.ToString());
                counter = int.Parse(txtEstimateTime.Text) * 60;
                r.txtEstimateTime.Text = txtEstimateTime.Text.ToString();
                r.counter = int.Parse(r.txtEstimateTime.Text) * 60;
                r.txtBayNumber.Text = txtBayNo.Text;
                r.txtTransfer.Text = transfer;
                r.rchDelay.Text = rchBoxReason.Text;
                var task = RecoveryUpdateAsync();
                r.Show();

                if (btnBay1.Text == "Bay 1\r\nTransfer\r\nRequested" && txtBayNo.Text == "1")
                    {
                    RequestTimedOut.Start();
                    RequestSent.Stop();
                    btnBay1.Text = "Bay 1\r\nTransfer\r\nAccepted";
                     r.RequestTimedOut.Start();
                    }
            
               else if (btnBay2.Text == "Bay 2\r\nTransfer\r\nRequested" && txtBayNo.Text == "2")
               {
                   RequestTimeOut2.Start();
                   btnBay2.Text = "Bay 2\r\nTransfer\r\nAccepted";
                   RequestSent2.Stop();
                   r.RequestTimedOut2.Start();
               }
               else if (btnBay3.Text == "Bay 3r\nTransfer\r\nRequested" && txtBayNo.Text == "3")
                    {
                        RequestTimedOut3.Start();
                        btnBay3.Text = "Bay 3\r\nTransfer\r\nAccepted";
                        RequestSent3.Stop();
                        r.RequestTimedOut3.Start();
                    }
               else if (btnBay4.Text == "Bay 4r\nTransfer\r\nRequested" && txtBayNo.Text == "4")
                   {
                       RequestTimedOut4.Start();
                       btnBay4.Text = "Bay 4\r\nTransfer\r\nAccepted";
                       RequestSent4.Stop();
                       r.RequestTimedOut4.Start();
                   }
               else if (btnBay5.Text == "Bay 5r\nTransfer\r\nRequested" && txtBayNo.Text == "5")
                   {
                       RequestTimedOut5.Start();
                       btnBay5.Text = "Bay 5\r\nTransfer\r\nAccepted";
                       RequestSent5.Stop();
                       r.RequestTimedOut5.Start();
                   }
               else if (btnBay6.Text == "Bay 6r\nTransfer\r\nRequested" && txtBayNo.Text == "6")
                   {
                       RequestTimedOut6.Start();
                       btnBay6.Text = "Bay 6\r\nTransfer\r\nAccepted";
                       RequestSent6.Stop();
                       r.RequestTimedOut6.Start();
                   }
               else if (btnBay7.Text == "Bay 7\r\nTransfer\r\nRequested" && txtBayNo.Text == "7")
                   {
                   RequestTimedOut7.Start();
                   btnBay7.Text = "Bay 7\r\nTransfer\r\nAccepted";
                   RequestSent7.Stop();
                   r.RequestTimedOut7.Start();
                   }
               else if (btnBay8.Text == "Bay 8\r\nTransfer\r\nRequested" && txtBayNo.Text == "8")
               {
                   RequestTimedOut8.Start();
                   btnBay8.Text = "Bay 8\r\nTransfer\r\nAccepted";
                   RequestSent8.Stop();
                   r.RequestTimedOut8.Start();
               }
               MessageBox.Show("Transfer Status Updated", "Information Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
               MessageBox.Show("Transfer Not Accepted, Nothing Updated" , "No Changes Made" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
               else
                MessageBox.Show("Information Missing!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Start count down timer for transfer patient
        private void StartCounter()
        {
            Recovery r = new Recovery();
            counter = counter - 1;
            r.counter = r.counter - 1; 
        }
        //This starts the count timer if the patient isn't tansfered
        private void txtEstimateTime_TextChanged(object sender, EventArgs e)
        {
            if (txtEstimateTime.Text == "0")
            {
                txtTransfer.Text = "No";
                rchBoxReason.Visible = true;
                lblReasonDelay.Visible = true;
                btnUpdate.Text = "Transfer Denied";
             //   btnBay1.Text = "Bay 1\r\nTransfer\r\nRequested";
            }
            else if (txtEstimateTime.Text!= "0")
            {
                txtTransfer.Text = "Yes";
                rchBoxReason.Visible = false;
                lblReasonDelay.Visible = false;
                btnUpdate.Text = "Transfer Accepted";
            }
        }
        private void RequestTimedOut_Tick(object sender, EventArgs e)
        {
           if (txtTransfer.Text == "Yes"&& counter >0 && txtBayNo.Text == "1")
            {
                StartCounter();
                btnBay1.BackColor = Color.BlueViolet;
                pctNotTransfered.Visible = false;
           }
           else
            pctNotTransfered.Visible = true;     
        }
        private void RequestTimeOut2_Tick(object sender, EventArgs e)
        {
            if (txtTransfer.Text == "Yes" && counter > 0 && txtBayNo.Text =="2")
            {
                StartCounter();
                btnBay2.BackColor = Color.BlueViolet;
                pctNotTransfered2.Visible = false;
            }
            else  
                pctNotTransfered2.Visible = true;    
        }
        private void RequestTimedOut3_Tick(object sender, EventArgs e)
        {
            if (txtTransfer.Text == "Yes" && counter > 0 && txtBayNo.Text == "3")
            {
                StartCounter();
                btnBay3.BackColor = Color.BlueViolet;
                pctNotTransfered3.Visible = false;
            }
            else  
                pctNotTransfered3.Visible = true;   
        }
        private void RequestTimedOut4_Tick(object sender, EventArgs e)
        {
            if (txtTransfer.Text == "Yes" && counter > 0 && txtBayNo.Text != "" && txtBayNo.Text == "4")
            {
                StartCounter();
                btnBay4.BackColor = Color.BlueViolet;
                pctNotTransfered4.Visible = false;
            }
            else
                pctNotTransfered4.Visible = true;
        }
        private void RequestTimedOut5_Tick(object sender, EventArgs e)
        {

            if (txtTransfer.Text == "Yes" && counter > 0 && txtBayNo.Text != "" && txtBayNo.Text == "5")
            {
                StartCounter();
                btnBay5.BackColor = Color.BlueViolet;
                pctNotTransfered5.Visible = false;
            }
            else
                pctNotTransfered5.Visible = true;       
        }
        private void RequestTimedOut6_Tick(object sender, EventArgs e)
        {
            if (txtTransfer.Text == "Yes" && counter > 0 && txtBayNo.Text != "" && txtBayNo.Text == "6")
            {
                StartCounter();
                btnBay6.BackColor = Color.BlueViolet;
                pctNotTransfered6.Visible = false;
            }
            else
                pctNotTransfered6.Visible = true;
        }
        private void RequestTimedOut7_Tick(object sender, EventArgs e)
        {
            if (txtTransfer.Text == "Yes" && counter > 0 && txtBayNo.Text != "" && txtBayNo.Text == "7")
            {
                StartCounter();
                btnBay7.BackColor = Color.BlueViolet;
                pctNotTransfered7.Visible = false;    
            }
            else
                pctNotTransfered7.Visible = true;
        }
        private void RequestTimedOut8_Tick(object sender, EventArgs e)
        {
            if (txtTransfer.Text == "Yes" && counter > 0 && txtBayNo.Text != "" && txtBayNo.Text == "8")
            {
                StartCounter();
                btnBay8.BackColor = Color.BlueViolet;
                pctNotTransfered8.Visible = false;    
            }
            else
                 pctNotTransfered8.Visible = true;      
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }  
}