using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicianEvaluation
{
    internal class Vehicle
    {
        readonly int _year;
        readonly string _make;
        readonly string _model;
        public Vehicle(int year, string make, string model)
        {
            _year = year;
            _make = make;
            _model = model;
        }

        public int Year
        {
            get { return _year; }
        }

        public string Make 
        { 
            get { return _make;} 
        }

        public string Model
        {
            get { return _model;}
        }
    }
}
