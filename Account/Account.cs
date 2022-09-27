using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalPlayGround.Account
{
    public class Account
    {
        //Field
        private string _AccountNumber = ""; 
        
        //Properties
        public string AccountNumber
        {
            get { return _AccountNumber; }
            set { _AccountNumber = value; }

        }

        public void TheAccountNumber()
        {
            Console.WriteLine($"{AccountNumber}");
        }

    }
}
