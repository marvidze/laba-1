using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_1
{
    public partial class CreateOneParametrObject : Form
    {
        public CreateOneParametrObject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox_name.Text;
            string Adress = textBox_adress.Text;
            float Rating = (float)numericUpDown_rating.Value;
            string Tel = textBox_tel.Text;
            int Books = (int)numericUpDown_books.Value;
            int Place = (int)numericUpDown_place.Value;
            Library.ObjectList.Add(new Library(Name, Adress, Tel, Rating, Books, Place));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
