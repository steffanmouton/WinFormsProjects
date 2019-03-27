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
        public PrimaryWindow()
        {
            InitializeComponent();
        }

       
        private void PrimaryWindow_Load(object sender, EventArgs e)
        {
            fullCharTitle.Text = Character.Instance.ReturnTitle();

            Character.Instance.onCharacterChanged += title => 
                { fullCharTitle.Text = Character.Instance.ReturnTitle(); };
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Character.Instance.Clear();
            raceClassNameSelector1.UpdateSelectorInfo();
        }

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

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Character.Instance.Save();
        }

        private void exportButton_Click(object sender, EventArgs e)
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
