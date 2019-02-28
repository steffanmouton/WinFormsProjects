using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
