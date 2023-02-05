namespace DataBase_Exam_Zoo_WindowsForm
{
    partial class Form8_EmployeeShower
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
            this.ListOfDepartments = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListOfEmployees
            // 
            this.ListOfEmployees.FormattingEnabled = true;
            this.ListOfEmployees.ItemHeight = 20;
            this.ListOfEmployees.Location = new System.Drawing.Point(65, 217);
            this.ListOfEmployees.Name = "ListOfEmployees";
            this.ListOfEmployees.Size = new System.Drawing.Size(749, 344);
            this.ListOfEmployees.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 79);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show The Employees";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListOfDepartments
            // 
            this.ListOfDepartments.FormattingEnabled = true;
            this.ListOfDepartments.Location = new System.Drawing.Point(264, 38);
            this.ListOfDepartments.Name = "ListOfDepartments";
            this.ListOfDepartments.Size = new System.Drawing.Size(293, 28);
            this.ListOfDepartments.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select the Department: ";
            // 
            // Form8_EmployeeShower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 688);
            this.Controls.Add(this.ListOfEmployees);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListOfDepartments);
            this.Controls.Add(this.label1);
            this.Name = "Form8_EmployeeShower";
            this.Text = "Form8_EmployeeShower";
            this.Load += new System.EventHandler(this.Form8_EmployeeShower_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ListOfEmployees;
        private Button button1;
        private ComboBox ListOfDepartments;
        private Label label1;
    }
}