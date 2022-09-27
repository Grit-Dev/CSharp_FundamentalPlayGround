//
//
//Name: Paul McGinley 
//Date: 07/09/2022
//Description: Fundamental learning on classes, objects, constructors, properties, methods, and more
//Add extra stuff and progressing through chapters
//
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalPlayGround
{
    public class Employee
    {

        //Fields
        private const int MIMINALHOURSWORKED = 1;
        private string _FirstName = "";
        private string _LastName = "";
        private string _Email = "" ;
        private double _hoursWorked;
        private double _Wage;
        private double _HourlyRate;
        private DateTime _Birthday;


        //Properties

        public string FirstName {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }  
        }

        public string Email
        { 
            get { return _Email; }
            set { _Email = value; }
        }

        public double HoursWorked {
            get {return _hoursWorked; }
            set { _hoursWorked = value;}
        }

        public double Wage
        {
            get { return _Wage; }
            set { _Wage = value; }
        }

        public double HourlyRate
        {
            get { return _HourlyRate; }
            set { _HourlyRate = value; }
        }

        public DateTime Birthday
        {
            get { return _Birthday; }
            set { _Birthday = value; }
        }

        public double MinimalHourWorked
        {
            get { return MIMINALHOURSWORKED; }
        }

        public bool ResetBalance
        {
            get { return _ResetBalance; }
        }


        //Constructors
        //Example only for me to refresh my memory

        public Employee()
        {
            //Always Have an empty constructor
        }
        public Employee(string pFirstName, string pLastName, string pEmail)
        {
            _FirstName = pFirstName;
            _LastName = pLastName;
            _Email = pEmail;
        }


        /// <summary>
        /// Should Put in a Try catch here or parsed method to ensure program would not break if 
        /// user input was not a double.
        /// </summary>
        /// <param name="pHoursWorked"></param>
        /// <param name="pHourlyRate"></param>
        /// <returns></returns>
        /// 

        //Methods
        public double CalculateRecievedWages(double pHoursWorked , double pHourlyRate)
        {
            

            //Not Needed but I want it in
            HourlyRate = pHourlyRate;
            HoursWorked = pHoursWorked;

            return (pHourlyRate * pHoursWorked);
        }

        public void PerformWorked()
        {
            HoursWorked++;
        }

        public void ResetHoursWorked()
        {
            HoursWorked = 0;
        }
    }
}
