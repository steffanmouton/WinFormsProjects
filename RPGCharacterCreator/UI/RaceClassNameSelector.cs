using System;
using System.Windows.Forms;

namespace RPGCharacterCreator
{
    public partial class RaceClassNameSelector : UserControl
    {
        /// <summary>
        /// Initial setup for the form. No touch.
        /// </summary>
        public RaceClassNameSelector()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Method called on changing the Selected index of the Race dropdown.
        /// Assigns the Character Singleton's Race to the race selected from the dropdown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void raceDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dropdown = sender as ComboBox;

            if (dropdown == null)
                return;
            if (dropdown != raceDropdown)
                return;
            if (dropdown.SelectedItem == null)
                return;

            foreach (var race in SourceData.races)
            {
                if (dropdown.SelectedItem.ToString() == race.Name)
                {
                    Character.Instance.CharRace = race;
                    return;
                }
            }
        }

        /// <summary>
        /// Method called on changing the Selected index of the class dropdown.
        /// Assigns the Character Singleton's Class to the class selected from the dropdown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void classDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dropdown = sender as ComboBox;

            if (dropdown == null)
                return;

            if (dropdown != classDropdown)
                return;

            if (dropdown.SelectedItem == null)
                return;

            foreach (var thisClass in SourceData.classes)
            {
                if (dropdown.SelectedItem.ToString() == thisClass.Name)
                {
                    Character.Instance.ClassImplementation = thisClass;
                    return;
                }
            }
        }

        /// <summary>
        /// Method Called on making a change to the Name Textbox. Assigns the current text in
        /// the Textbox to the Character Singleton's Name property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameTextbox_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;

            if (textbox == null)
                return;
            if (textbox != nameTextbox)
                return;

            Character.Instance.Name = textbox.Text;
        }

        /// <summary>
        /// Method to be called on loading the ReviewCharacter form. Fills the controls
        /// with data reflected the Character singleton.
        /// </summary>
        public void UpdateSelectorInfo()
        {
            Character c = Character.Instance;

            nameTextbox.Text = c.Name;

            raceDropdown.SelectedIndex = raceDropdown.FindString(c.CharRace.Name);
            classDropdown.SelectedIndex = classDropdown.FindString(c.ClassImplementation.Name);
        }


        private void RaceClassNameSelector_Load(object sender, EventArgs e)
        {
            var character = Character.Instance;

            SourceData.races.ForEach(r => raceDropdown.Items.Add(r.Name));
            raceDropdown.SelectedIndex = raceDropdown.FindString(character.CharRace.Name);

            SourceData.classes.ForEach(c => classDropdown.Items.Add(c.Name));
            classDropdown.SelectedIndex = classDropdown.FindString(character.ClassImplementation.Name);
        }
    }
}