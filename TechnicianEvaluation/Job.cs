using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicianEvaluation
{
    public abstract class Job
    {
        string _category;
        double _bookTime;
        double _skillLevel;

        public Job (string category, double bookTime, double skillLevel)
        {
            _category = category;
            _bookTime = bookTime;
            _skillLevel = skillLevel;
        }

        public string Category
        {
            get { return _category; }
        }

        public double BookTime
        {
            get { return _bookTime; }
        }

        public double SkillLevel
        {
            get { return _skillLevel;}
        }

        
    }
}
