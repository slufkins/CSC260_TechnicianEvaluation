using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicianEvaluation
{
    internal class Technician
    {
        int _techID;
        string _fname;
        string _lname;
        char _skill;
        double _efficiency;

        // New technician constructor
        public Technician(string fname, string lname)
        {
            Random random = new Random();
            _techID = random.Next(100, 999);
            _fname = fname;
            _lname = lname;
            _skill = 'C';
            _efficiency = 0;
        }

        // Experienced technician constructor
        public Technician(int id, string fname, string lname, char skill, double efficiency)
        {
            _techID = id;
            _fname = fname;
            _lname = lname;
            _skill = skill;
            _efficiency = efficiency;
        }
    }
}
