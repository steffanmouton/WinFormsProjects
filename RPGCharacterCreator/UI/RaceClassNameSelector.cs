using System;
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

    public enum RaceType
    {
        Human,
        Elf,
        Dwarf,
        Orc,
        Tiefling,
        Halfling
    }

    public partial class RaceClassNameSelector : UserControl
    {
        public RaceClassNameSelector()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //creates array of race names using the enum declared above, then assigns them all to dropdown selector
            var races = Enum.GetValues(typeof(RaceType));
            foreach (var race in races) raceDropdown.Items.Add(race);

            //Creates a list of classes by their IName interface
            var classes = new List<IClass>
            {
                new RPGClass {Name = "Barbarian"}, new RPGClass {Name = "Bard"}, new RPGClass {Name = "Cleric"},
                new RPGClass {Name = "Druid"},
                new RPGClass {Name = "Fighter"}, new RPGClass {Name = "Monk"}, new RPGClass {Name = "Paladin"},
                new RPGClass {Name = "Ranger"},
                new RPGClass {Name = "Rogue"}, new RPGClass {Name = "Sorcerer"}, new RPGClass {Name = "Warlock"},
                new RPGClass {Name = "Wizard"}
            };
            classes.ForEach(c => classDropdown.Items.Add(c.Name));
        }

        private void raceDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dropdown = sender as ComboBox;

            if (dropdown == null)
                return;
            if (dropdown != raceDropdown)
                return;

            Character.Instance.CharRace = (RaceType) dropdown.SelectedItem;

        }

        private void classDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dropdown = sender as ComboBox;

            if (dropdown == null)
                return;

            if (dropdown != raceDropdown)
                return;

            Character.Instance.ClassImplementation = dropdown.SelectedItem as IClass;
            
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
