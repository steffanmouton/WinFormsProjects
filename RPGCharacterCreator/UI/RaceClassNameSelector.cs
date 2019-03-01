using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGCharacterCreator
{

   
    public partial class RaceClassNameSelector : UserControl
    {
        public RaceClassNameSelector()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Program.races.ForEach(r => raceDropdown.Items.Add(r.Name));

            Program.classes.ForEach(c => classDropdown.Items.Add(c.Name));
        }

        private void raceDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dropdown = sender as ComboBox;

            if (dropdown == null)
                return;
            if (dropdown != raceDropdown)
                return;

            foreach (var race in Program.races)
            {
                if (dropdown.SelectedItem.ToString() == race.Name)
                {
                    Character.Instance.CharRace = race;
                    return;
                }
            }

        }

        private void classDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dropdown = sender as ComboBox;

            if (dropdown == null)
                return;

            if (dropdown != classDropdown)
                return;

            foreach (var thisClass in Program.classes)
            {
                if (dropdown.SelectedItem.ToString() == thisClass.Name)
                {
                    Character.Instance.ClassImplementation = thisClass;
                    return;
                }
            }
            
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;

            if (textbox == null)
                return;
            if (textbox != nameTextbox)
                return;

            Character.Instance.Name = textbox.Text;
        }
    }
}