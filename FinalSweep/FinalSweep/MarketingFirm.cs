using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSweep
{
    public class MarketingFirm
    {
        ISweepstakesManager sweepstakesManager;

        public void Marketing(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager;
        }

        //popularity of sweekstakes
        //email addresses of contestants
        //lookup past sweepstakes 
    }
}
