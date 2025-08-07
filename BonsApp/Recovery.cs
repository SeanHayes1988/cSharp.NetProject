using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace BonsApp
{
    public partial class Recovery : Form
    {
        static string connection = "mongodb+srv://testBonSecours:5isqbv73@bonssecours1-anhjy.mongodb.net/test", cluster = "testBonSecours", table = "Recovery";
        private int pasid = 1;
        public int counter;
        bool complete = false;
        public Recovery()
        {
            InitializeComponent();
        }  
        //Load data when loaded
        private void Recovery_Load(object sender, EventArgs e)
        {
            try
            {
                var ConnectionString = connection;
                var client = new MongoClient(ConnectionString);
                var db = client.GetDatabase(cluster);
                var collection = db.GetCollection<BsonDocument>(table);

                //read the pasid data and increment the number
                var list = collection.Find(new BsonDocument()).ToList();
                foreach (var doc in list)
                {
                    pasid++;
                    pasid = int.Parse(doc["Pasid"].ToString()) + 1;
                    txtPasid.Text = pasid.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could Not Load Data");
            }
        }
        //Load required Inforamtion when opened
        public void btnAssign_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are Sure You want to assign this person to a the bay?", "IS THE INFORMATION ENTERED CORRECT!!!",
          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ParkPatient();
            }
            else
                MessageBox.Show("Request is Canceled", "Information Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //checks to see if the information is entered correctly 
        private void ParkPatient()
        {
            if (cmbTitle.Text != "" && txtFirstName.Text != "" && cmbBayNo.Text != "" && cmbPatientType.Text != "")
            {
                if (btnBay1.BackColor == Color.SeaGreen && cmbBayNo.Text == "1")
                {
                    btnBay1.Text = "Bay 1\r\nPatient\r\nParked";
                    btnBay1.BackColor = Color.CornflowerBlue;
                    CorrectDataEntered();
                }
                else if (btnBay2.BackColor == Color.SeaGreen && cmbBayNo.Text == "2")
                {
                    btnBay2.Text = "Bay 2\r\nPatient\r\nParked";
                    btnBay2.BackColor = Color.CornflowerBlue;
                    CorrectDataEntered();
                }
                else if (btnBay3.BackColor == Color.SeaGreen && cmbBayNo.Text == "3")
                {
                    btnBay3.Text = "Bay 3\r\nPatient\r\nParked";
                    btnBay3.BackColor = Color.CornflowerBlue;
                    CorrectDataEntered();
                }
                else if (btnBay4.BackColor == Color.SeaGreen && cmbBayNo.Text == "4")
                {
                    btnBay4.Text = "Bay 4\r\nPatient\r\nParked";
                    btnBay4.BackColor = Color.CornflowerBlue;
                    CorrectDataEntered();
                }
                else if (btnBay5.BackColor == Color.SeaGreen && cmbBayNo.Text == "5")
                {
                    btnBay5.Text = "Bay 5\r\nPatient\r\nParked";
                    btnBay5.BackColor = Color.CornflowerBlue;
                    CorrectDataEntered();
                }
                else if (btnBay6.BackColor == Color.SeaGreen && cmbBayNo.Text == "6")
                {
                    btnBay6.Text = "Bay 6\r\nPatient\r\nParked";
                    btnBay6.BackColor = Color.CornflowerBlue;
                    CorrectDataEntered();
                }
                else if (btnBay7.BackColor == Color.SeaGreen && cmbBayNo.Text == "7")
                {
                    btnBay7.Text = "Bay 7\r\nPatient\r\nParked";
                    btnBay7.BackColor = Color.CornflowerBlue;
                    CorrectDataEntered();
                }
                else if (btnBay8.BackColor == Color.SeaGreen && cmbBayNo.Text == "8")
                {
                    btnBay8.Text = "Bay 8\r\nPatient\r\nParked";
                    btnBay8.BackColor = Color.CornflowerBlue;
                    CorrectDataEntered();
                }
                else
                    MessageBox.Show("Bay Number Not Entered Or Already Assigned!", "Information Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Missing Information!", "Information Not Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void CorrectDataEntered()
        {
           // SaveToText();
            MessageBox.Show("Information is Entered To Bay", "Bay Information Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //save potential patient details to corresponding text file 
        
        //Enter data into database requirments
        private async Task btnSendAsync()
        {
            try
            {
                AssignToBay atb = new AssignToBay();
                var ConnectionString = connection;
                var client = new MongoClient(ConnectionString);
                var db = client.GetDatabase(cluster);
                var collection = db.GetCollection<BsonDocument>(table);
              
                var document = new BsonDocument
             {
                 {"Pasid", pasid},
                 {"Title", cmbTitle.Text},
                 {"First Name", txtFirstName.Text},
                 {"Surname", txtSurname.Text },
                 {"Patient Type", cmbPatientType.Text},
                 {"Bay Number", cmbBayNo.Text},
                 {"Request Send Time", atb.RequestedTime},
                 {"Request Send Date",  atb.RequestedDate},
                 {"Transfer Response Time", "No Current Time"},
                 {"Transfer Response Date", "No Current Date"},
                 {"Estimate Time",atb.EstimateTime.ToString()},
                 {"Transfer",txtTransfer.Text},
                 {"Reason for Delay", rchDelay.Text},
                 {"Complete" ,complete}
             };

                var filter = new BsonDocument();
                using (var cursor = await collection.Find(filter).ToCursorAsync())
                {
                    while (await cursor.MoveNextAsync())
                    {
                        foreach (var item in cursor.Current)
                        {
                            pasid = int.Parse(item["Pasid"].ToString()) + 1;
                            pasid++;
                            txtPasid.Text = pasid.ToString();
                        }
                    }
                }
                await collection.InsertOneAsync(document);
            }
            catch (Exception)
            {
                MessageBox.Show("No Connection");
            }
        }
        //send notifaction to the dayward and chage status of the occupied bay 
        private void SendRequest()
        {
             DayWard dw = new DayWard();
            if (btnBay1.BackColor == Color.CornflowerBlue && cmbBayNo.Text == "1")
            {
               btnBay1.Text = "Bay 1\r\nTransfer\r\nRequested";
               btnBay1.BackColor = Color.DarkOrange;
               Request1.Start();
               dw.RequestSent.Start();
               dw.btnBay1.BackColor = Color.Orange;
               dw.btnBay1.Text = "Bay 1\r\nTransfer\r\nRequested";
               dw.Show();
            }
           else if (btnBay2.BackColor == Color.CornflowerBlue && cmbBayNo.Text == "2")
            {
                btnBay2.Text = "Bay 2\nTransfer\r\nRequested";
                btnBay2.BackColor = Color.OrangeRed;
                Request2.Start();
                dw.RequestSent2.Start();
                dw.btnBay2.BackColor = Color.Orange;
                dw.btnBay2.Text = "Bay 2\r\nTransfer\r\nRequested";
                dw.Show();
            }
            else if (btnBay3.BackColor == Color.CornflowerBlue && cmbBayNo.Text == "3")
            {
                btnBay3.Text = "Bay 3\r\nTransfer\r\nRequested";
                btnBay3.BackColor = Color.OrangeRed;
                Request3.Start();
                dw.RequestSent3.Start();
                dw.btnBay3.BackColor = Color.Orange;
                dw.btnBay3.Text = "Bay 3\r\nTransfer\r\nRequested";
                dw.Show();
            }
            else if (btnBay4.BackColor == Color.CornflowerBlue && cmbBayNo.Text == "4")
            {
                btnBay4.Text = "Bay 4\r\nTransfer\r\nRequested";
                btnBay4.BackColor = Color.OrangeRed;
                Request4.Start();
                dw.RequestSent4.Start();
                dw.btnBay4.BackColor = Color.Orange;
                dw.btnBay4.Text = "Bay 4\r\nTransfer\r\nRequested";
                dw.Show();
            }
            else if (btnBay5.BackColor == Color.CornflowerBlue && cmbBayNo.Text == "5")
            {
                btnBay5.Text = "Bay 5\r\nTransfer\r\nRequested";
                btnBay5.BackColor = Color.OrangeRed;
                Request5.Start();
                dw.RequestSent5.Start();
                dw.btnBay5.BackColor = Color.Orange;
                dw.btnBay5.Text = "Bay 5\r\nTransfer\r\nRequested";
                dw.Show();
            }
            else if (btnBay6.BackColor == Color.CornflowerBlue && cmbBayNo.Text == "6")
            {
                btnBay6.Text = "Bay 6\r\nTransfer\r\nRequested";
                btnBay6.BackColor = Color.OrangeRed;
                Request6.Start();
                dw.RequestSent6.Start();
                dw.btnBay6.BackColor = Color.Orange;
                dw.btnBay6.Text = "Bay 6\r\nTransfer\r\nRequested";
                dw.Show();
            }
            else if (btnBay7.BackColor == Color.CornflowerBlue && cmbBayNo.Text == "7")
            {
                btnBay7.Text = "Bay 7\r\nTransfer\r\nRequested";
                btnBay7.BackColor = Color.OrangeRed;
                Request7.Start();
                dw.RequestSent7.Start();
                dw.btnBay7.BackColor = Color.Orange;
                dw.btnBay7.Text = "Bay 7\r\nTransfer\r\nRequested";
                dw.Show();
            }
            else if (btnBay8.BackColor == Color.CornflowerBlue && cmbBayNo.Text == "8")
            {
                btnBay8.Text = "Bay 8\r\nTransfer\r\nRequested";
                btnBay8.BackColor = Color.OrangeRed;
                Request8.Start();
                dw.RequestSent8.Start();
                dw.btnBay8.BackColor = Color.Orange;
                dw.btnBay8.Text = "Bay 8\r\nTransfer\r\nRequested";
                dw.Show();
            }
        }
        //Assign patient to bay number and add to data
        private void SendDataToDaywardForm()
        {
            AssignToBay atb = new AssignToBay();
            txtTransfer.Text = atb.Transfer;
            rchDelay.Text = atb.Delay;
            SendRequest();
            var insert = btnSendAsync();
        }
        //The next few timers are whhe the bays are occupied and the request is sent
        private void Request1_Tick(object sender, EventArgs e)
        {
                if (btnBay1.BackColor == Color.OrangeRed)
                {
                    btnBay1.BackColor = Color.Orange;
                }
                else
                    btnBay1.BackColor = Color.OrangeRed;
        }
        private void Request2_Tick(object sender, EventArgs e)
        {
            if (btnBay2.BackColor == Color.OrangeRed)
            {
                btnBay2.BackColor = Color.Orange;
            }
            else
                btnBay2.BackColor = Color.OrangeRed;
        }
        private void Request3_Tick(object sender, EventArgs e)
        {
            if (btnBay3.BackColor == Color.OrangeRed)
            {
                btnBay3.BackColor = Color.Orange;
            }
            else
                btnBay3.BackColor = Color.OrangeRed;
        }
        private void Request4_Tick(object sender, EventArgs e)
        {
            if (btnBay4.BackColor == Color.OrangeRed)
            {
                btnBay4.BackColor = Color.Orange;
            }
            else
                btnBay4.BackColor = Color.OrangeRed;
        }
        private void Request5_Tick(object sender, EventArgs e)
        {
            if (btnBay5.BackColor == Color.OrangeRed)
            {
                btnBay5.BackColor = Color.Orange;
            }
            else
                btnBay5.BackColor = Color.OrangeRed;
        }
        private void Request6_Tick(object sender, EventArgs e)
        {
            if (btnBay6.BackColor == Color.OrangeRed)
            {
                btnBay6.BackColor = Color.Orange;
            }
            else
                btnBay6.BackColor = Color.OrangeRed;
        }
        private void Request7_Tick(object sender, EventArgs e)
        {
            if (btnBay7.BackColor == Color.OrangeRed)
            {
                btnBay7.BackColor = Color.Orange;
            }
            else
                btnBay7.BackColor = Color.OrangeRed;
        }
        private void Request8_Tick(object sender, EventArgs e)
        {
            if (btnBay8.BackColor == Color.OrangeRed)
            {
                btnBay8.BackColor = Color.Orange;
            }
            else
                btnBay8.BackColor = Color.OrangeRed;
        }
        /*when the send button is clicked the fooow message is displayed 
         * the data isd entered and the bay number status is changed 
         * on both forms */
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Send the Request?", "IS THE INFORMATION ENTERED CORRECT!!!",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
               if (cmbTitle.Text!="" ||txtFirstName.Text!="" || txtSurname.Text!="" || cmbPatientType.Text!="" || cmbBayNo.Text!="")
                {
                 if ((btnBay1.Text== "Bay 1\r\nPatient\r\nParked" && cmbBayNo.Text=="1") || (btnBay2.Text == "Bay 2\r\nPatient\r\nParked" && cmbBayNo.Text =="2") || 
                    (btnBay3.Text == "Bay 3\r\nPatient\r\nParked" && cmbBayNo.Text == "3") || (btnBay4.Text == "Bay 4\r\nPatient\r\nParked" && cmbBayNo.Text == "4")|| 
                    (btnBay5.Text == "Bay 5\r\nPatient\r\nParked" && cmbBayNo.Text == "5") || (btnBay6.Text == "Bay 6\r\nPatient\r\nParked" && cmbBayNo.Text == "6") || 
                    (btnBay7.Text == "Bay 7\r\nPatient\r\nParked" && cmbBayNo.Text == "7") || (btnBay8.Text == "Bay 8\r\nPatient\r\nParked" && cmbBayNo.Text == "8"))
                {
                    SendDataToDaywardForm();
                }
                    else
                        MessageBox.Show("Patient Not Parked in the Chosen Bay!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                MessageBox.Show("Information Missing!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Request is Canceled", "Request Not Send To Dayward", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //the next few timers switch between request replied/denied/not collected
        private void RequestTimedOut_Tick(object sender, EventArgs e)
        {
            Request1.Stop();
            if (counter > 0 && txtBayNumber.Text == "1") 
            {
                counter = counter - 1;
                btnBay1.BackColor = Color.BlueViolet;
                btnBay1.Text = "Bay 1\r\nTransfer\r\nAccepted";
            }
            else if (counter == 0 && txtBayNumber.Text == "1")
            { 
                pctNotTransfered.Visible = true;
            }
        }
        private void RequestTimedOut2_Tick(object sender, EventArgs e)
        {
            Request2.Stop();
            if (counter > 0 && txtBayNumber.Text == "2")
            {
                counter = counter - 1;
                btnBay2.BackColor = Color.BlueViolet;
                btnBay2.Text = "Bay 2\r\nTransfer\r\nAccepted";
            }
            else if (counter == 0 && txtBayNumber.Text == "2")
            {
                pctNotTransfered2.Visible = true;
            }
        }
        private void RequestTimedOut3_Tick(object sender, EventArgs e)
        {
            Request3.Stop();
            if (counter > 0 && txtBayNumber.Text == "3")
            {
                counter = counter - 1;
                btnBay3.BackColor = Color.BlueViolet;
                btnBay3.Text = "Bay 3\r\nTransfer\r\nAccepted";
            }
            else if (counter == 0 && txtBayNumber.Text == "3")
            {
                pctNotTransfered3.Visible = true;
            }
        }
        private void RequestTimedOut4_Tick(object sender, EventArgs e)
        {
            Request4.Stop();
            if (counter > 0 && txtBayNumber.Text == "4")
            {
                counter = counter - 1;
                btnBay4.BackColor = Color.BlueViolet;
                btnBay4.Text = "Bay 4\r\nTransfer\r\nAccepted";
            }
            else if (counter == 0 && txtBayNumber.Text == "4")
            {
                pctNotTransfered4.Visible = true;
            }      
        }
        private void RequestTimedOut5_Tick(object sender, EventArgs e)
        {
            if (counter > 0 && txtBayNumber.Text == "5")
            {
                counter = counter - 1;
                btnBay5.BackColor = Color.BlueViolet;
                btnBay5.Text = "Bay 5\r\nTransfer\r\nAccepted";
            }
            else if (counter == 0 && txtBayNumber.Text == "5")
            {
                pctNotTransfered5.Visible = true;
            }
        }
        private void RequestTimedOut6_Tick(object sender, EventArgs e)
        {
            if (counter > 0 && txtBayNumber.Text == "6")
            {
                counter = counter - 1;
                btnBay6.BackColor = Color.BlueViolet;
                btnBay6.Text = "Bay 6\r\nTransfer\r\nAccepted";
            }
            else if (counter == 0 && txtBayNumber.Text == "6")
            {
                pctNotTransfered6.Visible = true;
            }
        }
        private void RequestTimedOut7_Tick(object sender, EventArgs e)
        {
            if (counter > 0 && txtBayNumber.Text == "7")
            {
                counter = counter - 1;
                btnBay6.BackColor = Color.BlueViolet;
                btnBay6.Text = "Bay 7\r\nTransfer\r\nAccepted";
            }
            else if (counter == 0 && txtBayNumber.Text == "7")
            {
                pctNotTransfered7.Visible = true;
            }     
        }
        private void RequestTimedOut8_Tick(object sender, EventArgs e)
        {
            if (counter > 0 && txtBayNumber.Text == "8")
            {
                counter = counter - 1;
                btnBay8.BackColor = Color.BlueViolet;
                btnBay8.Text = "Bay 8\r\nTransfer\r\nAccepted";
            }
            else if (counter == 0 && txtBayNumber.Text == "8")
            {
                pctNotTransfered8.Visible = true;
            } 
        }
        //Check Bay Info Or/and reset status
        private void btnBay1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want Check Current Patient Information  of the Bay", "This Will Display Bay 1 Current Details",
        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (btnBay1.BackColor == Color.BlueViolet)
                {
                    DayWard d = new DayWard();
                    btnBay1.Text = "Bay 1\r\nReady";
                    btnBay1.BackColor = Color.SeaGreen;
                    d.btnBay1.BackColor = Color.SeaGreen;
                    d.btnBay1.Text = "Bay 1\r\nReady";
                    d.Show();
                }
            }
            else
                MessageBox.Show("The Bay proprties will not be reset");
        }
        private void btnBay2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want Check Current Patient Information  of the Bay", "This Will Display Bay 1 Current Details",
        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (btnBay2.BackColor == Color.BlueViolet)
                {
                    DayWard d = new DayWard();
                    btnBay2.Text = "Bay 2\r\nReady";
                    btnBay2.BackColor = Color.SeaGreen;
                    d.btnBay2.BackColor = Color.SeaGreen;
                    d.btnBay2.Text = "Bay 2\r\nReady";
                    d.Show();
                }
            }
            else
                MessageBox.Show("The Bay proprties will not be reset");
        }
        private void btnBay3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want Check Current Patient Information  of the Bay", "This Will Display Bay 1 Current Details",
         MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (btnBay3.BackColor == Color.BlueViolet)
                {
                    DayWard d = new DayWard();
                    btnBay3.Text = "Bay 3\r\nReady";
                    btnBay3.BackColor = Color.SeaGreen;
                    d.btnBay3.BackColor = Color.SeaGreen;
                    d.btnBay3.Text = "Bay 3\r\nReady";
                    d.Show();
                }
            }
            else
                MessageBox.Show("The Bay proprties will not be reset");
        }
        private void btnBay4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want Check Current Patient Information  of the Bay", "This Will Display Bay 1 Current Details",
       MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (btnBay1.BackColor == Color.BlueViolet)
                {
                    DayWard d = new DayWard();
                    btnBay4.Text = "Bay 4\r\nReady";
                    btnBay4.BackColor = Color.SeaGreen;
                    d.btnBay4.BackColor = Color.SeaGreen;
                    d.btnBay4.Text = "Bay 4\r\nReady";
                    d.Show();
                }
            }
            else
                MessageBox.Show("The Bay proprties will not be reset");
        }
        private void btnBay5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want Check Current Patient Information  of the Bay", "This Will Display Bay 1 Current Details",
         MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (btnBay5.BackColor == Color.BlueViolet)
                {
                    DayWard d = new DayWard();
                    btnBay5.Text = "Bay 5\r\nReady";
                    btnBay5.BackColor = Color.SeaGreen;
                    d.btnBay5.BackColor = Color.SeaGreen;
                    d.btnBay5.Text = "Bay 5\r\nReady";
                    d.Show();
                }
            }
            else
                MessageBox.Show("The Bay proprties will not be reset");
        }
        private void btnBay6_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Do You Want Check Current Patient Information  of the Bay", "This Will Display Bay 1 Current Details",
        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (btnBay6.BackColor == Color.BlueViolet)
                {
                    DayWard d = new DayWard();
                    btnBay6.Text = "Bay 6\r\nReady";
                    btnBay6.BackColor = Color.SeaGreen;
                    d.btnBay6.BackColor = Color.SeaGreen;
                    d.btnBay6.Text = "Bay 6\r\nReady";
                    d.Show();
                }
            }
            else
                MessageBox.Show("The Bay proprties will not be reset");
        }
        private void btnBay7_Click(object sender, EventArgs e)
        {
            if (btnBay7.BackColor == Color.BlueViolet)
            {
                DayWard d = new DayWard();
                btnBay7.Text = "Bay 7\r\nReady";
                btnBay7.BackColor = Color.SeaGreen;
                d.btnBay7.BackColor = Color.SeaGreen;
                d.btnBay7.Text = "Bay 7\r\nReady";
                d.Show();
            }
            else
                MessageBox.Show("The Bay proprties will not be reset");
        }
        private void btnBay8_Click(object sender, EventArgs e)
        {
            if (btnBay8.BackColor == Color.BlueViolet)
            {
                DayWard d = new DayWard();
                btnBay8.Text = "Bay 8\r\nReady";
                btnBay8.BackColor = Color.SeaGreen;
                d.btnBay8.BackColor = Color.SeaGreen;
                d.btnBay8.Text = "Bay 8r\nReady";
                d.Show();
            }
            else
                MessageBox.Show("The Bay proprties will not be reset");
        } 
        private void pctNotTransfered_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want Check Current Patient Information  of the Bay", "This Will Display Bay 1 Current Details",
       MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (pctNotTransfered.Visible==true)
                {
                    DayWard d = new DayWard();
                    btnBay1.Text = "Bay 1\r\nReady";
                    btnBay1.BackColor = Color.SeaGreen;
                    pctNotTransfered.Visible = false;
                    RequestTimedOut.Stop();
                    d.btnBay1.Text = "Bay 1\r\nReady";
                    d.btnBay1.BackColor = Color.SeaGreen;
                    d.RequestTimedOut.Stop();
                    d.Show();
                }
            }
            else
                MessageBox.Show("The Bay proprties will not be reset");
        }
        private void pctNotTransfered2_Click(object sender, EventArgs e)
        {
            if (pctNotTransfered2.Visible == true)
            {
                DayWard d = new DayWard();
                btnBay2.Text = "Bay 2\r\nReady";
                btnBay2.BackColor = Color.SeaGreen;
                pctNotTransfered2.Visible = false;
                RequestTimedOut2.Stop();
                d.btnBay2.Text = "Bay 2\r\nReady";
                d.btnBay2.BackColor = Color.SeaGreen;
                d.RequestTimeOut2.Stop();
                d.Show();
            }
            else
                MessageBox.Show("The Bay proprties will not be reset");
        }
        private void pctNotTransfered3_Click(object sender, EventArgs e)
        {
            if (pctNotTransfered3.Visible == true)
            {
                DayWard d = new DayWard();
                btnBay3.Text = "Bay 3\r\nReady";
                btnBay3.BackColor = Color.SeaGreen;
                pctNotTransfered3.Visible = false;
                RequestTimedOut3.Stop();
                d.btnBay3.Text = "Bay 3\r\nReady";
                d.btnBay3.BackColor = Color.SeaGreen;
                d.RequestTimedOut3.Stop();
                d.Show();
            }
            else
                MessageBox.Show("The Bay proprties will not be reset");
        }
        private void pctNotTransfered4_Click(object sender, EventArgs e)
        {
            if (pctNotTransfered4.Visible == true)
            {
                DayWard d = new DayWard();
                btnBay4.Text = "Bay 4\r\nReady";
                btnBay4.BackColor = Color.SeaGreen;
                pctNotTransfered4.Visible = false;
                RequestTimedOut4.Stop();
                d.btnBay4.Text = "Bay 4\r\nReady";
                d.btnBay4.BackColor = Color.SeaGreen;
                d.RequestTimedOut4.Stop();
                d.Show();
            }
            else
                MessageBox.Show("The Bay proprties will not be reset");
        }
        private void pctNotTransfered5_Click(object sender, EventArgs e)
        {
            if (pctNotTransfered5.Visible == true)
            {
                DayWard d = new DayWard();
                btnBay5.Text = "Bay 5\r\nReady";
                btnBay5.BackColor = Color.SeaGreen;
                pctNotTransfered5.Visible = false;
                RequestTimedOut5.Stop();
                d.btnBay5.Text = "Bay 5\r\nReady";
                d.btnBay5.BackColor = Color.SeaGreen;
                d.RequestTimedOut5.Stop();
                d.Show();
            }
            else
                MessageBox.Show("The Bay proprties will not be reset");
        }
        private void pctNotTransfered6_Click(object sender, EventArgs e)
        {
            if (pctNotTransfered6.Visible == true)
            {
                DayWard d = new DayWard();
                btnBay6.Text = "Bay 6\r\nReady";
                btnBay6.BackColor = Color.SeaGreen;
                pctNotTransfered6.Visible = false;
                RequestTimedOut6.Stop();
                d.btnBay6.Text = "Bay 6\r\nReady";
                d.btnBay6.BackColor = Color.SeaGreen;
                d.RequestTimedOut6.Stop();
                d.Show();
            }
            else
                MessageBox.Show("The Bay proprties will not be reset");
        }
        private void pctNotTransfered7_Click(object sender, EventArgs e)
        {
            if (pctNotTransfered7.Visible == true)
            {
                DayWard d = new DayWard();
                btnBay7.Text = "Bay 7\r\nReady";
                btnBay7.BackColor = Color.SeaGreen;
                pctNotTransfered7.Visible = false;
                RequestTimedOut7.Stop();
                d.btnBay7.Text = "Bay 7\r\nReady";
                d.btnBay7.BackColor = Color.SeaGreen;
                d.RequestTimedOut7.Stop();
                d.Show();
            }
            else
                MessageBox.Show("The Bay proprties will not be reset");
        }

        private void pctNotTransfered8_Click(object sender, EventArgs e)
        {
            if (pctNotTransfered8.Visible == true)
            {
                DayWard d = new DayWard();
                btnBay8.Text = "Bay 8\r\nReady";
                btnBay8.BackColor = Color.SeaGreen;
                pctNotTransfered8.Visible = false;
                RequestTimedOut8.Stop();
                d.btnBay8.Text = "Bay 8\r\nReady";
                d.btnBay8.BackColor = Color.SeaGreen;
                d.RequestTimedOut8.Stop();
                d.Show();
            }
            else
                MessageBox.Show("The Bay proprties will not be reset");
        }
        //logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
