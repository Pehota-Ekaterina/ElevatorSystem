using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSystem
{
    public partial class FirstForm : Form
    {

        Graphics g;

        private bool workSystem;
        private DateTime dateTime;

        CreatePersonForm createPerson;
        public StartSimulationForm form;

        private List<Floor> floors = new List<Floor>();
        private List<Person> persons = new List<Person>();
        private Lift lift;

        private int numberOfPerson;
        private int numberOfFloor;
        private int positionX;
        private int positionY;

        public FirstForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            workSystem = false;
            dateTime = new DateTime(0, 0);
            positionX = Screen.PrimaryScreen.Bounds.Width / 3;
            positionY = Screen.PrimaryScreen.Bounds.Height - 175;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!workSystem)
            {
                form = new StartSimulationForm();
                form.Tag = this;
                form.ShowDialog();
                createBuild();
                timer1.Enabled = true;
            }
            else if (persons.Count != 0) 
            {
                string message = "Нельзя завершить работу, пока есть люди";
                string caption = "Ошибка";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                workSystem = false;
                timer1.Enabled = false;
                dateTime = new DateTime(0, 0);
                StopSimilationForm exitData = new StopSimilationForm(0, 0, 0, 0);
                exitData.ShowDialog();
                buttonStart.BackColor = Color.White;
                buttonStart.ForeColor = Color.Black;
                buttonStart.Text = "Запустить симуляцию";
                positionY = Screen.PrimaryScreen.Bounds.Height - 155;
                stopSystem();
            }
        }

        private void stopSystem()
        {
            timerRefresh.Enabled = false;
            timerLift.Enabled = false;
            Invalidate();
            persons.Clear();
            floors.Clear();
            lift = Lift.newInstance();
        }

        private void buttonCreatPerson_Click(object sender, EventArgs e)
        {
            createPerson = new CreatePersonForm();
            createPerson.ShowDialog();
            try
            {
                if (workSystem)
                {
                    Person person = new Person(persons.Count, positionX, floors[createPerson.FirstFloor - 1].PositionY,
                    new int[] { createPerson.FirstFloor - 1, createPerson.EndFloor - 1 });
                    persons.Add(person);
                    g.DrawImage(Properties.Resources.person, person.PositionX, person.PositionY);
                }
                else
                {
                    int thisY = Screen.PrimaryScreen.Bounds.Height - 95;
                    for (int i = 0; i < createPerson.FirstFloor; i++)
                    {
                        thisY -= 108;
                    }
                    Person person = new Person(persons.Count, positionX, thisY + 15,
                    new int[] { createPerson.FirstFloor - 1, createPerson.EndFloor - 1 });
                    persons.Add(person);
                }
            } catch (Exception ignore){ }
            
        }

        public void createBuild()
        {
            workSystem = true;
            buttonStart.BackColor = Color.FromArgb(189, 18, 18);
            buttonStart.ForeColor = Color.White;
            buttonStart.Text = "Остановить симуляцию";
            createFloorInBuild();
            createPersonInBuild();
            createLiftInBuild();
            timerRefresh.Enabled = true;
            timerLift.Enabled = true;
        }

        private void createPersonInBuild()
        {
            for (int i = 0; i < numberOfPerson; i++)
            {
                Random rnd = new Random((int)(DateTime.Now.Ticks));
                int num1 = rnd.Next(0, numberOfFloor - 1);
                int num2 = rnd.Next(0, numberOfFloor - 1);
                Person person = new Person(i, positionX, floors[num1].PositionY, new int[] {num1, num2});
                persons.Add(person);
                g.DrawImage(Properties.Resources.person, persons[i].PositionX, persons[i].PositionY);
            }
        }

        private void createLiftInBuild()
        {
            int[] mass = new int[floors.Count];
            for (int i = 0; i < mass.Length; i++) {
                mass[i] = floors[i].PositionY;
            }
            lift = Lift.getInstance(numberOfFloor, positionX + 430, floors[0].PositionY, mass);
            g.DrawImage(Properties.Resources.lift, lift.PositionX, lift.PositionY);
        }

        private void createFloorInBuild()
        {
            if (numberOfFloor > 7)
            {
                positionY = 600 + 600 * numberOfFloor;
                for (int i = 0; i < numberOfFloor; i++)
                {
                    Floor floor = new Floor(i, positionX, positionY);
                    floors.Add(floor);
                    g.DrawImage(Properties.Resources.floor, positionX, positionY);
                    positionY -= 108;
                }
            }
            else
            {
                positionY = Screen.PrimaryScreen.Bounds.Height - 183;
                for (int i = 0; i < numberOfFloor; i++)
                {
                    Floor floor = new Floor(i, positionX, positionY);
                    floors.Add(floor);
                    g.DrawImage(Properties.Resources.floor, positionX, positionY);
                    positionY -= 108;
                }
            }
        }

        public void setNumberOfPerson(int num)
        {
            numberOfPerson = num;
        }

        public void setNumberOfFloor(int num)
        {
            numberOfFloor = num;
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh() {

            foreach (Person person in persons) {
                if (person.NextMove())
                {
                    g.DrawImage(Properties.Resources.person_emp, person.OldX, person.OldY);
                    g.DrawImage(Properties.Resources.person, person.PositionX, person.PositionY);
                }
                else
                {
                    //g.DrawImage(Properties.Resources.person_emp, person.PositionX, person.PositionY);
                }
            }
            
            if (persons.Count != 0) 
            {
                for (int i = 0; i < persons.Count; i++)
                {
                    if (persons[i].PositionX - 85 < floors[0].PositionX) 
                    {
                       // g.DrawImage(Properties.Resources.person_emp, persons[i].PositionX, persons[i].PositionY);
                        persons.Remove(persons[i]);
                    }
                }
            }     
        }

        private void timerLift_Tick(object sender, EventArgs e)
        {
            if (lift.moveNext())
            {
                //g.DrawImage(Properties.Resources.lift_emp, lift.OldX, lift.OldY);
                g.DrawImage(Properties.Resources.lift, lift.PositionX, lift.PositionY);
            }
            else 
            {
                g.DrawImage(Properties.Resources.lift_open, lift.PositionX, lift.PositionY);
            }
        }

    }
}
