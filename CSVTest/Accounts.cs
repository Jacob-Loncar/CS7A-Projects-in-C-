using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVTest
{
    class Accounts
    {
        private string accountNumber;

        public string MyAccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        private string accountName;

        public string MyName
        {
            get { return accountName; }
            set { accountName = value; }
        }


        private string accountBal;

        public string MyBal
        {
            get { return accountBal; }
            set { accountBal = value; }
        }
    }
}
