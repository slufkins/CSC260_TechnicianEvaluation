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
        Technician localTech;
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

            localTech = tech;
        }

        private void EvaluationForm_Load(object sender, EventArgs e)
        {


        }

        private void addJobButton_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(yearBox.Text);
            string make = makeBox.ToString();
            string model = modelBox.ToString();

            Vehicle newvehicle = new Vehicle(year, make, model);

            string description = jobBox.Text;
            string skillText = skillBox.Text;
            char skill = Convert.ToChar(skillText);
            double newSkill = 0;
            double bookTime = Convert.ToDouble(bookTimeBox.Text);
            double actualTime = Convert.ToDouble(actualTimeBox.Text);

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

            SpecificJob job = new SpecificJob(description, skill, bookTime, actualTime);
            double jobEfficiency = job.calculateEfficiency(bookTime, actualTime);

            localTech.Efficiency = jobEfficiency;
            localTech.Skill = newSkill;

            techEfficiency.Text = "Efficiency " + localTech.Efficiency;

        }
    }
}
