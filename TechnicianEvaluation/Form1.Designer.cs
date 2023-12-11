namespace TechnicianEvaluation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchTech = new TextBox();
            findButton = new Button();
            newTechButton = new Button();
            SuspendLayout();
            // 
            // searchTech
            // 
            searchTech.Location = new Point(12, 12);
            searchTech.Name = "searchTech";
            searchTech.Size = new Size(100, 23);
            searchTech.TabIndex = 0;
            // 
            // findButton
            // 
            findButton.Location = new Point(118, 12);
            findButton.Name = "findButton";
            findButton.Size = new Size(75, 23);
            findButton.TabIndex = 1;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // newTechButton
            // 
            newTechButton.Location = new Point(199, 12);
            newTechButton.Name = "newTechButton";
            newTechButton.Size = new Size(75, 23);
            newTechButton.TabIndex = 2;
            newTechButton.Text = "New Tech";
            newTechButton.UseVisualStyleBackColor = true;
            newTechButton.Click += newTechButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 58);
            Controls.Add(newTechButton);
            Controls.Add(findButton);
            Controls.Add(searchTech);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTech;
        private Button findButton;
        private Button newTechButton;
    }
}
