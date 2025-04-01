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
        private string defaultName = "Библиотека №" + (Library.CountObjects + 1);
        private string defaultAdress = "0";
        private float defaultRating = 0;
        private string defaultTel = "0";
        private int defaultBooks = 0;
        private int defaultPlace = 0;
        private string defaultType = "0";
        private string defaultLevel = "0";


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
            defaultTel = item.NumberPhone;
            defaultBooks = item.CountBooks;
            defaultPlace = item.CountSeats;
            defaultType = item.TypeLibrary.GetTypeLibrary();
            defaultLevel = item.LevelLibrary;
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
            comboBox_level_library.Items.Add("Главное здание");
            comboBox_level_library.Items.Add("Филиал");
            comboBox_level_library.SelectedItem = comboBox_level_library.Items[0];
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
            string levelLibrary = comboBox_level_library.SelectedItem.ToString();

            ItypeLibrary artLibrary = new ArtLibrary();
            ItypeLibrary techLibrary = new TechnicalLibrary();
            Library library = null;
            if (levelLibrary == "Главное здание")
            {
                switch (typeOfLibrary)
                {
                    case "Техническая":
                        library = new MainLibrary(Adress, Tel, Rating, Books, Place, techLibrary, levelLibrary, Name);
                        break;
                    case "Художественная":
                        library = new MainLibrary(Adress, Tel, Rating, Books, Place, artLibrary, levelLibrary, Name);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (typeOfLibrary)
                {
                    case "Техническая":
                        library = new FilialLibrary(Adress, Tel, Rating, Books, Place, techLibrary, levelLibrary, Name);
                        break;
                    case "Художественная":
                        library = new FilialLibrary(Adress, Tel, Rating, Books, Place, artLibrary, levelLibrary, Name);
                        break;
                    default:
                        break;
                }
            }

            MainForm.libraries.Add(library);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            _item.Name = textBox_name.Text;
            _item.Addres = textBox_adress.Text;
            _item.Rating = (float)numericUpDown_rating.Value;
            _item.NumberPhone = textBox_tel.Text;
            _item.CountBooks = (int)numericUpDown_books.Value;
            _item.CountSeats = (int)numericUpDown_place.Value;
            _item.LevelLibrary = comboBox_level_library.Text;
            if (comboBox_type_library.Text == "Техническая")
            {
                ItypeLibrary techLibrary = new TechnicalLibrary();
                _item.TypeLibrary = techLibrary;
            }
            else
            {
                ItypeLibrary artLibrary = new ArtLibrary();
                _item.TypeLibrary = artLibrary;
            }


                ////////////////////////////////////////////////////////////////////////////////////////// comboBox

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
