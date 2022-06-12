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
    public partial class ListForm : Form
    {
        List<IPaper> papers = new List<IPaper>(); 
        public ListForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            IPaper paper = new Sketchbook();
            EditForm editForm = new EditForm(paper);
            if(editForm.ShowDialog() == DialogResult.OK)
            {
                papers.Add(paper);
                listBox.Items.Add(paper);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                int selected = listBox.SelectedIndex;
                papers.RemoveAt(selected);
                listBox.Items.RemoveAt(selected);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            int selected = listBox.SelectedIndex;
            if (selected != -1)
            {
                EditForm editForm = new EditForm(papers[selected]);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    listBox.Items.RemoveAt(selected);
                    listBox.Items.Insert(selected, papers[selected]);
                }
            }
        }
    }
}
