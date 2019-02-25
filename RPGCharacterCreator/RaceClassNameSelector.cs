using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RPGCharacterCreator.Teacher;

namespace RPGCharacterCreator
{
    public enum RaceType
    {
        Argonian,
        Bretonian,
        Dwemer,
        Khajit,
        Nord,
        RedGuard
    }

    namespace Teacher
    {
        public class Player
        {
            public RaceType Race { get; set; }
            public IClass ClassImplementation { get; set; }
        }
    }

    public partial class RaceClassNameSelector : UserControl
    {
        public Player THEMOTH_RUSHER = new Player();

        public RaceClassNameSelector()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //setup individual controls in order
            raceDropdown.DropDownStyle = ComboBoxStyle.DropDownList;

            var races = Enum.GetValues(typeof(RaceType));
            foreach (var race in races) raceDropdown.Items.Add(race);

            //interface implementation req
            //by using interfaces instead of actual types like a scrub
            //we allow ourselves to add whatever concrete type we want for future you
            //be kind to your future self pleb
            classDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            var classes = new List<IClass>
            {
                new RPGClass {Name = "Ranger"}, new RPGClass {Name = "Mage"}
            };

            //linq foreach
            classes.ForEach(c => classDropdown.Items.Add(c.Name));
        }

        public void raceDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //do your checks and casts to prove you belong here
            var dropdown = sender as ComboBox;

            if (dropdown == null)
                return;

            if (dropdown != raceDropdown)
                return;
            

            THEMOTH_RUSHER.Race = (RaceType) dropdown.SelectedItem;
        }

        private void classDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //do your checks and casts to prove you belong here
            var dropdown = sender as ComboBox;

            if (dropdown == null)
                return;

            if (dropdown != classDropdown)
                return;
            

            THEMOTH_RUSHER.ClassImplementation = dropdown.SelectedItem as IClass;
        }
    }
}