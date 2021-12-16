using System;
using System.Windows.Forms;

namespace ElevatorSystem
{
    public partial class StartSimulationForm : Form
    {

        public StartSimulationForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int numberFloor = 0, numberPerson = 0;

            if (textBox1.Text != "" || textBox2.Text != "")
            {
                numberFloor = Convert.ToInt32(textBox1.Text);
                numberPerson = Convert.ToInt32(textBox2.Text);
            }

            if ((numberFloor <= 0) || (numberPerson < 0))
            {
                labelError.Text = "Неправильно введены данные";
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else {
                ((FirstForm)this.Tag).setNumberOfPerson(numberPerson);
                ((FirstForm)this.Tag).setNumberOfFloor(numberFloor);
               // ((MainForm)this.Tag).createBuild();
                this.Close();
            }
       
        }
    }
}
