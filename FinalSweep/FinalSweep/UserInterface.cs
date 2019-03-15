using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSweep
{
    public static class UserInterface
    {

        public static void MainMenu()
        {
            Console.WriteLine("What would you like to do? 1. Register a contestant 2. Start a Sweepstakes");
            string menuOption = Console.ReadLine();
            switch (menuOption)
            {
                case "1":
                    Contestant.NewContestant();
                    break;
                case "2":
                    Sweepstakes.StartSweepstakes();
                    break;
                default:
                    MainMenu();
                    break;
            }


        }

      
        static void GetContestant(Contestant contestant)
        {
            

            Console.WriteLine("First Name?");
            contestant.firstName = Console.ReadLine();

            Console.WriteLine("Last Name?");
            contestant.lastName = Console.ReadLine();

            Console.WriteLine("Email?");
            contestant.emailAddress = Console.ReadLine();

            contestant.regNumber = contestant.idNumber;
            contestant.idNumber++;
            
        }


    }
}
