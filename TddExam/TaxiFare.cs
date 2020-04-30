using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddExam
{
    public class TaxiFare
    {
        private const double START_FARE = 6.0;
        private const double START_DISTANCE = 2.0;
        private const double EXTRA_DISTANCE = 8.0;
        private const double FARE_PERMILE = 0.8;
        private const double FARE_PERMIN = 0.25;


        public int Calculate(double distance, double waittime)
        {
            double money = 0;

            money = GetDistanceFare(distance) + GetWaitFare(waittime);

            return (int)Math.Round(money, MidpointRounding.AwayFromZero);
        }

        private double GetDistanceFare(double distance)
        {
            if (distance <= START_DISTANCE) 
            {
                return START_FARE;
            }
            else if (distance > START_DISTANCE && distance <= EXTRA_DISTANCE)
            {
                return START_FARE + (distance - START_DISTANCE) * 0.8;
            }
            else
            {
                return START_FARE + (EXTRA_DISTANCE - START_DISTANCE) * 0.8 + (distance - EXTRA_DISTANCE) * 0.8 * 1.5;
            }
        }

        private double GetWaitFare(double waittime)
        {
            return waittime * 0.25;
        }
    }
}
