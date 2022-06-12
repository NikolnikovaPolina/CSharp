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
    
    public partial class InfoForm : Form
    {
        Car Car;
        CarChild Child;
        public InfoForm(Car car, CarChild child)
        {
            InitializeComponent();
            Car = car;
            Child = child;
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"Информация о {Car.Mark}";
            label2.Text = $"Информация о {Child.Mark}";

            textBoxParent.Text = Car.ToString();
            textBoxChild.Text = Child.ToString();
        }
    }
}
