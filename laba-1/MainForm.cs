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
        private static List<Library> objectList = new List<Library>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            objectList.Add(new Library("Library 1"));
            formObjectsList.Items.AddRange(objectList.ToArray());
        }

        private void buttonCreateObject_Click(object sender, EventArgs e)
        {

        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
