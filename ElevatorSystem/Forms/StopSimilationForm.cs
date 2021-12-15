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
    public partial class StopSimilationForm : Form
    {
        public StopSimilationForm(int sum, int hol, int weigth, int countPers)
        {
            InitializeComponent();
            label1.Text = "Общее количество поездок: " + sum;
            label2.Text = "Количество холостых поездок: " + hol;
            label3.Text = "Суммарный перемещённый вес: " + weigth;
            label4.Text = "Общее количество человек: " + countPers;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
