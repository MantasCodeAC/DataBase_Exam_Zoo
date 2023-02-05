namespace DataBase_Exam_Zoo_WindowsForm
{
    partial class Form2_DepartmentCreator
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameDepartment = new System.Windows.Forms.TextBox();
            this.CreatorAndAdder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxOfEmployees = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxOfAnimals = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(298, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(509, 84);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Departments";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insert the Name of New Department";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNameDepartment
            // 
            this.txtNameDepartment.Location = new System.Drawing.Point(298, 145);
            this.txtNameDepartment.Name = "txtNameDepartment";
            this.txtNameDepartment.Size = new System.Drawing.Size(509, 27);
            this.txtNameDepartment.TabIndex = 4;
            // 
            // CreatorAndAdder
            // 
            this.CreatorAndAdder.Location = new System.Drawing.Point(280, 535);
            this.CreatorAndAdder.Name = "CreatorAndAdder";
            this.CreatorAndAdder.Size = new System.Drawing.Size(325, 48);
            this.CreatorAndAdder.TabIndex = 5;
            this.CreatorAndAdder.Text = "Create Department And Add Entities ";
            this.CreatorAndAdder.UseVisualStyleBackColor = true;
            this.CreatorAndAdder.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Employees";
            // 
            // BoxOfEmployees
            // 
            this.BoxOfEmployees.FormattingEnabled = true;
            this.BoxOfEmployees.Location = new System.Drawing.Point(298, 208);
            this.BoxOfEmployees.Name = "BoxOfEmployees";
            this.BoxOfEmployees.Size = new System.Drawing.Size(509, 92);
            this.BoxOfEmployees.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select Animals\r\n";
            // 
            // BoxOfAnimals
            // 
            this.BoxOfAnimals.FormattingEnabled = true;
            this.BoxOfAnimals.Location = new System.Drawing.Point(298, 344);
            this.BoxOfAnimals.Name = "BoxOfAnimals";
            this.BoxOfAnimals.Size = new System.Drawing.Size(509, 92);
            this.BoxOfAnimals.TabIndex = 9;
            // 
            // Form2_DepartmentCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 595);
            this.Controls.Add(this.BoxOfAnimals);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BoxOfEmployees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreatorAndAdder);
            this.Controls.Add(this.txtNameDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2_DepartmentCreator";
            this.Text = "Form2_DepartmentCreator";
            this.Load += new System.EventHandler(this.Form2_DepartmentCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private TextBox txtNameDepartment;
        private Button CreatorAndAdder;
        private Label label3;
        private CheckedListBox BoxOfEmployees;
        private Label label4;
        private CheckedListBox BoxOfAnimals;
    }
}