namespace DataBase_Exam_Zoo_WindowsForm
{
    partial class Form5_AnimalCreator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AnimalNameBox = new System.Windows.Forms.TextBox();
            this.AnimalTypeBox = new System.Windows.Forms.TextBox();
            this.BoxOfEmployees = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ListOfDepartments = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animal Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type of Animal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Department:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Employees:";
            // 
            // AnimalNameBox
            // 
            this.AnimalNameBox.Location = new System.Drawing.Point(229, 25);
            this.AnimalNameBox.Name = "AnimalNameBox";
            this.AnimalNameBox.Size = new System.Drawing.Size(323, 27);
            this.AnimalNameBox.TabIndex = 4;
            // 
            // AnimalTypeBox
            // 
            this.AnimalTypeBox.Location = new System.Drawing.Point(229, 92);
            this.AnimalTypeBox.Name = "AnimalTypeBox";
            this.AnimalTypeBox.Size = new System.Drawing.Size(323, 27);
            this.AnimalTypeBox.TabIndex = 5;
            // 
            // BoxOfEmployees
            // 
            this.BoxOfEmployees.FormattingEnabled = true;
            this.BoxOfEmployees.Location = new System.Drawing.Point(229, 302);
            this.BoxOfEmployees.Name = "BoxOfEmployees";
            this.BoxOfEmployees.Size = new System.Drawing.Size(544, 114);
            this.BoxOfEmployees.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(464, 81);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create Animal and Add Selections";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListOfDepartments
            // 
            this.ListOfDepartments.FormattingEnabled = true;
            this.ListOfDepartments.Location = new System.Drawing.Point(229, 159);
            this.ListOfDepartments.Name = "ListOfDepartments";
            this.ListOfDepartments.Size = new System.Drawing.Size(323, 28);
            this.ListOfDepartments.TabIndex = 9;
            // 
            // Form5_AnimalCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.ListOfDepartments);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoxOfEmployees);
            this.Controls.Add(this.AnimalTypeBox);
            this.Controls.Add(this.AnimalNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5_AnimalCreator";
            this.Text = "Form5_AnimalCreator";
            this.Load += new System.EventHandler(this.Form5_AnimalCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox AnimalNameBox;
        private TextBox AnimalTypeBox;
        private CheckedListBox BoxOfEmployees;
        private Button button1;
        private ComboBox ListOfDepartments;
    }
}