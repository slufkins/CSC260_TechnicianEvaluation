using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicianEvaluation
{
    internal class SpecificJob : Job
    {

        private readonly double _actualTime;
        public SpecificJob(string category, double skill, double bookTime, double actualTime) : base (category, bookTime, skill)
        {
            _actualTime = actualTime;
        }

        public double ActualTime
        {
            get { return _actualTime; }
        }

        public double calculateEfficiency (double bookTime, double actualTime)
        {
            double efficiency = bookTime / ActualTime;
            return efficiency;
        }

    }
}
