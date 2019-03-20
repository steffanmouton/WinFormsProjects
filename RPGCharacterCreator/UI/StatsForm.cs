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
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reviewScr = new ReviewCharacterForm();
            reviewScr.Owner = this;
            reviewScr.ShowDialog();
        }

        private void StatsForm_Load(object sender, EventArgs e)
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

            characterLabel.Text = t;
        }
    }
}
