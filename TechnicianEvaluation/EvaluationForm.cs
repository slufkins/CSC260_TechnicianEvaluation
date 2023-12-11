using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicianEvaluation
{
    public partial class EvaluationForm : Form
    {
        public EvaluationForm(Technician tech)
        {
            InitializeComponent();
            techID.Text = ("Technician ID: " + tech.TechID);
            techName.Text = "Name: " + tech.FirstName + " " + tech.LastName;
            techSkill.Text = "Skill Level: " + tech.Skill;
            techEfficiency.Text = "Efficiency: " + tech.Efficiency;
        }

        private void EvaluationForm_Load(object sender, EventArgs e)
        {
            

        }
    }
}
