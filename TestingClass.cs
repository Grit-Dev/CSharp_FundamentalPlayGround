using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalPlayGround
{
    public class TestingClass
    {
        public int TwoPlusTwo()
        {
            return 2 + 2;
            
        }

        public void ChapterOneToThree()
        {
            //Console.WriteLine("Hello World");

            /*            int x = 5;
            int y = 10;

            int z = x + y;

            Console.WriteLine(z);
            Console.WriteLine("Hello, World!");

            var testClass = new TestClass();


            Console.WriteLine();

            Console.WriteLine("Testing a void method using a class!");
            testClass.HelloWorld();

            Console.WriteLine();
            Console.WriteLine("Testing a class labeled two plus two");
            Console.WriteLine(testClass.TwoPlusTwo());

*/

            //Working with DateTime and Date only
            /*
                        DateTime exitDate = new DateTime(2022, 09, 26);
                        DateTime startDate = new DateTime(2022, 09, 01);
                        DateTime hireDate = new DateTime(01, 01, 2022);

                        Console.WriteLine("Hello World");

            */

            double aDouble = 2.0;
            int aInt = 1;
            int ans = 0;

            ans = aInt + (int)aDouble;

            Console.WriteLine($"The answer is: {ans}");


        }

        public  void TestingBoolValueWithAge65()
        {
            int age = 65;

            bool isItTrue = (age == 65) && (age > 64);

            Console.WriteLine($"Testing bool value if age is 65 and greater than 64: {isItTrue} \n");
        }

        public  void SimpleIfStatementFundamental()
        {
            int userInput = 0;

            Console.WriteLine("Please enter in the age you are: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput > 65)
            {
                Console.WriteLine("You shall Pass");
            }
            else if (userInput < 65 && userInput > 0)
            {
                Console.WriteLine("You shall not pass");
            }
            else
            {
                Console.WriteLine("You have no entered in a digit or positive number");
            }
        }

        public  void SwitchStatementFundamentals()
        {
            const string NAMEONE = "PAUL";
            const string NAMETWO = "PAUL2";
            const string NAMETHREE = "PAUL3";
            const string NAMEFOUR = "PAUL4";
            string userInput = "";

            Console.WriteLine("What is your name: ");
            userInput = Console.ReadLine().ToString().ToUpper();

            switch (userInput)
            {
                case NAMEONE:
                    Console.WriteLine($"Your name is {NAMEONE} \n");
                    break;

                case NAMETWO:
                    Console.WriteLine($"Your name is {NAMETWO} \n");
                    break;

                case NAMETHREE:
                    Console.WriteLine($"Your name is {NAMETHREE} \n");
                    break;

                case NAMEFOUR:
                    Console.WriteLine($"Your name is {NAMEFOUR} \n");
                    break;

                default:

                    Console.WriteLine("The name does not seem to appear in the database");
                    break;
            }

        }

        public  void SimpleWhileLoopIteration()
        {


        }

        public  void IteratonsFundamentals()
        {
            int counter = 0;

            Console.WriteLine("Testing simple counter: \n");

            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

        }

        public  void DoWhileLoopFundamental()
        {
            Console.WriteLine("A simple do while loop: ");

            const int DEFCONNUMBER = 0;
            int counter = 10;
            const int MINUSONE = 0;

            do
            {
                Console.WriteLine($"CountDown Timer: [{counter}]");
                counter--;

                //OR: counter = counter - 1; 
            }
            while (counter != DEFCONNUMBER - MINUSONE);
            //Wanted to showcase the zero in my testing.

            Console.WriteLine("The countdown timer has reached zero \n");

        }

        public  void ForLoopFundamentalsBasic()
        {

            //To Do: 
            Console.WriteLine("Testing Forloop: ");

            int counter = 0;

            for (counter = 0; counter <= 10; counter++)
            {
                Console.WriteLine($"The counter is currently at: [{counter}] \n");
            }
        }

        public  void TestingForEachLoop()
        {
            int[] myIntArray = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            string[] myStringArray = { "This", "Is", "A", "Sentence" };


            Console.WriteLine("Testing myIntArray: ");
            foreach (var digits in myIntArray)
            {
                Console.WriteLine(digits);

            }
            Console.WriteLine();

            Console.WriteLine("Testing myStringArray: ");
            foreach (var stringInTheArray in myStringArray)
            {
                Console.WriteLine(stringInTheArray);
            }

            Console.WriteLine();
        }

        public  void BubbleSort()
        {
            Random random = new Random();
            int randomNumberHolder = 0;
            int[] myIntArray = new int[10];
            int counterOne = 0;
            int counterTwo = 0;
            int tempHolder = 0;

            Console.WriteLine("Create a bubblesort: \n");

            //Part One: 
            for (counterOne = 0; counterOne < myIntArray.Length; counterOne++)
            {
                randomNumberHolder = random.Next(0, 50 + 1);

                myIntArray[counterOne] = randomNumberHolder;
            }

            //Part Two: 
            Console.WriteLine("Testing to see if array has been populated: ");
            foreach (var items in myIntArray)
            {
                Console.WriteLine(items);
            }

            //part Three
            //The bubble Sort@ 

            Console.WriteLine();

            Console.WriteLine("The Bubble Sort loop: ");
            for (counterOne = 0; counterOne < myIntArray.Length; counterOne++)
            {
                Console.WriteLine($"counterOne: [{myIntArray[counterOne]}]");

                for (counterTwo = 0; counterTwo < myIntArray.Length - 1; counterTwo++)
                {
                    Console.WriteLine(myIntArray[counterTwo]);

                    if (myIntArray[counterTwo] > myIntArray[counterTwo + 1])
                    {
                        tempHolder = myIntArray[counterTwo + 1];
                        myIntArray[counterTwo + 1] = myIntArray[counterOne];
                        myIntArray[counterTwo] = tempHolder;
                    }

                }
            }

            Console.WriteLine("Bubblesort: ");
            foreach (var item in myIntArray)
            {
                Console.WriteLine(item);
            }
        }

        public  void FundementalObjectCreatedFromAnotherClassFromFile()
        {
            var testingAClassExample = new TestingClass();

            Console.WriteLine($"Testing a return type from a Object created" +
                $"in abstracted class: [{testingAClassExample.TwoPlusTwo()}]");


        }

        public  void SwappingVariables()
        {
            int a = 3;
            int b = 2;
            int temp = 0;

            temp = a;
            a = b;
            a = temp;

            Console.WriteLine($"A should be 3 {a}");
            Console.WriteLine($"B should be 2 {b}");
        }

        public  void ComparingStringTypes()
        {

            string nameOne = "Paul";
            string nameTwo = "paul";
            string nameEquals = "Paul";


            bool isNotTrue = nameOne == nameTwo;
            bool isTrue = nameOne == nameEquals;

            //In C#, Equals(String, String) is a String method.
            //It is used to determine whether two String objects have the same value or not. 
            bool isTrueTwo = nameOne.Equals(nameEquals);


            Console.WriteLine($"nameOne and nameTwo should not be True: {isNotTrue}");
            Console.WriteLine($"nameOne and nameEquals should be True: {isTrue} ");
            Console.WriteLine($"NameOne.Equals(nameEquals) Should be true: {isTrueTwo}");
        }

        public  void UsingATryParseWithWhileLoopFundamentals()
        {
            //parsing a string with some while loops thrown in

            string userInput = "";
            int valueCheckedAndIsInt = 0;
            bool isTrue = true;

            while (true)
            {
                Console.WriteLine("Please enter in a value between 1 and 10:");
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out valueCheckedAndIsInt))
                {
                    if (valueCheckedAndIsInt < 1 || valueCheckedAndIsInt > 10)
                    {
                        Console.WriteLine("You need to enter it a value in digit form");
                        Console.WriteLine("Or enter in between 1 - 10. Please try again");

                    }
                    else
                    {
                        break;
                        //
                    }
                }
                else
                {
                    Console.WriteLine("You have not entered in a digit. Please try again \n");

                }
            }

            Console.WriteLine($"Your value is: {valueCheckedAndIsInt}");

        }
        public void ParsingAStringIntoADateTimeAndString()
        {
            string hireDateTime = "27/09/2022";

            DateTime hireDate = DateTime.Parse(hireDateTime);


            Console.WriteLine($"Testing a string being parsed into a date and time: {hireDate.ToShortDateString()} ");
        }

    }
}
