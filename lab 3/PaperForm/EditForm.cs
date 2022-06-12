using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedForm;
using PaperModel;

namespace PaperForm
{
    public partial class EditForm : Form
    {
        Sketchbook book = new Sketchbook();
        public EditForm(IPaper book)
        {
            InitializeComponent();
            if(book is Sketchbook)
                this.book = book as Sketchbook ?? throw new NullReferenceException();
            UpdatePropertyies();
        }

        private void UpdatePropertyies()
        {
            colorBox.Text = book.Color;
            priceBox.Text = book.Price.ToString();
            weightBox.Text = book.Weight.ToString();
            countBox.Text = book.CountOfSheet.ToString();
            idBox.Text = book.Id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputString form = new InputString("Введите цвет.");
            if(form.ShowDialog() == DialogResult.OK)
            {
                book.Paint(form.str);
                UpdatePropertyies();
            }
        }

        private void addSheetsButton_Click(object sender, EventArgs e)
        {
            InputInt form = new InputInt("Введите количество страниц.");
            if (form.ShowDialog() == DialogResult.OK)
            {
                book.AddSheet(form.number);
                UpdatePropertyies();
            }
        }

        private void deleteSheetsButton_Click(object sender, EventArgs e)
        {
            InputInt form = new InputInt("Введите количество страниц.");
            if (form.ShowDialog() == DialogResult.OK)
            {
                book.DeleteSheet(form.number);
                UpdatePropertyies();
            }
        }

        private void quallityButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Качевство данной тетради: " + book.Quallity().ToString(), "Качество", MessageBoxButtons.OK);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            double price;
            int count;
            double weight;
            int id;

            if(!double.TryParse(priceBox.Text, out price))
            {
                MessageBox.Show("Цена некорректна!", "Ошибка", MessageBoxButtons.OK);
            }
            else if(!double.TryParse(weightBox.Text, out weight))
            {
                MessageBox.Show("Вес некорректен!", "Ошибка", MessageBoxButtons.OK);
            }
            else if(!int.TryParse(countBox.Text, out count))
            {
                MessageBox.Show("Количество страниц некорректно!", "Ошибка", MessageBoxButtons.OK);
            }
            else if (!int.TryParse(idBox.Text, out id))
            {
                MessageBox.Show("Id некорректно!", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                book.Color = colorBox.Text;
                book.Price = price;
                book.CountOfSheet = count;
                book.Id = id;
                book.Weight = weight;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
