using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicianEvaluation
{
    public abstract class Job
    {
        protected virtual string _category { get; set; }
        protected virtual double bookTime { get { return 0; } }
        protected virtual double skillLevel { get { return 0; } }

        public Job (string category)
        {
            _category = category;
        }

        
    }
}
