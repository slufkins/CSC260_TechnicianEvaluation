using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicianEvaluation
{
    internal abstract class Job
    {
        readonly string _category;
        readonly double _bookTime;
        readonly double _skillLevel;
        public Job(string category, double bookTime, double skillLevel) 
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
            get { return _skillLevel; }
        }
    }
}
