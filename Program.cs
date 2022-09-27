﻿/*
 * Name: Paul McGinley
 * Date: 26/09/2022
 * Description: Going through C# Fundamentals in the Plursight course C#10  Fundamentals
 * 
 */

using FundamentalPlayGround;
using System.Diagnostics.Metrics;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml;

namespace CSharpFundamentals
{
    public class EmployeeTestingClassBeforeRealClass
    {
        //Fields
        private string _FirstName = "";
        private int _age;



        //Properties
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public int Age {
            get { return _age; }
            set { _age = value; } 
        }



        public void PerformWork()
        {
            Console.WriteLine(FirstName);
            
        }


    }
    public class Program
    {
        public static void ChaptersOneTwoSixMethods()
        {
            var ChaptersOneToSix = new TestingClass();

            //One
            ChaptersOneToSix.TwoPlusTwo();
            ChaptersOneToSix.ChapterOneToThree();
            ChaptersOneToSix.TestingBoolValueWithAge65();
            ChaptersOneToSix.SimpleIfStatementFundamental();
            ChaptersOneToSix.SwitchStatementFundamentals();
            ChaptersOneToSix.IteratonsFundamentals();
            ChaptersOneToSix.SimpleWhileLoopIteration();
            ChaptersOneToSix.IteratonsFundamentals();
            ChaptersOneToSix.DoWhileLoopFundamental();
            ChaptersOneToSix.ForLoopFundamentalsBasic();
            ChaptersOneToSix.TestingForEachLoop();
            ChaptersOneToSix.BubbleSort();
            ChaptersOneToSix.FundementalObjectCreatedFromAnotherClassFromFile();
            ChaptersOneToSix.ComparingStringTypes();
            ChaptersOneToSix.UsingATryParseWithWhileLoopFundamentals();
            ChaptersOneToSix.ParsingAStringIntoADateTimeAndString();


        }


        /// <summary>
        /// These are the testing methods you are using at the moment to check the employee class
        /// Move these later on after completed on what you are doing
        /// </summary>
        public static void TestingCreatingEmployeeObjectWithname()
        {

            var employeeOne = new EmployeeTestingClassBeforeRealClass();
            employeeOne.FirstName = "Paul McGinley";


            Console.WriteLine(employeeOne.FirstName);


        }

        public static void TestingIfReadOnlyReturnsMinimalsHoursWorksWorkedShouldBeOne()
        {

            var employeeOne = new Employee();

            var oneHours = employeeOne.MinimalHourWorked;

            Console.WriteLine($"Testing to see if this returns one hours: {oneHours} ");

        }
/*
        public static void TestingIfResetBalancePropWorkInEmployeeClass()
        {

            //Testing if book get variable will return true
            bool decision = false;

            Employee employeeOneTest = new Employee();

            decision = employeeOneTest.ResetBalance;

            Console.WriteLine($"This should return true: {decision} ");


        }*/

        public static void TestingIfEmployeeconstructorWillReturnParamaetersPassedinToIt()
        {
            //Testing to see if my Constructor returns what I set it as: 
            var employeeOne = new Employee("Paul", "McGinley", "paulmcginley16@outlook.com");

            Console.WriteLine($"EmployeeOne firstName: {employeeOne.FirstName}");
            Console.WriteLine($"EmployeeOne lastName: {employeeOne.LastName}");
            Console.WriteLine($"EmployeeOne Email: {employeeOne.Email}");

        }

        public static void TestingifCalculatedWageWillReturn100()
        {
            double testHourlyRate = 10.00;
            double testHoursWorked = 10;

            var employeeOne = new Employee();

            Console.WriteLine("Testing if employee wages are correct: ");
            Console.WriteLine(employeeOne.CalculateRecievedWages(testHourlyRate, testHoursWorked));

        }


        public static void Main(string[] args)
        {
            

        }//Main 

    } //Class
} //Name-space