using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharedForm
{
    public partial class InputInt : Form
    {
        public int number;
        public InputInt(string labelText)
        {
            InitializeComponent();
            label1.Text = labelText;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBox.Text,out number))
            {
                MessageBox.Show("Некорректный ввод!", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
