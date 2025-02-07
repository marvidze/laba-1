﻿using System;
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
            Library.objectList.Add(new Library());
            formObjectsList.Items.AddRange(Library.objectList.ToArray());
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonCreateObjectOneParametr_Click(object sender, EventArgs e)
        {
            Library.objectList.Add(new Library());
            formObjectsList.Items.Clear();
            formObjectsList.Items.AddRange(Library.objectList.ToArray());
        }
        private void buttonCreateObjectNullRapametr_Click(object sender, EventArgs e)
        {
            Library.objectList.Add(new Library());
            formObjectsList.Items.Clear();
            formObjectsList.Items.AddRange(Library.objectList.ToArray());
        }
        private void buttonCreateObjectTwoRapametr_Click(object sender, EventArgs e)
        {
            Library.objectList.Add(new Library());
            formObjectsList.Items.Clear();
            formObjectsList.Items.AddRange(Library.objectList.ToArray());
        }

        private void buttonCreateObjectAllRapametrs_Click(object sender, EventArgs e)
        {
            Library.objectList.Add(new Library());
            formObjectsList.Items.Clear();
            formObjectsList.Items.AddRange(Library.objectList.ToArray());
        }
        private void buttonDeleteObject_Click(object sender, EventArgs e)
        {
            Library a = (Library)formObjectsList.SelectedItem;
            Library.objectList.Remove(a);
            a = null;
            formObjectsList.Items.Remove(formObjectsList.SelectedItem);
        }

        private void formListObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Library a = (Library)formObjectsList.SelectedItem;
            //string[] arr = { "Название: "+a.Name,
            //    "Адрес: " + a.Addres,
            //    "Рейтинг: "+ a.Rating.ToString(),
            //    "Номер телефона: "+ a.NumberOfPhone.ToString(),
            //    "Количество книг: " + a.CountOfBooks.ToString(),
            //    "Количество мест в читальном зале: " + a.CountOfSeats.ToString()};
            //formListInfoObject.Items.Clear();
            //formListInfoObject.Items.AddRange(arr);
        }
    }
}
