using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSweep
{
    static class UserInterface
    {

        static void MainMenu()
        {
            Console.WriteLine("What would you like to do? 1. Register a contestant");
            string menuOption = Console.ReadLine();
            switch (menuOption)
            {
                case "1":
                    GetContestant();
                    break;
                default:
                    MainMenu();
                    break;
            }


        }

        public Contestant GetContestant(Contestant contestant)
        {
            //Contestant contestant = new Contestant();


            Console.WriteLine("First Name?");
            contestant.firstName = Console.ReadLine();

            Console.WriteLine("Last Name?");
            contestant.lastName = Console.ReadLine();

            Console.WriteLine("Email?");
            contestant.emailAddress = Console.ReadLine();

            contestant.regNumber = contestant.idNumber;
            contestant.idNumber++;

            return contestant;
        }


    }
}
