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
            char ranking = 'C';
            if (tech.Skill >= 4)
            {
                ranking = 'A';
            }
            else if (tech.Skill >= 3 && tech.Skill < 4)
            {
                ranking = 'B';
            }
            else if (tech.Skill < 3)
            {
                ranking = 'C';
            }
            techSkill.Text = "Skill Level: " + ranking;
            techEfficiency.Text = "Efficiency: " + tech.Efficiency;
        }

        private void EvaluationForm_Load(object sender, EventArgs e)
        {


        }

        private void addJobButton_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(yearBox);
            string make = makeBox.ToString();
            string model = modelBox.ToString();

            Vehicle newvehicle = new Vehicle(year, make, model);

            string description = jobBox.Text;
            char skill = Convert.ToChar(skillBox.Text);
            double newSkill;

            if (skill == 'A')
            {
                newSkill = 5;
            }
            else if (skill == 'B')
            {
                newSkill = 4;
            }
            else if (skill == 'C')
            {
                newSkill = 3;
            }

            
        }
    }
}
