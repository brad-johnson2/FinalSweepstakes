using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSweep
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int regNumber;
        public int idNumber = 1000;


        public static Contestant NewContestant()
        {
            Contestant contestant = new Contestant();
            UserInterface.GetContestant(contestant);
            return contestant;
        }
    }
}
