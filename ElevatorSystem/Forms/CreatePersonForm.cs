using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSystem
{
    public partial class CreatePersonForm : Form
    {
        private int firstFloor;
        private int endFloor;

        public CreatePersonForm()
        {
            InitializeComponent();
            firstFloor = 0;
            endFloor = 0;
        }

        private void buttonCreatPerson_Click(object sender, EventArgs e)
        {

            if (!(textBox1.Text.Equals("") || textBox2.Text.Equals("")))
            {
                firstFloor = Convert.ToInt32(textBox1.Text);
                endFloor = Convert.ToInt32(textBox2.Text);
            }

            if ((firstFloor < 1 || endFloor < 1) || (firstFloor == endFloor))
            {
                labelError.Text = "Данные введены неверно!";
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else {
                this.Close();
            }
        }

        public int FirstFloor { 
            get {
                return firstFloor;
            }
        }

        public int EndFloor
        {
            get
            {
                return endFloor;
            }
        }
    }
}
