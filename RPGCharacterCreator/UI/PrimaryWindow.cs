using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGCharacterCreator.UI
{
    public partial class PrimaryWindow : Form
    {
        public PrimaryWindow()
        {
            InitializeComponent();
        }

        public class NameUpdateReceiver
        {
            public Label TargetLabel { get; set; }

            public NameUpdateReceiver(Character character)
            {
                character.onCharacterChanged += OnPlayerNameChanged;
            }

            public void OnPlayerNameChanged(Character character)
            {
                TargetLabel.Text = character.Name;
            }
        }

        
        private void PrimaryWindow_Load(object sender, EventArgs e)
        {
            fullCharTitle.Text = Character.Instance.ReturnTitle();
            Character.Instance.onCharacterChanged += character => 
                { fullCharTitle.Text = Character.Instance.ReturnTitle(); };
            
        }
        
    }
}
