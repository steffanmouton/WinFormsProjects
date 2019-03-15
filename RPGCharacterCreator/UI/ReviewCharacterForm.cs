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
        public ReviewCharacterForm()
        {
            InitializeComponent();
        }

        private void ReviewCharacterForm_Load(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            Character c = Character.Instance;

            Program.Save(c, c.generateFileName());

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
