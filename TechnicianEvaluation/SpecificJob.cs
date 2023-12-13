using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicianEvaluation
{
    internal class SpecificJob : Job
    {
        public Vehicle vehicle;
        private readonly double _bookTime;
        private readonly double _actualTime;
        List<string> _jobs = new List<string>();

        public SpecificJob(string category, double skill, double bookTime, double actualTime, int year, string make, string model) : base(category, bookTime, skill)
        {
            _bookTime = bookTime;
            _actualTime = actualTime;
            vehicle = new Vehicle(year, make, model);
        } 

        public double ActualTime
        {
            get { return _actualTime; }
        }

        public double calculateEfficiency (double bookTime, double actualTime)
        {
            double efficiency = (bookTime / ActualTime) * 100;
            return efficiency;
        }
    }
}
