namespace TechnicianEvaluation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            
        }

        private void newTechButton_Click(object sender, EventArgs e)
        {
            NewTech newTech = new NewTech();
            newTech.Show();
        }
    }
}
