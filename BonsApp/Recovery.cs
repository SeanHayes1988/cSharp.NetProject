using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonsApp
{
    public partial class Recovery : Form
    {
        //Recovery Ward Interface
        //variables 
        static int pasid = 1; // Patient id 
        static string transfer = "No"; //ask to send patient down
        static string estimateTime = "Pending";

        public Recovery()
        {
            InitializeComponent();
            DayWard dw = new DayWard();
            //  var task = IncrementId();
        }
        //get data from pasid textbox
        public string Pasid
        {
            get
            {
                return pasid.ToString();
            }
        }
        //get data from surname textbox
        public string Title
        {
            get
            {
                return cmbTitle.Text;
            }
        }
        // get data from name textbox
        public string FirstName
        {
            get
            {
                return txtFirstName.Text;
            }
        }
        // get data from name textbox
        public string Surname
        {
            get
            {
                return txtSurname.Text;
            }
        }
        //get patient type 
        public string PatientType
        {
            get
            {
                return cmbPatientType.Text;
            }
        }
        //get Bay Number
        public string BayNumber
        {
            get
            {
                return cmbBayNo.Text;
            }
        }
        //get tranfer data  
        public string TransferPatient
        {
            get
            {
                return transfer.ToString();
            }
        }
        //set updated Transfer
        public string Transfer
        {
            set
            {
                txtDaywardTransfer.Text = value;
            }
        }
        //set updated estimate time
        public string EstimateTime
        {
            /*  get
              {
                  return estimateTime.ToString();
              }
              */
            set {
                txtEstimateTime.Text = value;
            }
        }
        //get and set the value for the Transfer of a Patient 
        private void Time() {
            DateTime now = DateTime.Now;//get and set current time 
            Console.WriteLine(now);
            txtTimeStamp.Text = now.ToString("HH:mm:ss");//trim to time
            txtBoxDate.Text = now.ToString("dd/MM/yyyy");//trim to date
        }
        //Load required Inforamtion when opened
        private void Recovery_Load(object sender, EventArgs e)
        {
            try
            {
                var ConnectionString = "mongodb+srv://testBonSecours:5isqbv73@bonssecours1-anhjy.mongodb.net/test";
                var client = new MongoClient(ConnectionString);
                var db = client.GetDatabase("testBonSecours");
                var collection = db.GetCollection<BsonDocument>("Recovery");

                //read the pasid data and increment the number
                var list = collection.Find(new BsonDocument()).ToList();
                foreach (var dox in list)
                {
                    Console.WriteLine(dox);

                    pasid++;
                    pasid = int.Parse(dox["Pasid"].ToString()) + 1;
                    txtPasid.Text = pasid.ToString();
                    Console.WriteLine(pasid);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could Not Load Data");
            }
        }
        /*when adding new data to the database this makes sure that the data is added correctly 
         *Warns the user before entering, If there is missing data the user is let know*/
        private void UpdateInfo()
        {
            if (MessageBox.Show("Are You Sure You Want to Send the Request?", "IS THE INFORMATION ENTERED CORRECT!!!",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                MessageBox.Show("Information Enterd and Request Sent", "Information Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var insert = btnSendAsync();
            }
            else {
                if (cmbBayNo.Text == "1")
                {
                    btnOccupy1.Text = "Unoccupied";
                    btnOccupy1.BackColor = Color.Green;
                }
                else if (cmbBayNo.Text == "2")
                {
                    btnOccupy2.Text = "Unoccupied";
                    btnOccupy2.BackColor = Color.Green;
                }
                else if (cmbBayNo.Text == "3")
                {
                    btnOccupy3.Text = "Unoccupied";
                    btnOccupy3.BackColor = Color.Green;
                }
                else if (cmbBayNo.Text == "4")
                {
                    btnOccupy4.Text = "Unoccupied";
                    btnOccupy4.BackColor = Color.Green;
                }
                else if (cmbBayNo.Text == "5")
                {
                    btnOccupy5.Text = "Unoccupied";
                    btnOccupy5.BackColor = Color.Green;
                }
                else if (cmbBayNo.Text == "6")
                {
                    btnOccupy6.Text = "Unoccupied";
                    btnOccupy6.BackColor = Color.Green;
                }
                else if (cmbBayNo.Text == "7")
                {
                    btnOccupy7.Text = "Unoccupied";
                    btnOccupy7.BackColor = Color.Green;
                }
                else if (cmbBayNo.Text == "8")
                {
                    btnOccupy8.Text = "Unoccupied";
                    btnOccupy8.BackColor = Color.Green;
                }
                txtTimeStamp.Text = "";
                txtBoxDate.Text = "";
                MessageBox.Show("Request is Canceled", "Information Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /*for the information to be updated there needs to be the required data entered first
          otherwise the data will not entered*/
        private void ChangeBayUnoccupied()
        {
            //if the following isn't entered into the requred fields the a warning will be issued 
            if (cmbTitle.Text != "" && txtFirstName.Text != "" && txtSurname.Text != "" && cmbPatientType.Text != "") {
                if (btnOccupy1.Text == "Unoccupied" && cmbBayNo.Text == "1")//if these rerquirments are meet then do this or the next statement
                {
                    btnOccupy1.Text = "Occupied";
                    btnOccupy1.BackColor = Color.DarkOrange;
                    UpdateInfo();
                }

                else if (btnOccupy2.Text == "Unoccupied" && cmbBayNo.Text == "2")
                {
                    btnOccupy2.Text = "Occupied";
                    btnOccupy2.BackColor = Color.DarkOrange;
                    UpdateInfo();
                }
                else if (btnOccupy3.Text == "Unoccupied" && cmbBayNo.Text == "3")
                {
                    btnOccupy3.Text = "Occupied";
                    btnOccupy3.BackColor = Color.DarkOrange;
                    UpdateInfo();
                }
                else if (btnOccupy4.Text == "Unoccupied" && cmbBayNo.Text == "4")
                {
                    btnOccupy4.Text = "Occupied";
                    btnOccupy4.BackColor = Color.DarkOrange;
                    UpdateInfo();
                }
                else if (btnOccupy5.Text == "Unoccupied" && cmbBayNo.Text == "5")
                {
                    btnOccupy5.Text = "Occupied";
                    btnOccupy5.BackColor = Color.DarkOrange;
                    UpdateInfo();
                }
                else if (btnOccupy6.Text == "Unoccupied" && cmbBayNo.Text == "6")
                {
                    btnOccupy6.Text = "Occupied";
                    btnOccupy6.BackColor = Color.DarkOrange;
                    UpdateInfo();
                }
                else if (btnOccupy7.Text == "Unoccupied" && cmbBayNo.Text == "7")
                {
                    btnOccupy7.Text = "Occupied";
                    btnOccupy7.BackColor = Color.DarkOrange;
                    UpdateInfo();
                }
                else if (btnOccupy8.Text == "Unoccupied" && cmbBayNo.Text == "8")
                {
                    btnOccupy8.Text = "Occupied";
                    btnOccupy8.BackColor = Color.DarkOrange;
                    UpdateInfo();
                }
                //if the requirments aren't meet 
                else
                {
                    MessageBox.Show("No Bay Number Chosen! or Already Occupied", "INFORMATION NOT ENTERED CORRECTLY!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTimeStamp.Text = "";
                    txtBoxDate.Text = "";
                }
            }
            //If any or all the requirments not meet then send this message back
            else
            {
                MessageBox.Show("Information Required Isn't Entered", "One Or Many Required Fields aren't Entered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTimeStamp.Text = "";
                txtBoxDate.Text = "";
            }
        }
        //All user to resaet the bay numbers when patient is transfered to the dayward
        private void ChangeBayOccupied()
        {

            if (MessageBox.Show("Are You Sure You Want Reset the Bay Number Occupy Status", "Important Notice",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (btnOccupy1.Text == "Occupied")
                {
                    btnOccupy1.Text = "Unoccupied";
                    btnOccupy1.BackColor = Color.Green;
                }

                else if (btnOccupy2.Text == "Occupied")
                {
                    btnOccupy2.Text = "Unoccupied";
                    btnOccupy2.BackColor = Color.Green;
                }
                else if (btnOccupy3.Text == "Occupied")
                {
                    btnOccupy3.Text = "Unoccupied";
                    btnOccupy3.BackColor = Color.Green;
                }
                else if (btnOccupy4.Text == "Occupied")
                {
                    btnOccupy4.Text = "Unoccupied";
                    btnOccupy4.BackColor = Color.Green;
                }
                else if (btnOccupy5.Text == "Occupied")
                {
                    btnOccupy5.Text = "Unoccupied";
                    btnOccupy5.BackColor = Color.Green;
                }
                else if (btnOccupy6.Text == "Occupied")
                {
                    btnOccupy6.Text = "Unoccupied";
                    btnOccupy6.BackColor = Color.Green;
                }
                else if (btnOccupy7.Text == "Occupied")
                {
                    btnOccupy7.Text = "Unoccupied";
                    btnOccupy7.BackColor = Color.Green;
                }
                else if (btnOccupy8.Text == "Occupied")
                {
                    btnOccupy8.Text = "Unoccupied";
                    btnOccupy8.BackColor = Color.Green;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DayWard dw = new DayWard();
            txtDaywardTransfer.Text = transfer;
            txtEstimateTime.Text = estimateTime;
            dw.Pasid = Pasid;
            dw.Title = Title;
            dw.FirstName = FirstName;
            dw.Surname = Surname;
            dw.PatientType = PatientType;
            dw.BayNumber = BayNumber;
            dw.cmbRecovery.Text = txtDaywardTransfer.Text;
            dw.txtEstimateTime.Text = txtEstimateTime.Text;
            Time();
            ChangeBayUnoccupied();
            Save();
            // dw.Show();
        }
        // Insert data to cloud and open instance of day ward and send data
        private async Task btnSendAsync()
        {
            try
            {
                var client = new MongoClient("mongodb+srv://testBonSecours:5isqbv73@bonssecours1-anhjy.mongodb.net/test");
                var database = client.GetDatabase("testBonSecours");
                var collection = database.GetCollection<BsonDocument>("Recovery");

                var document = new BsonDocument
                    {
                        {"Pasid", pasid},
                        {"Title", cmbTitle.Text},
                        {"First Name", txtFirstName.Text},
                        {"Surname", txtSurname.Text },
                        {"Patient Type", cmbPatientType.Text},
                        {"Bay Number", cmbBayNo.Text},
                        {"Request Send Time", txtTimeStamp.Text},
                        {"Request Send Date", txtBoxDate.Text},
                        {"Estimate Time",estimateTime},
                        {"Transfer",transfer},
                        {"Reason for Delay","Pending, Non as of Yet"}
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
                Console.WriteLine(pasid + " Rawaaaarrrghhh!!!");
                Console.ReadLine();

                await collection.InsertOneAsync(document);

            }
            catch (Exception)
            {
                MessageBox.Show("No Connection");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Show();
        }

        private void btnOccupy1_Click(object sender, EventArgs e)
        {
            if (btnOccupy1.Text == "Occupied")
                ChangeBayOccupied();
        }

        private void btnOccupy2_Click(object sender, EventArgs e)
        {
            if (btnOccupy2.Text == "Occupied")
                ChangeBayOccupied();
        }

        private void btnOccupy3_Click(object sender, EventArgs e)
        {
            if (btnOccupy3.Text == "Occupied")
                ChangeBayOccupied();
        }

        private void btnOccupy4_Click(object sender, EventArgs e)
        {
            if (btnOccupy4.Text == "Occupied")
                ChangeBayOccupied();
        }

        private void btnOccupy5_Click(object sender, EventArgs e)
        {
            if (btnOccupy5.Text == "Occupied")
                ChangeBayOccupied();
        }

        private void btnOccupy6_Click(object sender, EventArgs e)
        {
            if (btnOccupy6.Text == "Occupied")
                ChangeBayOccupied();
        }

        private void btnOccupy7_Click(object sender, EventArgs e)
        {
            if (btnOccupy7.Text == "Occupied")
                ChangeBayOccupied();
        }

        private void btnOccupy8_Click(object sender, EventArgs e)
        {
            if (btnOccupy8.Text == "Occupied")
                ChangeBayOccupied();
        }
        private void Save()
        {
            // Create a file to write to.
            string createText = "Hello and Welcome" + Environment.NewLine;
            File.WriteAllText("C:\\Users\\Administrator\\Documents\\bons", createText);

            // Open the file to read from.
            string readText = File.ReadAllText("C:\\Users\\Administrator\\Documents\\bons");
        }

        private void Test() {
            string test;
            
        }

        
    }
}

