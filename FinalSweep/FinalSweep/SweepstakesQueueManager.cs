using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSweep
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> queue = new Queue<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstake = queue.Dequeue();
            return sweepstake;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }



    }
}
