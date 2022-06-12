using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarModel;
namespace CarForm
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double power;
            int count;

            double powerChild;
            int countChild;
            int year;

            if (!double.TryParse(powerBox.Text,out power) 
                || !double.TryParse(childPowerBox.Text, out powerChild))
            {
                MessageBox.Show("Некорректный ввод мощности!");
            }
            else if(!int.TryParse(seatsBox.Text,out count) ||
                !int.TryParse(childSeatsBox.Text, out countChild))
            {
                MessageBox.Show("Некорректный ввод количества мест!");
            }
            else if(!int.TryParse(yearBox.Text, out year))
            {
                MessageBox.Show("Некорректный ввод года!");
            }
            else
            {
                Car car = new Car(markBox.Text, power, count);
                CarChild child = new CarChild(childMarkBox.Text, powerChild, countChild, year);
                InfoForm form = new InfoForm(car, child);
                form.ShowDialog();
                this.Close();
            }
            
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
