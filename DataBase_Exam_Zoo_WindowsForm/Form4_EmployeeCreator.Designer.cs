namespace DataBase_Exam_Zoo_WindowsForm
{
    partial class Form4_EmployeeCreator
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
            this.employeeNameBox = new System.Windows.Forms.TextBox();
            this.employeePositionBox = new System.Windows.Forms.TextBox();
            this.employeeResponsibilitiesBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListOfDepartments = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeNameBox
            // 
            this.employeeNameBox.Location = new System.Drawing.Point(234, 5);
            this.employeeNameBox.Name = "employeeNameBox";
            this.employeeNameBox.Size = new System.Drawing.Size(272, 27);
            this.employeeNameBox.TabIndex = 0;
            // 
            // employeePositionBox
            // 
            this.employeePositionBox.Location = new System.Drawing.Point(234, 58);
            this.employeePositionBox.Name = "employeePositionBox";
            this.employeePositionBox.Size = new System.Drawing.Size(272, 27);
            this.employeePositionBox.TabIndex = 1;
            // 
            // employeeResponsibilitiesBox
            // 
            this.employeeResponsibilitiesBox.Location = new System.Drawing.Point(234, 106);
            this.employeeResponsibilitiesBox.Name = "employeeResponsibilitiesBox";
            this.employeeResponsibilitiesBox.Size = new System.Drawing.Size(554, 27);
            this.employeeResponsibilitiesBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Employee Responsibilities:";
            // 
            // ListOfDepartments
            // 
            this.ListOfDepartments.FormattingEnabled = true;
            this.ListOfDepartments.Location = new System.Drawing.Point(234, 161);
            this.ListOfDepartments.Name = "ListOfDepartments";
            this.ListOfDepartments.Size = new System.Drawing.Size(272, 28);
            this.ListOfDepartments.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Department:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 102);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create Employee and Add to selected Department";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4_EmployeeCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ListOfDepartments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeResponsibilitiesBox);
            this.Controls.Add(this.employeePositionBox);
            this.Controls.Add(this.employeeNameBox);
            this.Name = "Form4_EmployeeCreator";
            this.Text = "Form4_EmployeeCreator";
            this.Load += new System.EventHandler(this.Form4_EmployeeCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox employeeNameBox;
        private TextBox employeePositionBox;
        private TextBox employeeResponsibilitiesBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox ListOfDepartments;
        private Label label4;
        private Button button1;
    }
}