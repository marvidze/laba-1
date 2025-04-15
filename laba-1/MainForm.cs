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
        public static extern IntPtr MessageBox(IntPtr hWnd, string text, string caption, uint type);

        // Список экземпляров класса Library
        public static LibrariesList libraries = new LibrariesList();


        public MainForm()
        {
            InitializeComponent();

            libraries.OnAddingLibrary += library =>
            {
                formObjectsList.Items.Clear();
                formObjectsList.Items.AddRange(libraries.ToArray());
                formCountOfObjects.Text = Library.CountObjects.ToString();
            };

            libraries.OnDeletingLibrary += library =>
            {
                formObjectsList.Items.Clear();
                formObjectsList.Items.AddRange(libraries.ToArray());
                formCountOfObjects.Text = Library.CountObjects.ToString();
            };
        }

        private void ButtonCreateObjectAllParametr_Click(object sender, EventArgs e)
        {
            CreateOneParametrObject OneParametrForm = new CreateOneParametrObject();
            DialogResult result = OneParametrForm.ShowDialog();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonDeleteObject_Click(object sender, EventArgs e)
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
                Library.CountObjects -= 1;
                formCountOfObjects.Text = Library.CountObjects.ToString();
                formListInfoObject.Items.Clear();  
            }
            catch (Exception ex)
            {
                IntPtr window = this.Handle;
                MessageBox(window, $"{ex.Message}", "Ошибка", 0);
            }

        }

        private void ButtonShowAllParametrs_Click(object sender, EventArgs e)
        {
            try
            {
                Library a = (Library)formObjectsList.SelectedItem;
                string[] arr = {
                "Библиотека открыта? -> " + a.IsOpen,
                "Статус библиотеки: "+a.LevelLibrary,
                "Тип библиотеки: "+a.TypeLibrary.GetTypeLibrary(),
                "Название: "+a.Name,
                "Адрес: " + a.Addres,
                "Рейтинг: "+ a.Rating.ToString(),
                "Номер телефона: "+ a.NumberPhone.ToString(),
                "Количество книг: " + a.CountBooks.ToString(),
                "Количество мест в читальном зале: " + a.CountSeats.ToString()
                };
                formListInfoObject.Items.Clear();
                formListInfoObject.Items.AddRange(arr);
            }
            catch (LibraryException ex)
            {
                IntPtr window = this.Handle;
                MessageBox(window, $"{ex.Message}", "Ошибка", 0);
            }
            catch
            {
                IntPtr window = this.Handle;
                MessageBox(window, "Вы не выбрали объект!", "Ошибка", 0);
            }
        }

        private void Button_ChangeFields_Click(object sender, EventArgs e)
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
                IntPtr window = this.Handle;
                MessageBox(window, "Вы не выбрали объект!", "Ошибка", 0);
            }
        }
        
        private void ButtonCloseLibrary_Click(object sender, EventArgs e)
        {

        }
    }
}
