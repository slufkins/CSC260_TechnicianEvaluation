using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicianEvaluation
{
    public class Technician
    {
        readonly int _techID;
        string _fname;
        string _lname;
        double _skill;
        double _efficiency;

        // New technician constructor
        public Technician(string fname, string lname)
        {
            Random random = new Random();
            _techID = random.Next(100, 999);
            _fname = fname;
            _lname = lname;
            _skill = 0;
            _efficiency = 0;
        }

        // Experienced technician constructor
        public Technician(int id, string fname, string lname, double skill, double efficiency)
        {
            _techID = id;
            _fname = fname;
            _lname = lname;
            _skill = skill;
            _efficiency = efficiency;

            // Add current skill to skill list and current efficiency to efficiency list
            skillList.Add(skill);
            efficiencyList.Add(efficiency);
        }

        // Use lists to calculate skill and efficiency
        List<double> skillList = new List<double>();
        List<double> efficiencyList = new List<double>();

        public int TechID
        {
            get { return _techID; }
        }

        public string FirstName
        {
            get { return _fname; }
            set { _fname = value; }
        }

        public string LastName
        {
            get { return _lname; }
            set { _lname = value; }
        }

        public double Skill
        {
            get { return _skill; }
            set
            {
                skillList.Add(value);

                double total = skillList.Sum();
                double numOfEntries = skillList.Count();

                _skill = total / numOfEntries;
            }
        }

        public double Efficiency
        { 
            get { return _efficiency; }
            set 
            {
                efficiencyList.Add(value);

                double total = efficiencyList.Sum();
                double numOfEntries = efficiencyList.Count();

                _efficiency = total / numOfEntries;
            } 
        }
    }
}
