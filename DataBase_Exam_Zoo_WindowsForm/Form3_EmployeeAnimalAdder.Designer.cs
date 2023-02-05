namespace DataBase_Exam_Zoo_WindowsForm
{
    partial class Form3_EmployeeAnimalAdder
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
            this.BoxOfAnimals = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxOfEmployees = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpAnimAdder = new System.Windows.Forms.Button();
            this.ListOfDepartments = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Departments";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BoxOfAnimals
            // 
            this.BoxOfAnimals.FormattingEnabled = true;
            this.BoxOfAnimals.Location = new System.Drawing.Point(233, 219);
            this.BoxOfAnimals.Name = "BoxOfAnimals";
            this.BoxOfAnimals.Size = new System.Drawing.Size(509, 92);
            this.BoxOfAnimals.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Select Animals\r\n";
            // 
            // BoxOfEmployees
            // 
            this.BoxOfEmployees.FormattingEnabled = true;
            this.BoxOfEmployees.Location = new System.Drawing.Point(233, 88);
            this.BoxOfEmployees.Name = "BoxOfEmployees";
            this.BoxOfEmployees.Size = new System.Drawing.Size(509, 92);
            this.BoxOfEmployees.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select Employees";
            // 
            // EmpAnimAdder
            // 
            this.EmpAnimAdder.Location = new System.Drawing.Point(233, 428);
            this.EmpAnimAdder.Name = "EmpAnimAdder";
            this.EmpAnimAdder.Size = new System.Drawing.Size(303, 55);
            this.EmpAnimAdder.TabIndex = 16;
            this.EmpAnimAdder.Text = "Add Employees/Animals to Department";
            this.EmpAnimAdder.UseVisualStyleBackColor = true;
            this.EmpAnimAdder.Click += new System.EventHandler(this.EmpAnimAdder_Click);
            // 
            // ListOfDepartments
            // 
            this.ListOfDepartments.FormattingEnabled = true;
            this.ListOfDepartments.Location = new System.Drawing.Point(233, 12);
            this.ListOfDepartments.Name = "ListOfDepartments";
            this.ListOfDepartments.Size = new System.Drawing.Size(381, 28);
            this.ListOfDepartments.TabIndex = 17;
            // 
            // Form3_EmployeeAnimalAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 515);
            this.Controls.Add(this.ListOfDepartments);
            this.Controls.Add(this.EmpAnimAdder);
            this.Controls.Add(this.BoxOfAnimals);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BoxOfEmployees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form3_EmployeeAnimalAdder";
            this.Text = "Form3_EmployeeAnimalAdder";
            this.Load += new System.EventHandler(this.Form3_EmployeeAnimalAdder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CheckedListBox BoxOfAnimals;
        private Label label4;
        private CheckedListBox BoxOfEmployees;
        private Label label3;
        private Button EmpAnimAdder;
        private ComboBox ListOfDepartments;
    }
}