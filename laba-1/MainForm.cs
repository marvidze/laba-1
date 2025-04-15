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

        private static LibraryManager libraryManager = new LibraryManager();
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
            ShowAllParametrs(OneParametrForm._item);

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonDeleteObject_Click(object sender, EventArgs e)
        {
            
            try
            {
                Library a = (Library)formObjectsList.SelectedItem ?? throw new Exception("Вы не выбрали объект ");
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
                Library a = (Library)formObjectsList.SelectedItem ?? throw new Exception("Вы не выбрали объект!");
                ShowAllParametrs(a);
            }
            catch (LibraryException ex)
            {
                IntPtr window = this.Handle;
                MessageBox(window, $"{ex.Message}", "Ошибка", 0);
            }
         
        }

        private void Button_ChangeFields_Click(object sender, EventArgs e)
        {
            try
            {
                Library item = (Library)formObjectsList.SelectedItem ?? throw new Exception("Вы не выбрали объект!");
                CreateOneParametrObject OneParametrForm = new CreateOneParametrObject(item);
                DialogResult result = OneParametrForm.ShowDialog();
                ShowAllParametrs(item);
            }
            catch(Exception ex)
            {
                IntPtr window = this.Handle;
                MessageBox(window, ex.Message, "Ошибка", 0);
            }
        }
        
        private void ButtonCloseLibrary_Click(object sender, EventArgs e)
        {
            try
            {
                Library item = (Library)formObjectsList.SelectedItem ?? throw new Exception("Вы не выбрали объект!");
                var closeLibraryCommand = new CloseLibraryCommand(item);
                libraryManager.ExecuteCommand(closeLibraryCommand);
                ShowAllParametrs(item);
            }
            catch (Exception ex)
            {
                IntPtr window = this.Handle;
                MessageBox(window, ex.Message, "Ошибка", 0);
            }
        }

        private void ButtonOpenLibrary_Click(object sender, EventArgs e)
        {
            try
            {
                Library item = (Library)formObjectsList.SelectedItem ?? throw new Exception("Вы не выбрали объект!");
                var openLibraryCommand = new OpenLibraryCommand(item);
                libraryManager.ExecuteCommand(openLibraryCommand);
                ShowAllParametrs(item);
            }
            catch (Exception ex)
            {
                IntPtr window = this.Handle;
                MessageBox(window, ex.Message, "Ошибка", 0);
            }
        }

        private void ButtonUndoAction_Click(object sender, EventArgs e)
        {
            try
            {
                Library item = (Library)formObjectsList.SelectedItem;
                if (libraryManager.UndoLastCommand()) ShowAllParametrs(item);
                else throw new Exception("Стек последних комманд пуст!");
            }catch(Exception ex)
            {
                IntPtr window = this.Handle;
                MessageBox(window, ex.Message, "Ошибка", 0);
            }
        }

        private void ShowAllParametrs(Library a)
        {
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

        private void formObjectsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Library item = (Library)formObjectsList.SelectedItem;
            ShowAllParametrs(item);
        }
    }
}
