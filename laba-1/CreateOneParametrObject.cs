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
        private Library _item;
        private string defaultName = "Библиотека №" + (Library.CountOfObjects+1);
        private string defaultAdress = "0";
        private float defaultRating = 0;
        private string defaultTel = "0";
        private int defaultBooks = 0;
        private int defaultPlace = 0;
        private LibraryDirector director  = new LibraryDirector();

        public CreateOneParametrObject()
        {
            InitializeComponent();
            button_change.Hide();
        }

        public CreateOneParametrObject(Library item)
        {
            InitializeComponent();
            _item = item;
            defaultName = item.Name;
            defaultAdress = item.Addres;
            defaultRating = item.Rating;
            defaultTel = item.NumberOfPhone;
            defaultBooks = item.CountOfBooks;
            defaultPlace = item.CountOfSeats;
            button_createObject.Hide();
        }

        private void CreateOneParametrObject_Load(object sender, EventArgs e)
        {
            textBox_name.Text = defaultName;
            textBox_adress.Text = defaultAdress;
            numericUpDown_rating.Value = (decimal)defaultRating;
            textBox_tel.Text = defaultTel;
            numericUpDown_books.Value = defaultBooks;
            numericUpDown_place.Value = defaultPlace;
            comboBox_type_library.Items.Add("Техническая");
            comboBox_type_library.Items.Add("Художественная");
            comboBox_type_library.SelectedItem = comboBox_type_library.Items[0];
        }

        private void button_createObject_Click(object sender, EventArgs e)
        {
            string Name = textBox_name.Text;
            string Adress = textBox_adress.Text;
            float Rating = (float)numericUpDown_rating.Value;
            string Tel = textBox_tel.Text;
            int Books = (int)numericUpDown_books.Value;
            int Place = (int)numericUpDown_place.Value;
            string typeOfLibrary = comboBox_type_library.SelectedItem.ToString();
            ILibraryBuilder builder;

            switch (typeOfLibrary)
            {
                case "Техническая":
                    builder = new TechnicalLibraryBuilder();
                    break;
                case "Художественная":
                    builder = new ArtLibraryBuilder();
                    break;
                default:
                    builder = new TechnicalLibraryBuilder();
                    break;
            }

            director.SetBuilder(builder);
            Library library = director.ConstructLibrary(Name, Adress, Tel, Rating, Books, Place);
            MainForm.libraries.Add(library);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            _item.Name = textBox_name.Text;
            _item.Addres = textBox_adress.Text;
            _item.Rating = (float)numericUpDown_rating.Value;
            _item.NumberOfPhone = textBox_tel.Text;
            _item.CountOfBooks = (int)numericUpDown_books.Value;
            _item.CountOfSeats = (int)numericUpDown_place.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_closeForm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
