using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSweep
{
    class ManagerFactory : ICreateSweepstakes
    {
        public ICreateSweepstakes CreateSweepstakes()
        {
            Console.WriteLine("Stack or Queue?");
            string dataChoice = Console.ReadLine();

            switch (dataChoice)
            {
                case "Stack":
                    
                case "Queue":

                default;

            }
        }
    }
}