//Extra code might be needed
/*
 *if (MessageBox.Show("Do You Want Check Current Patient Information  of the Bay", "This Will Display Bay 1 Current Details",
         MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Bay1 b = new Bay1();
                b.Show();
            }
 */

/*
 * private void SaveToText()
{
    if (cmbBayNo.Text == "1")
    {
        using (StreamWriter obj = new StreamWriter("C:\\Users\\Administrator\\Documents\\bons\\BayNo1.txt"))
        {
            obj.WriteLine(txtPasid.Text);
            obj.WriteLine(" ");
            obj.WriteLine(cmbTitle.Text);
            obj.WriteLine(" ");
            obj.WriteLine(txtFirstName.Text);
            obj.WriteLine(" ");
            obj.WriteLine(txtSurname.Text);
            obj.WriteLine(" ");
            obj.WriteLine(cmbPatientType.Text);
        }
    }
    else if (cmbBayNo.Text == "2")
    {
        using (StreamWriter obj = new StreamWriter("C:\\Users\\Administrator\\Documents\\bons\\BayNo2.txt"))
        {
            obj.WriteLine(txtPasid.Text);
            obj.WriteLine(" ");
            obj.WriteLine(cmbTitle.Text);
            obj.WriteLine(" ");
            obj.WriteLine(txtFirstName.Text);
            obj.WriteLine(" ");
            obj.WriteLine(txtSurname.Text);
            obj.WriteLine(" ");
            obj.WriteLine(cmbPatientType.Text);
        }
    }
    else if (cmbBayNo.Text == "3")
    {
        using (StreamWriter obj = new StreamWriter("C:\\Users\\Administrator\\Documents\\bons\\BayNo3.txt"))
        {
            obj.WriteLine(txtPasid.Text);
            obj.WriteLine(" ");
            obj.WriteLine(cmbTitle.Text);
            obj.WriteLine(" ");
            obj.WriteLine(txtFirstName.Text);
            obj.WriteLine(" ");
            obj.WriteLine(txtSurname.Text);
            obj.WriteLine(" ");
            obj.WriteLine(cmbPatientType.Text);
        }
    }
    else if (cmbBayNo.Text == "4")
    {
        using (StreamWriter obj = new StreamWriter("C:\\Users\\Administrator\\Documents\\bons\\BayNo4.txt"))
        {
            obj.WriteLine(txtPasid.Text);
            obj.WriteLine(" ");
            obj.WriteLine(cmbTitle.Text);
            obj.WriteLine(" ");
            obj.WriteLine(txtFirstName.Text);
            obj.WriteLine(" ");
            obj.WriteLine(txtSurname.Text);
            obj.WriteLine(" ");
            obj.WriteLine(cmbPatientType.Text);
        }
    }
    else if (cmbBayNo.Text == "5")
    {
        using (StreamWriter obj = new StreamWriter("C:\\Users\\Administrator\\Documents\\bons\\BayNo5.txt"))
        {
            obj.WriteLine(txtPasid.Text);
            obj.WriteLine(" ");
            obj.WriteLine(cmbTitle.Text);
            obj.WriteLine(" ");
            obj.WriteLine(txtFirstName.Text);
            obj.WriteLine(" ");
            obj.WriteLine(txtSurname.Text);
            obj.WriteLine(" ");
            obj.WriteLine(cmbPatientType.Text);
        }
    }
    else if (cmbBayNo.Text == "6")
    {
        using (StreamWriter obj = new StreamWriter("C:\\Users\\Administrator\\Documents\\bons\\BayNo6.txt"))
        {
            obj.WriteLine(txtPasid.Text);
            obj.WriteLine(" ");
            obj.WriteLine(cmbTitle.Text);
            obj.WriteLine(" ");
            obj.WriteLine(txtFirstName.Text);
            obj.WriteLine(" ");
            obj.WriteLine(txtSurname.Text);
            obj.WriteLine(" ");
            obj.WriteLine(cmbPatientType.Text);
        }
    }
    else if (cmbBayNo.Text == "7")
    {
        using (StreamWriter obj = new StreamWriter("C:\\Users\\Administrator\\Documents\\bons\\BayNo7.txt"))
        {
            obj.WriteLine(txtPasid.Text);
            obj.WriteLine(" ");
            obj.WriteLine(cmbTitle.Text);
            obj.WriteLine(" ");
            obj.WriteLine(txtFirstName.Text);
            obj.WriteLine(" ");
            obj.WriteLine(txtSurname.Text);
            obj.WriteLine(" ");
            obj.WriteLine(cmbPatientType.Text);
        }
    }
    else if (cmbBayNo.Text == "8")
    {
        using (StreamWriter obj = new StreamWriter("C:\\Users\\Administrator\\Documents\\bons\\BayNo8.txt"))
        {
            obj.WriteLine(txtPasid.Text);
            obj.WriteLine(" ");
            obj.WriteLine(cmbTitle.Text);
            obj.WriteLine(" ");
            obj.WriteLine(txtFirstName.Text);
            obj.WriteLine(" ");
            obj.WriteLine(txtSurname.Text);
            obj.WriteLine(" ");
            obj.WriteLine(cmbPatientType.Text);
        }
    }
}*/