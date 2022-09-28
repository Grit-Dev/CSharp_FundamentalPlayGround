using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FundamentalPlayGround.OOP_Recap
{
    internal class DerivedClassExampleManager : BaseClassExampleEmployee
    {
        public override void PrintNameExample()
        {
            Console.WriteLine(name);
        }

    }
}
