using System;
using System.Windows.Forms;

namespace RPGCharacterCreator
{
    public partial class RaceClassNameForm : Form
    {
        /// <summary>
        /// Initial setup for the form. No touch.
        /// </summary>
        public RaceClassNameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method called upon loading form. Sets this form's parent to disabled
        /// so that it cannot be interacted with while this window is active.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RaceClassNameForm_Load(object sender, EventArgs e)
        {
            Owner.Enabled = false;
        }

        /// <summary>
        /// Method called upon clicking the Next button. Opens the StatForm window
        /// and sets this form to its parent.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            var statForm = new StatsForm();
            statForm.Owner = this;
            statForm.Show();
        }

        /// <summary>
        /// Method called upon this form closing. Makes its parent usable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RaceClassNameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }
    }
}
