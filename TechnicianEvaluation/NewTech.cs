using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace TechnicianEvaluation
{
    public partial class NewTech : Form
    {
        public NewTech()
        {
            InitializeComponent();
        }

        private void enterNewTechButton_Click(object sender, EventArgs e)
        {
            string fname = fNameBox.Text;
            string lname = lNameBox.Text;

            Technician newTech = new Technician(fname, lname);

            EvaluationForm newForm = new EvaluationForm(newTech);
            newForm.Show();
        }
    }
}
