namespace DataBase_Exam_Zoo_WindowsForm
{
    partial class Form6_AnimalTransfer
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
            this.BoxOfAnimals = new System.Windows.Forms.ComboBox();
            this.BoxOfDepartments = new System.Windows.Forms.ComboBox();
            this.BoxOfEmployees = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoxOfAnimals
            // 
            this.BoxOfAnimals.FormattingEnabled = true;
            this.BoxOfAnimals.Location = new System.Drawing.Point(287, 35);
            this.BoxOfAnimals.Name = "BoxOfAnimals";
            this.BoxOfAnimals.Size = new System.Drawing.Size(519, 28);
            this.BoxOfAnimals.TabIndex = 0;
            // 
            // BoxOfDepartments
            // 
            this.BoxOfDepartments.FormattingEnabled = true;
            this.BoxOfDepartments.Location = new System.Drawing.Point(287, 107);
            this.BoxOfDepartments.Name = "BoxOfDepartments";
            this.BoxOfDepartments.Size = new System.Drawing.Size(519, 28);
            this.BoxOfDepartments.TabIndex = 1;
            // 
            // BoxOfEmployees
            // 
            this.BoxOfEmployees.FormattingEnabled = true;
            this.BoxOfEmployees.Location = new System.Drawing.Point(287, 261);
            this.BoxOfEmployees.Name = "BoxOfEmployees";
            this.BoxOfEmployees.Size = new System.Drawing.Size(519, 114);
            this.BoxOfEmployees.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 74);
            this.button1.TabIndex = 3;
            this.button1.Text = "Transfer The Animal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Animal To Transfer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select The New Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Employees";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 60);
            this.label4.TabIndex = 7;
            this.label4.Text = "*Note\r\nAfter transfering the Animal all his employees will be dismissed.\r\nPlease " +
    "select and assign at least 1 employee to the animal";
            // 
            // Form6_AnimalTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 504);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoxOfEmployees);
            this.Controls.Add(this.BoxOfDepartments);
            this.Controls.Add(this.BoxOfAnimals);
            this.Name = "Form6_AnimalTransfer";
            this.Text = "Form6_AnimalTransfer";
            this.Load += new System.EventHandler(this.Form6_AnimalTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox BoxOfAnimals;
        private ComboBox BoxOfDepartments;
        private CheckedListBox BoxOfEmployees;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}