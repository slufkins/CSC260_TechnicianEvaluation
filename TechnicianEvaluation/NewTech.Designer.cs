namespace TechnicianEvaluation
{
    partial class NewTech
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
            fNameBox = new TextBox();
            lNameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            enterNewTechButton = new Button();
            SuspendLayout();
            // 
            // fNameBox
            // 
            fNameBox.Location = new Point(85, 6);
            fNameBox.Name = "fNameBox";
            fNameBox.Size = new Size(100, 23);
            fNameBox.TabIndex = 0;
            // 
            // lNameBox
            // 
            lNameBox.Location = new Point(85, 35);
            lNameBox.Name = "lNameBox";
            lNameBox.Size = new Size(100, 23);
            lNameBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 2;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name: ";
            // 
            // enterNewTechButton
            // 
            enterNewTechButton.Location = new Point(110, 64);
            enterNewTechButton.Name = "enterNewTechButton";
            enterNewTechButton.Size = new Size(75, 23);
            enterNewTechButton.TabIndex = 4;
            enterNewTechButton.Text = "Enter";
            enterNewTechButton.UseVisualStyleBackColor = true;
            // 
            // NewTech
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 102);
            Controls.Add(enterNewTechButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lNameBox);
            Controls.Add(fNameBox);
            Name = "NewTech";
            Text = "NewTech";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fNameBox;
        private TextBox lNameBox;
        private Label label1;
        private Label label2;
        private Button enterNewTechButton;
    }
}