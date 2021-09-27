using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_6
{
    public class Rates
    {
        public const double WITHIN = 5;
        public double PHONENUMS = 9;
        public double LANDLINEPHONES = 12.85;
        public double SALE = 0.05;
        private double Rate { get; }
        private NewCall NewCall { get; }
        
        //public double Sum { get; }

        public Rates(string number, int duration, int startTime)
        {
            NewCall = new NewCall(number, duration, startTime);
            switch (NewCall.CurrentRate)
            {
                case "999":
                    {
                        Rate = WITHIN;
                    }
                    break;
                case "9xx":
                    {
                        Rate = PHONENUMS;
                    }
                    break;
                case "other":
                    {
                        Rate = LANDLINEPHONES;
                    }
                    break;
            }

        }
        public double SumCalculation()
        {
            
            double sum = Math.Round(NewCall.Duration * Rate / 60, 2);
            if(NewCall.StartTime >22 || NewCall.StartTime <6)
            {
                sum = Math.Round(sum * (1 - SALE), 2);

            }
            return sum;
        }
    }

}
