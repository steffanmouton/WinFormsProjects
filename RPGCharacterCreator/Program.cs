using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Newtonsoft.Json;
using RPGCharacterCreator.UI;

namespace RPGCharacterCreator
{
    static class Program
    {
        

        

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

        public static string fileName = "Character.txt";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var c = Character.Instance;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartupForm());
        }
    }
}
