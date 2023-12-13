namespace TechnicianEvaluation
{
    public partial class Form1 : Form
    {
        List<Technician> techList = new List<Technician>();
        public Form1()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            double ID = Convert.ToDouble(searchTech.Text);
            int counter = techList.Count;
            bool ismatch = false;

            for (int i = 0; i < techList.Count; i++)
            {
                if (techList[i].TechID == ID)
                {
                    EvaluationForm techEval = new EvaluationForm(techList[i]);
                    ismatch = true;
                    techEval.Show();
                }
                
                if (ismatch == false)
                {
                    searchTech.Text = "Invalid";
                }
            }

            if (ismatch == false) 
            { 

            }

            
        }

        private void newTechButton_Click(object sender, EventArgs e)
        {
            NewTech newTech = new NewTech();
            newTech.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Technician rainbow = new Technician(608, "Rainbow", "Martin", 3, 78.5);
            Technician caleb = new Technician(999, "Caleb", "Rieppel", 1, 68);
            Technician eric = new Technician(345, "Eric", "Johnson", 5, 89.9);

            
            techList.Add(rainbow);
            techList.Add(caleb);
            techList.Add(eric);
        }
    }
}
