namespace DataBase_Exam_Zoo_WindowsForm
{
    partial class Form7_AnimalsShower
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListOfDepartments = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ListOfAnimals = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the Department: ";
            // 
            // ListOfDepartments
            // 
            this.ListOfDepartments.FormattingEnabled = true;
            this.ListOfDepartments.Location = new System.Drawing.Point(238, 40);
            this.ListOfDepartments.Name = "ListOfDepartments";
            this.ListOfDepartments.Size = new System.Drawing.Size(293, 28);
            this.ListOfDepartments.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show The Animals";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListOfAnimals
            // 
            this.ListOfAnimals.FormattingEnabled = true;
            this.ListOfAnimals.ItemHeight = 20;
            this.ListOfAnimals.Location = new System.Drawing.Point(39, 219);
            this.ListOfAnimals.Name = "ListOfAnimals";
            this.ListOfAnimals.Size = new System.Drawing.Size(749, 344);
            this.ListOfAnimals.TabIndex = 3;
            // 
            // Form7_AnimalsShower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.ListOfAnimals);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListOfDepartments);
            this.Controls.Add(this.label1);
            this.Name = "Form7_AnimalsShower";
            this.Text = "Form7_AnimalsShower";
            this.Load += new System.EventHandler(this.Form7_AnimalsShower_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox ListOfDepartments;
        private Button button1;
        private ListBox ListOfAnimals;
    }
}