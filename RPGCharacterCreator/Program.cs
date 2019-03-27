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
            System.IO.Directory.CreateDirectory("SavedCharacters");

            var c = Character.Instance;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrimaryWindow());
        }
    }
}