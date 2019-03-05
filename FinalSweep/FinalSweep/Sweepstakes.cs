using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSweep
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        Contestant contestant = new Contestant();

        static Sweepstakes StartSweepstakes()
        {
            Sweepstakes sweepstake = new Sweepstakes();
            
            return sweepstake;
        }

        public Sweepstakes(string name)
        {
            

            this.name = name;

            
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.regNumber, contestant);

        }



        public string PickWinner()
        {
            Random rnd = new Random();
            int winningNumber = rnd.Next(1000, contestants.Count + 1000);

            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Key == winningNumber)
                {
                    string winner = ($"{contestant.Value}");


                        //contestant.Value.firstName + " " + contestant.Value.lastName + " " + contestant.Value.emailAddress;
                    return winner;
                    
                }
                else
                {

                    return null;
                    
                }
            }
        }



        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant);
        }
    }
}
