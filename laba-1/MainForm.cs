using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace laba_1
{
    public partial class MainForm : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void SetWindowText(int hWnd, String text);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, string text, string caption, uint type);

        // Список экземпляров класса Library
        public static LibrariesList libraries = new LibrariesList();
        public MainForm()
        {
            InitializeComponent();

            libraries.OnAddingLibrary += () =>
            {
                formObjectsList.Items.Clear();
                formObjectsList.Items.AddRange(libraries.ToArray());
                formCountOfObjects.Text = Library.CountOfObjects.ToString();
            };

            libraries.OnDeletingLibrary += () =>
            {
                formObjectsList.Items.Clear();
                formObjectsList.Items.AddRange(libraries.ToArray());
                formCountOfObjects.Text = Library.CountOfObjects.ToString();
            };
        }

        private void buttonCreateObjectAllParametr_Click(object sender, EventArgs e)
        {
            CreateOneParametrObject OneParametrForm = new CreateOneParametrObject();
            DialogResult result = OneParametrForm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDeleteObject_Click(object sender, EventArgs e)
        {
            Library a = (Library)formObjectsList.SelectedItem;
            try
            {
                if (a == null)
                {
                    throw new Exception("Вы не выбрали объект ");
                }
                libraries.Remove(a);
                a = null;
                Library.CountOfObjects -= 1;
                formCountOfObjects.Text = Library.CountOfObjects.ToString();
            }
            catch (Exception ex)
            {
                MessageBox(0, $"{ex.Message}", "Ошибка", 0);
            }

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
                MessageBox(0, $"{ex.Message}", "Ошибка", 0);
            }
            catch
            {
                MessageBox(0, "Вы не выбрали объект!", "Ошибка", 5);
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
                MessageBox(0, $"{ex.Message}", "Ошибка", 0);
            }
            catch
            {
                MessageBox(0, "Вы не выбрали объект!", "Ошибка", 0);
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
                MessageBox(0, $"{ex.Message}", "Ошибка", 0);
            }
            catch
            {
                MessageBox(0, "Вы не выбрали объект!", "Ошибка", 0);
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
                    MessageBox(0, "Вы не выбрали объект!", "Ошибка", 0);
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
                MessageBox(0, "Вы не выбрали объект!", "Ошибка", 0);
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
                MessageBox(0, "Вы не выбрали объект!", "Ошибка", 0);
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
                    formObjectsList.Items.AddRange(libraries.ToArray());
                    Library a = (Library)formObjectsList.SelectedItem;
                }
            }
            catch
            {
                MessageBox(0, "Вы не выбрали объект!", "Ошибка", 0);
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
                MessageBox(0, $"{ex.Message}", "Ошибка", 0);
            }
        }

        private void button_compare_Click(object sender, EventArgs e)
        {
            int size = 1000000;

            LibrariesList librariesListCompare = new LibrariesList();
            Array librariesArrayCompare = Array.CreateInstance(typeof(Library), size);

            int startTimeList = Environment.TickCount;
            {
                for (int i = 0; i < size; i++)
                {
                    librariesListCompare.Add(new Library());
                }
            }
            int ResultTimeList = Environment.TickCount - startTimeList;

            int startTimeArray = Environment.TickCount;
            {
                for (int i = 0; i < size; i++)
                {
                    librariesArrayCompare.SetValue(new Library(), i);
                }
            }
            int ResultTimeArray = Environment.TickCount - startTimeArray;


            int startTimeListSequential = Environment.TickCount;
            {
                for (int i = 0; i < size; i++)
                {
                    var item = librariesListCompare[i];
                }
            }
            int ResultTimeListSequential = Environment.TickCount - startTimeListSequential;

            int startTimeArraySequential = Environment.TickCount;
            for (int i = 0; i < size; i++)
            {
                var item = librariesArrayCompare.GetValue(i);
            }
            int ResultTimeArraySequential = Environment.TickCount - startTimeArraySequential;

            Random random = new Random();
            int startTimeListRandom = Environment.TickCount;
            {
                for (int i = 0; i < size; i++)
                {
                    int randomIndex = random.Next(0, size);
                    var item = librariesListCompare[randomIndex];
                }
            }
            int ResultTimeListRandom = Environment.TickCount - startTimeListRandom;

            int startTimeArrayRandom = Environment.TickCount;
            {
                for (int i = 0; i < size; i++)
                {
                    int randomIndex = random.Next(0, size);
                    var item = librariesArrayCompare.GetValue(randomIndex);
                }
            }
            int ResultTimeArrayRandom = Environment.TickCount - startTimeArrayRandom;

            richTextBox_CompareTime.Text = "Было создано 100 000 объектов\n" +
                                           "Время заполнения Array: " + ResultTimeArray + " мс\n" +
                                           "Время заполнения LibrariesList: " + ResultTimeList + " мс\n\n" +
                                           "Время последовательной выборки из Array: " + ResultTimeArraySequential + " мс\n" +
                                           "Время последовательной выборки из LibrariesList: " + ResultTimeListSequential + " мс\n\n" +
                                           "Время случайной выборки из Array: " + ResultTimeArrayRandom + " мс\n" +
                                           "Время случайной выборки из LibrariesList: " + ResultTimeListRandom + " мс";
            formCountOfObjects.Text = Library.CountOfObjects.ToString();
        }
    }
}
