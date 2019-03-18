using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGCharacterCreator.UI;

namespace RPGCharacterCreator
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clicking the new character button opens the Race Class Name Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newCharButton_Click(object sender, EventArgs e)
        {
            var raceForm = new RaceClassNameForm();
            raceForm.Show();
        }

        private void editExistingButton_Click(object sender, EventArgs e)
        {
            // TODO: MAKE DIALOG WINDOW WORK
            var c = Character.Instance;
            var fs = FileSelector.Instance;
            
            var dialog = new OpenFileDialog();

            dialog.InitialDirectory = fs.defaultFilePath;
            dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                fs.selectedFilePath = dialog.FileName;
                fs.selectedFileData = File.ReadAllText(fs.selectedFilePath);

                c.Load();

                var reviewForm = new ReviewCharacterForm();
                reviewForm.Show();
            }
            else if (result == DialogResult.Cancel)
            {
                dialog.Dispose();
            }
            else if (result == DialogResult.Abort)
            {
                dialog.Dispose();
            }

            
        }
    }
}
