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

namespace RPGCharacterCreator.UI
{
    public partial class PrimaryWindow : Form
    {
        /// <summary>
        /// Constructor for the form. NO TOUCH
        /// </summary>
        public PrimaryWindow()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// On loading the window, set the title display to default. Also, instantiate
        /// delegate to update title when character is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrimaryWindow_Load(object sender, EventArgs e)
        {
            fullCharTitle.Text = Character.Instance.ReturnTitle();

            Character.Instance.onCharacterChanged += title => 
                { fullCharTitle.Text = Character.Instance.ReturnTitle(); };
            
        }

        /// <summary>
        /// New character option. Clears the Character singleton, updates all text
        /// on the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Character.Instance.Clear();
            raceClassNameSelector1.UpdateSelectorInfo();
            statBlockGroupBox.UpdateStatBlockValues();
            
        }

        /// <summary>
        /// Load character option. Reads a JSON file and sets the character singleton
        /// to the data therein. Updates all shown data on form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
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
            }
            else if (result == DialogResult.Cancel)
            {
                dialog.Dispose();
            }
            else if (result == DialogResult.Abort)
            {
                dialog.Dispose();
            }

            raceClassNameSelector1.UpdateSelectorInfo();
            statBlockGroupBox.UpdateStatBlockValues();
        }

        /// <summary>
        /// Exits the application entirely.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Exports the Character as a JSON file, using character name as file name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportButton_Click(object sender, EventArgs e)
        {
            Character.Instance.Save();
        }

        /// <summary>
        /// Exports the Character as a JSON file, using character name as file name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportAsJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Character.Instance.Save();
        }
    }
}

// This is here for my future reference on good code structure.
/*public class NameUpdateReceiver
{
    public Label TargetLabel { get; set; }

    public NameUpdateReceiver(Character character)
    {
        character.onCharacterChanged += OnPlayerNameChanged;
    }

    public void OnPlayerNameChanged(Character character)
    {
        TargetLabel.Text = character.Name;
    }
}*/
