namespace TechnicianEvaluation
{
    partial class EvaluationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            techID = new Label();
            techName = new Label();
            techSkill = new Label();
            techEfficiency = new Label();
            addJobButton = new Button();
            SuspendLayout();
            // 
            // techID
            // 
            techID.AutoSize = true;
            techID.Location = new Point(11, 17);
            techID.Name = "techID";
            techID.Size = new Size(51, 15);
            techID.TabIndex = 0;
            techID.Text = "Tech ID: ";
            // 
            // techName
            // 
            techName.AutoSize = true;
            techName.Location = new Point(11, 50);
            techName.Name = "techName";
            techName.Size = new Size(45, 15);
            techName.TabIndex = 1;
            techName.Text = "Name: ";
            // 
            // techSkill
            // 
            techSkill.AutoSize = true;
            techSkill.Location = new Point(11, 92);
            techSkill.Name = "techSkill";
            techSkill.Size = new Size(64, 15);
            techSkill.TabIndex = 2;
            techSkill.Text = "Skill Level: ";
            // 
            // techEfficiency
            // 
            techEfficiency.AutoSize = true;
            techEfficiency.Location = new Point(11, 134);
            techEfficiency.Name = "techEfficiency";
            techEfficiency.Size = new Size(58, 15);
            techEfficiency.TabIndex = 3;
            techEfficiency.Text = "Efficiency";
            // 
            // addJobButton
            // 
            addJobButton.Location = new Point(199, 50);
            addJobButton.Name = "addJobButton";
            addJobButton.Size = new Size(75, 62);
            addJobButton.TabIndex = 8;
            addJobButton.Text = "Add Job";
            addJobButton.UseVisualStyleBackColor = true;
            // 
            // EvaluationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 195);
            Controls.Add(addJobButton);
            Controls.Add(techEfficiency);
            Controls.Add(techSkill);
            Controls.Add(techName);
            Controls.Add(techID);
            Name = "EvaluationForm";
            Text = "EvaluationForm";
            Load += EvaluationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label techID;
        private Label techName;
        private Label techSkill;
        private Label techEfficiency;
        private Button addJobButton;
    }
}