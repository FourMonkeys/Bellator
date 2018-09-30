using System;
using System.Threading.Tasks;

namespace Bellator.Services
{
    public class CalculationService
    {
        private bool RoundUp = false;
        private bool SlowProgression = false;

        public CalculationService(bool RoundUp, bool SlowProgression)
        {
            this.RoundUp = RoundUp;
            this.SlowProgression = SlowProgression;
        }

        public async Task<int> CalculateCheckPoints(int CheckPoints)
        {
            double CP = 0.00;
            int CheckPointFinal = 0;

            //If slow progression, half the earned Checkpoints
            if(this.SlowProgression)
            {
                CP = CheckPoints / 2;
            }
            else
            {
                CP = Convert.ToDouble(CheckPoints);
            }

            //Round up or round down, depending on user preference
            if(this.RoundUp)
            {
                CP = Math.Ceiling(Convert.ToDouble(CP));
            }
            else
            {
                CP = Math.Floor(Convert.ToDouble(CP));
            }
            
            //If calculated Checkpoints is < 0, round to 1 regardless.
            if(CP <= 1)
            {
                CheckPointFinal = 1;
            }
            else
            {
                CheckPointFinal = Convert.ToInt32(CP);
            }



            return CheckPointFinal;
        }
    }
}
