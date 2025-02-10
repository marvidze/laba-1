using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_1
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Library.ObjectList.Add(new Library());
            formObjectsList.Items.AddRange(Library.ObjectList.ToArray());
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonCreateObjectOneParametr_Click(object sender, EventArgs e)
        {
            CreateOneParametrObject OneParametrForm = new CreateOneParametrObject();
            DialogResult result = OneParametrForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                formObjectsList.Items.Clear();
                formObjectsList.Items.AddRange(Library.ObjectList.ToArray());
            }
        }
        private void buttonDeleteObject_Click(object sender, EventArgs e)
        {
            Library a = (Library)formObjectsList.SelectedItem;
            Library.ObjectList.Remove(a);
            a = null;
            formObjectsList.Items.Remove(formObjectsList.SelectedItem);
            formListInfoObject.Items.Clear();
            Library.CountOfObjects = --Library.CountOfObjects;
        }

        private void formListObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonShowAllParametrs_Click(object sender, EventArgs e)
        {
            Library a = (Library)formObjectsList.SelectedItem;
            string[] arr = { "Название: "+a.Name,
                "Адрес: " + a.Addres,
                "Рейтинг: "+ a.Rating.ToString(),
                "Номер телефона: "+ a.NumberOfPhone.ToString(),
                "Количество книг: " + a.CountOfBooks.ToString(),
                "Количество мест в читальном зале: " + a.CountOfSeats.ToString()};
            formListInfoObject.Items.Clear();
            formListInfoObject.Items.AddRange(arr);
        }

        private void buttonShowAdress_Click(object sender, EventArgs e)
        {
            Library a = (Library)formObjectsList.SelectedItem;
            formListInfoObject.Items.Clear();
            formListInfoObject.Items.Add("Адрес: "+a.Addres);
        }

        private void buttonShowNumberOfPhone_Click(object sender, EventArgs e)
        {
            Library a = (Library)formObjectsList.SelectedItem;
            formListInfoObject.Items.Clear();
            formListInfoObject.Items.Add("Номер телефона: " + a.NumberOfPhone);
        }

        private void buttonShowCountOfSeats_Click(object sender, EventArgs e)
        {
            Library a = (Library)formObjectsList.SelectedItem;
            formListInfoObject.Items.Clear();
            formListInfoObject.Items.Add("Количество мест в читальном зале: " + a.CountOfSeats);
        }

        private void buttonShowRating_Click(object sender, EventArgs e)
        {
            Library a = (Library)formObjectsList.SelectedItem;
            formListInfoObject.Items.Clear();
            formListInfoObject.Items.Add("Рейтинг: " + a.Rating);
        }

        private void buttonShowCountOfBooks_Click(object sender, EventArgs e)
        {
            Library a = (Library)formObjectsList.SelectedItem;
            formListInfoObject.Items.Clear();
            formListInfoObject.Items.Add("Количество книг: " + a.CountOfBooks);
        }
    }
}
