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
        /// <summary>
        /// Initial setup for the form. No touch.
        /// </summary>
        public StartupForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clicking the new character button opens the RaceClassName Form and
        /// makes it the child of this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newCharButton_Click(object sender, EventArgs e)
        {
            var raceForm = new RaceClassNameForm();
            raceForm.Owner = this;
            raceForm.Show();
        }

        /// <summary>
        /// Clicking the Edit Existing button opens the OpenFileDialog, defaulting
        /// to the path of the application exe, as defined by the FileSelector Instance.
        /// Selecting a .json file will select it for the Character Load method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editExistingButton_Click(object sender, EventArgs e)
        {
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
                reviewForm.Owner = this;
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
