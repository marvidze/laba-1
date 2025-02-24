using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace laba_1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            WelcomeForm welcomeForm = new WelcomeForm();
            Application.Run(welcomeForm);

            LIBRARY mainForm = new LIBRARY();
            Application.Run(mainForm);
        }
    }
}
