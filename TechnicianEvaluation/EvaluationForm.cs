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
        List<string> jobList = new List<string>();
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
            techEfficiency.Text = "Efficiency: " + Math.Round(tech.Efficiency, 2) + "%";

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
            string description = jobBox.Text;
            string skill = jobSkillBox.Text;
            double bookTime = Convert.ToDouble(bookTimeBox.Text);
            double actualTime = Convert.ToDouble(actualTimeBox.Text);
            double newSkill = 0;

            if (skill == "A")
            {
                newSkill = 5;
            }
            else if (skill == "B")
            {
                newSkill = 4;
            }
            else if (skill == "C")
            {
                newSkill = 3;
            }

            SpecificJob job = new SpecificJob(description, newSkill, bookTime, actualTime, year, make, model);
            double jobEfficiency = job.calculateEfficiency(bookTime, actualTime);

            localTech.Efficiency = jobEfficiency;
            localTech.Skill = newSkill;

            techEfficiency.Text = "Efficiency " + Math.Round(localTech.Efficiency, 2) + "%";

            yearBox.Text = "";
            makeBox.Text = "";
            modelBox.Text = "";
            jobBox.Text = "";
            jobSkillBox.Text = "";
            bookTimeBox.Text = "";
            actualTimeBox.Text = "";

            
        }
    }
}
