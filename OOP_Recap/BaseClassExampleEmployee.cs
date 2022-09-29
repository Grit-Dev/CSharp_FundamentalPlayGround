using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalPlayGround.OOP_Recap
{
    abstract class BaseClassExampleEmployee
    {
        public string name = "Hello";

        //Needs to be empty
        public abstract void PrintNameExample();


    }
}


//For Virtual key word if you do want to use this class instead of hiding it using the base 
/*
namespace FundamentalPlayGround.OOP_Recap
{
    internal class BaseClassExampleEmployee
    {
        public string name = "Hello";

        //Needs to be empty
        public virtual void PrintNameExample()
        {
            Console.WriteLine("Hello");
        }


    }
}

*/