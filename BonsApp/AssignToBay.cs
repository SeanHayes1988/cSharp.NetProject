using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonsApp
{
  public  class AssignToBay 
    {
      //  public event EventHandler ChangeDataAll;

        DateTime now = DateTime.Now;

        private string title, firstName, surname, patientType, bayNumber, requestedTime, requestedDate, transferRequestTime, transferRequestDate, transfer, delay;
        private int estimateTime;

        public AssignToBay()
        {
            transfer = "Yes";
            estimateTime = 3;
            requestedTime = now.ToString("HH:mm:ss");
            requestedDate= now.ToString("dd/MM/yyyy");
            transferRequestTime = now.ToString("HH:mm:ss");
            transferRequestDate = now.ToString("dd/MM/yyyy");
            delay = "Pending, Non as of Yet";
        }
        public AssignToBay(string title, string firstName, string surname, string patientType, 
           string bayNumber, string requestedTime, string requestedDate, string transferRequestTime, string transferRequestDate, int estimateTime, string transfer, string delay)
        {
            this.title = title;
            this.firstName = firstName;
            this.surname = surname;
            this.patientType = patientType;
            this.bayNumber = bayNumber;
            this.requestedTime = requestedTime;
            this.requestedDate= requestedDate;
            this.transferRequestTime = transferRequestTime;
            this.transferRequestDate = transferRequestDate;
            this.estimateTime = estimateTime;
            this.transfer = transfer;
            this.delay = delay;
        }

        public String Title
        {
            get { return title; }
            set  { }
        }

        public String FirstName
        {
            get { return firstName; }
            set  { }
        }

        public String Surname
        {
            get { return surname; }
            set { }
        }

        public String PatientType
        {
            get { return patientType; }
            set { }
        }

        public String BayNumber
        {
            get { return bayNumber; }
            set { }
        }

        public String Transfer
        {
            get { return transfer; }
            set{ }
        }

        public int EstimateTime
        {
            get { return estimateTime; }
            set { }
        }

        public String RequestedTime
        {
            get { return requestedTime; }
            set { }
        }

        public String RequestedDate
        {
            get { return requestedDate; }
            set { }
        }

        public String TransferRequestTime
        {
            get { return transferRequestTime; }
            set { }
        }

        public String TransferRequestDate
        {
            get { return transferRequestDate; }
            set { }
        }

        public String Delay
        {
            get { return delay; }
            set{ }
        }
    }
    
}
