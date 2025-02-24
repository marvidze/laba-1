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
    public partial class LIBRARY : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void SetWindowText(int hWnd, String text);
        public LIBRARY()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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
                formCountOfObjects.Text = Library.CountOfObjects.ToString();
            }
        }

        private void buttonDeleteObject_Click(object sender, EventArgs e)
        {
            Library a = (Library)formObjectsList.SelectedItem;
            if (a == null)
            {
                MessageBox.Show("Вы не выбрали объект!");
                return;
            }
            Library.ObjectList.Remove(a);
            a = null;
            formObjectsList.Items.Remove(formObjectsList.SelectedItem);
            formListInfoObject.Items.Clear();
            Library.CountOfObjects = --Library.CountOfObjects;
            formCountOfObjects.Text = Library.CountOfObjects.ToString();
        }

        private void buttonShowAllParametrs_Click(object sender, EventArgs e)
        {
            try
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
            catch (LibraryException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Вы не выбрали объект!");
            }
        }

        private void buttonShowAdress_Click(object sender, EventArgs e)
        {
            try
            {
                Library a = (Library)formObjectsList.SelectedItem;
                formListInfoObject.Items.Clear();
                formListInfoObject.Items.Add("Адрес: " + a.Addres);
            }
            catch (LibraryException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Вы не выбрали объект!");
            }

        }

        private void buttonShowNumberOfPhone_Click(object sender, EventArgs e)
        {
            try
            {
                Library a = (Library)formObjectsList.SelectedItem;
                formListInfoObject.Items.Clear();
                formListInfoObject.Items.Add("Номер телефона: " + a.NumberOfPhone);
            }
            catch (LibraryException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Вы не выбрали объект!");
            }
        }

        private void buttonShowCountOfSeats_Click(object sender, EventArgs e)
        {
            try
            {
                Library a = (Library)formObjectsList.SelectedItem;
                formListInfoObject.Items.Clear();
                formListInfoObject.Items.Add("Количество мест в читальном зале: " + a.CountOfSeats);
            }
            catch
            {
                try
                {
                    Library a = (Library)formObjectsList.SelectedItem;
                    formListInfoObject.Items.Clear();
                    formListInfoObject.Items.Add("Количество книг: " + a.CountOfBooks);
                }
                catch
                {
                    MessageBox.Show("Вы не выбрали объект!");
                }
            }
        }

        private void buttonShowRating_Click(object sender, EventArgs e)
        {
            try
            {
                Library a = (Library)formObjectsList.SelectedItem;
                formListInfoObject.Items.Clear();
                formListInfoObject.Items.Add("Рейтинг: " + a.Rating);
            }
            catch
            {
                MessageBox.Show("Вы не выбрали объект!");
            }
        }

        private void buttonShowCountOfBooks_Click(object sender, EventArgs e)
        {
            try
            {
                Library a = (Library)formObjectsList.SelectedItem;
                formListInfoObject.Items.Clear();
                formListInfoObject.Items.Add("Количество книг: " + a.CountOfBooks);
            }
            catch
            {
                MessageBox.Show("Вы не выбрали объект!");
            }
        }

        private void button_ChangeFields_Click(object sender, EventArgs e)
        {
            try
            {
                Library item = (Library)formObjectsList.SelectedItem;
                CreateOneParametrObject OneParametrForm = new CreateOneParametrObject(item);
                DialogResult result = OneParametrForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formObjectsList.Items.Clear();
                    formObjectsList.Items.AddRange(Library.ObjectList.ToArray());
                    Library a = (Library)formObjectsList.SelectedItem;
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали объект!");
            }
        }

        private void button_DontClick_Click(object sender, EventArgs e)
        {
            try
            {
                Library.IWantToException(0);
            }
            catch (StackOverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
