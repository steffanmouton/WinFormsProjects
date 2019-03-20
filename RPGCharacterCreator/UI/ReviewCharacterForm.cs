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
    public partial class ReviewCharacterForm : Form
    {
        /// <summary>
        /// Initial setup for the form. No touch.
        /// </summary>
        public ReviewCharacterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method called on loading this form. Disables usage of owner.
        /// Generates character Title and assigns it to the label.
        /// Calls the Update functions on custom control groups.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReviewCharacterForm_Load(object sender, EventArgs e)
        {
            Owner.Enabled = false;

            // Singleton load
            var c = Character.Instance;

            // Title, updated with character info
            var charName = c.Name;
            var raceName = c.CharRace.Name;
            var className = c.ClassImplementation.Name;
            var append = ", the ";
            var space = " ";
            var t = "";

            t += charName += append +=
                raceName += space += className;

            charTitle.Text = t;

            statBlockSelector1.UpdateStatBlockValues();
            raceClassNameSelector1.UpdateSelectorInfo();
        }

        /// <summary>
        /// Export the character as a json file, clear the Character singleton,
        /// return to Startup Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Character c = Character.Instance;

            c.Save(c, c.generateFileName());
            c.Clear();

            Owner.Enabled = true;

            Program.closeAll();
            
        }

        /// <summary>
        /// Restart the app, discarding all data entered and clearing Character
        /// singleton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Enabled = true;
            Program.closeAll();
        }

        /// <summary>
        /// On close of the Review Character form, Character Singleton values are
        /// reverted to default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReviewCharacterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var c = Character.Instance;
            c.Clear();
        }
    }
}
