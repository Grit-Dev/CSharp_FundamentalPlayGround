using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalPlayGround.Account
{
    public class Customer
    {
        private int _CustomerID; 
        private string _Name = ""; 
        private string _Email = "";

        public int CutomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

    }
}
