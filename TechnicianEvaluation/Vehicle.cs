using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicianEvaluation
{
    internal class Vehicle
    {
        int _year;
        string _make;
        string _model;
        public Vehicle(int year, string make, string model)
        {
            _year = year;
            _make = make;
            _model = model;
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string Make 
        { 
            get { return _make;} 
            set { _make = value; }
        }

        public string Model
        {
            get { return _model;}
            set { _model = value; }
        }
    }
}
