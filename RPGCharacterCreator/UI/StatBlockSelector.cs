using System;
using System.Windows.Forms;

namespace RPGCharacterCreator
{
    public delegate void OnStatChanged( object obj);
    
    public partial class StatBlockSelector : UserControl
    {
        /// <summary>
        /// Default constructor. NO TOUCH
        /// </summary>
        public StatBlockSelector()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Sets stat value on character and updates the Mod value displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var strControl = sender as NumericUpDown;

            if (strControl == null)
                return;
            if (strControl != strUpDown)
                return;

            Character.Instance.StatBlock["STR"].StatVal = (int)strControl.Value;
            strMod.Text = Character.Instance.StatBlock["STR"].Mod.ToString();
        }

        /// <summary>
        /// Sets stat value on character and updates the Mod value displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            var dexControl = sender as NumericUpDown;

            if (dexControl == null)
                return;
            if (dexControl != dexUpDown)
                return;

            Character.Instance.StatBlock["DEX"].StatVal = (int)dexControl.Value;
            dexMod.Text = Character.Instance.StatBlock["DEX"].Mod.ToString();
        }

        /// <summary>
        /// Sets stat value on character and updates the Mod value displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            var conControl = sender as NumericUpDown;

            if (conControl == null)
                return;
            if (conControl != conUpDown)
                return;

            Character.Instance.StatBlock["CON"].StatVal = (int)conControl.Value;
            conMod.Text = Character.Instance.StatBlock["CON"].Mod.ToString();
        }

        /// <summary>
        /// Sets stat value on character and updates the Mod value displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            var intControl = sender as NumericUpDown;

            if (intControl == null)
                return;
            if (intControl != intUpDown)
                return;

            Character.Instance.StatBlock["INT"].StatVal = (int)intControl.Value;
            intMod.Text = Character.Instance.StatBlock["INT"].Mod.ToString();
        }

        /// <summary>
        /// Sets stat value on character and updates the Mod value displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            var wisControl = sender as NumericUpDown;

            if (wisControl == null)
                return;
            if (wisControl != wisUpDown)
                return;

            Character.Instance.StatBlock["WIS"].StatVal = (int)wisControl.Value;
            wisMod.Text = Character.Instance.StatBlock["WIS"].Mod.ToString();
        }

        /// <summary>
        /// Sets stat value on character and updates the Mod value displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            var chaControl = sender as NumericUpDown;

            if (chaControl == null)
                return;
            if (chaControl != chaUpDown)
                return;

            Character.Instance.StatBlock["CHA"].StatVal = (int)chaControl.Value;
            chaMod.Text = Character.Instance.StatBlock["CHA"].Mod.ToString();
        }

        /// <summary>
        /// On Load, reflect current values of the Character Singleton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatBlockSelector_Load(object sender, EventArgs e)
        {
            UpdateStatBlockValues();
        }

        /// <summary>
        /// Update function to be called when character values change.
        /// </summary>
        public void UpdateStatBlockValues()
        {
            strMod.Text = Character.Instance.StatBlock["STR"].Mod.ToString();
            dexMod.Text = Character.Instance.StatBlock["DEX"].Mod.ToString();
            conMod.Text = Character.Instance.StatBlock["CON"].Mod.ToString();
            intMod.Text = Character.Instance.StatBlock["INT"].Mod.ToString();
            wisMod.Text = Character.Instance.StatBlock["WIS"].Mod.ToString();
            chaMod.Text = Character.Instance.StatBlock["CHA"].Mod.ToString();

            strUpDown.Text = Character.Instance.StatBlock["STR"].StatVal.ToString();
            dexUpDown.Text = Character.Instance.StatBlock["DEX"].StatVal.ToString();
            conUpDown.Text = Character.Instance.StatBlock["CON"].StatVal.ToString();
            intUpDown.Text = Character.Instance.StatBlock["INT"].StatVal.ToString();
            wisUpDown.Text = Character.Instance.StatBlock["WIS"].StatVal.ToString();
            chaUpDown.Text = Character.Instance.StatBlock["CHA"].StatVal.ToString();
        }

    }
}
