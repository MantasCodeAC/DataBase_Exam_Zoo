namespace DataBase_Exam_Zoo_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2_DepartmentCreator form2 = new();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3_EmployeeAnimalAdder form3 = new();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4_EmployeeCreator form4 = new();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5_AnimalCreator form5 = new();
            form5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7_AnimalsShower form7 = new();
            form7.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form8_EmployeeShower form8 = new();
            form8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9_EmployeeShowerByAnimal form9 = new();
            form9.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6_AnimalTransfer form6 = new();
            form6.Show();
        }
    }
}