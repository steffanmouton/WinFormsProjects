using System;
using System.Windows.Forms;
using RPGCharacterCreator.UI;

namespace RPGCharacterCreator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var c = Character.Instance;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrimaryWindow());
        }

        /// <summary>
        /// static method to close all open window Forms down to
        /// Startup Form
        /// </summary>
        public static void closeAll()
        {
            FormCollection fc = Application.OpenForms;
            if (fc.Count > 1)
            {
                for (int i = (fc.Count); i > 1; i--)
                {
                    Form selectedForm = Application.OpenForms[i - 1];
                    selectedForm.Close();
                }
            }
        }
    }
}