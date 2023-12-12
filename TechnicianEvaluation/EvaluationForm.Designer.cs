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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            yearBox = new TextBox();
            makeBox = new TextBox();
            modelBox = new TextBox();
            jobBox = new TextBox();
            bookTimeBox = new TextBox();
            actualTime = new TextBox();
            skillBox = new Label();
            jobSkillBox = new TextBox();
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
            addJobButton.Location = new Point(419, 45);
            addJobButton.Name = "addJobButton";
            addJobButton.Size = new Size(75, 62);
            addJobButton.TabIndex = 8;
            addJobButton.Text = "Add Job";
            addJobButton.UseVisualStyleBackColor = true;
            addJobButton.Click += addJobButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 17);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 9;
            label1.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 45);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 10;
            label2.Text = "Make";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 78);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 11;
            label3.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 164);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 12;
            label4.Text = "Book Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 195);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 13;
            label5.Text = "Actual Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 106);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 14;
            label6.Text = "Job";
            // 
            // yearBox
            // 
            yearBox.Location = new Point(298, 14);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(100, 23);
            yearBox.TabIndex = 15;
            // 
            // makeBox
            // 
            makeBox.Location = new Point(298, 42);
            makeBox.Name = "makeBox";
            makeBox.Size = new Size(100, 23);
            makeBox.TabIndex = 16;
            // 
            // modelBox
            // 
            modelBox.Location = new Point(298, 71);
            modelBox.Name = "modelBox";
            modelBox.Size = new Size(100, 23);
            modelBox.TabIndex = 17;
            // 
            // jobBox
            // 
            jobBox.Location = new Point(298, 100);
            jobBox.Name = "jobBox";
            jobBox.Size = new Size(100, 23);
            jobBox.TabIndex = 18;
            // 
            // bookTimeBox
            // 
            bookTimeBox.Location = new Point(298, 161);
            bookTimeBox.Name = "bookTimeBox";
            bookTimeBox.Size = new Size(100, 23);
            bookTimeBox.TabIndex = 19;
            // 
            // actualTime
            // 
            actualTime.Location = new Point(298, 192);
            actualTime.Name = "actualTime";
            actualTime.Size = new Size(100, 23);
            actualTime.TabIndex = 20;
            // 
            // skillBox
            // 
            skillBox.AutoSize = true;
            skillBox.Location = new Point(213, 134);
            skillBox.Name = "skillBox";
            skillBox.Size = new Size(28, 15);
            skillBox.TabIndex = 21;
            skillBox.Text = "Skill";
            // 
            // jobSkillBox
            // 
            jobSkillBox.Location = new Point(298, 131);
            jobSkillBox.Name = "jobSkillBox";
            jobSkillBox.Size = new Size(100, 23);
            jobSkillBox.TabIndex = 22;
            // 
            // EvaluationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 358);
            Controls.Add(jobSkillBox);
            Controls.Add(skillBox);
            Controls.Add(actualTime);
            Controls.Add(bookTimeBox);
            Controls.Add(jobBox);
            Controls.Add(modelBox);
            Controls.Add(makeBox);
            Controls.Add(yearBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox yearBox;
        private TextBox makeBox;
        private TextBox modelBox;
        private TextBox jobBox;
        private TextBox bookTimeBox;
        private TextBox actualTime;
        private Label skillBox;
        private TextBox jobSkillBox;
    }
}