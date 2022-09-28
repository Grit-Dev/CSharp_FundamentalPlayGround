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

namespace FundamentalPlayGround.HR
{
    public class Employee
    {

        //Fields
        private const int MIMINALHOURSWORKED = 1;
        private string _FirstName = "";
        private string _LastName = "";
        private string _Email = "";
        private double _hoursWorked;
        private double _Wage;
        private double _HourlyRate;
        private DateTime _Birthday;

        private EmployeeType _EmployeeType;

        //Properties

        public EmployeeType EmployeeType
        {
            get { return _EmployeeType; }
            set { _EmployeeType = value; }
        }

        public string FirstName
        {
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

        public double HoursWorked
        {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
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
        public double CalculateRecievedWages(double pHoursWorked, double pHourlyRate)
        {


            //Not Needed but I want it in
            HourlyRate = pHourlyRate;
            HoursWorked = pHoursWorked;

            return pHourlyRate * pHoursWorked;
        }


        /// <summary>
        /// I know validations and calculations should be abstracted and separated elsewhere
        /// This code is purely to test fundamentals and the love of coding :). 
        /// 
        /// I also made this private as it does need to be called at all. 
        /// I can call it in the method. It does not make sense to have something similar
        /// This can be confusing.  
        /// </summary>
        /// <returns></returns>
        private int ValidateHowManyEmployeesChecker()
        {
            int howManyUsersUserInput = 0;
            bool isTrue = true;

            while (isTrue)
            {

                try
                {
                    Console.WriteLine("How many employees would you like to register? ");
                    Console.WriteLine("Please ensure you enter in a positive number:");
                    howManyUsersUserInput = int.Parse(Console.ReadLine());
                    isTrue = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Sorry you did not enter in a digit number. Please try again \n");


                }
            }

            return howManyUsersUserInput;

        }

        public int GetHowManyEmployeesToAddValidation()
        {
            bool isTrue = true;
            Employee employeeOne = new Employee();
            int answer = 0;

            do
            {

                answer = employeeOne.ValidateHowManyEmployeesChecker();

                if (answer <= 0)
                {
                    Console.WriteLine("You have not entered a positive number.");
                    Console.WriteLine("Please try again \n");

                }
                else
                {
                    isTrue = false;
                }

            }
            while (isTrue);

            Console.WriteLine();
            Console.WriteLine("Answer should be 5 in digit form:");
            Console.WriteLine($"The Answer: {answer}");
            Console.WriteLine($"The type should be an int: {answer.GetType()} \n\n");

            return answer;


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
