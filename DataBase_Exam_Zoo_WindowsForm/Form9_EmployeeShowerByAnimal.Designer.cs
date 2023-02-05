namespace DataBase_Exam_Zoo_WindowsForm
{
    partial class Form9_EmployeeShowerByAnimal
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
            this.ListOfEmployees = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ListOfAnimals = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListOfEmployees
            // 
            this.ListOfEmployees.FormattingEnabled = true;
            this.ListOfEmployees.ItemHeight = 20;
            this.ListOfEmployees.Location = new System.Drawing.Point(39, 196);
            this.ListOfEmployees.Name = "ListOfEmployees";
            this.ListOfEmployees.Size = new System.Drawing.Size(749, 344);
            this.ListOfEmployees.TabIndex = 11;
            this.ListOfEmployees.SelectedIndexChanged += new System.EventHandler(this.ListOfEmployees_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 79);
            this.button1.TabIndex = 10;
            this.button1.Text = "Show The Employees";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListOfAnimals
            // 
            this.ListOfAnimals.FormattingEnabled = true;
            this.ListOfAnimals.Location = new System.Drawing.Point(238, 17);
            this.ListOfAnimals.Name = "ListOfAnimals";
            this.ListOfAnimals.Size = new System.Drawing.Size(293, 28);
            this.ListOfAnimals.TabIndex = 9;
            this.ListOfAnimals.SelectedIndexChanged += new System.EventHandler(this.ListOfDepartments_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select the Animal: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form9_EmployeeShowerByAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 580);
            this.Controls.Add(this.ListOfEmployees);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListOfAnimals);
            this.Controls.Add(this.label1);
            this.Name = "Form9_EmployeeShowerByAnimal";
            this.Text = "Form9_EmployeeShowerByAnimal";
            this.Load += new System.EventHandler(this.Form9_EmployeeShowerByAnimal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ListOfEmployees;
        private Button button1;
        private ComboBox ListOfAnimals;
        private Label label1;
    }
}