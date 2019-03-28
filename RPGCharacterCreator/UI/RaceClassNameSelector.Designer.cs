namespace RPGCharacterCreator
{
    partial class RaceClassNameSelector
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.charDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.classDropdown = new System.Windows.Forms.ComboBox();
            this.raceDropdown = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.charDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // charDetailsGroupBox
            // 
            this.charDetailsGroupBox.Controls.Add(this.nameTextbox);
            this.charDetailsGroupBox.Controls.Add(this.classDropdown);
            this.charDetailsGroupBox.Controls.Add(this.raceDropdown);
            this.charDetailsGroupBox.Controls.Add(this.nameLabel);
            this.charDetailsGroupBox.Controls.Add(this.classLabel);
            this.charDetailsGroupBox.Controls.Add(this.raceLabel);
            this.charDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charDetailsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.charDetailsGroupBox.Name = "charDetailsGroupBox";
            this.charDetailsGroupBox.Size = new System.Drawing.Size(194, 121);
            this.charDetailsGroupBox.TabIndex = 0;
            this.charDetailsGroupBox.TabStop = false;
            this.charDetailsGroupBox.Text = "Character Details";
            this.myToolTip.SetToolTip(this.charDetailsGroupBox, "Choose your character details below.");
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(48, 20);
            this.nameTextbox.MaxLength = 32;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(121, 21);
            this.nameTextbox.TabIndex = 0;
            this.nameTextbox.TextChanged += new System.EventHandler(this.nameTextbox_TextChanged);
            // 
            // classDropdown
            // 
            this.classDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classDropdown.FormattingEnabled = true;
            this.classDropdown.Location = new System.Drawing.Point(48, 85);
            this.classDropdown.Name = "classDropdown";
            this.classDropdown.Size = new System.Drawing.Size(121, 23);
            this.classDropdown.TabIndex = 2;
            this.classDropdown.SelectedIndexChanged += new System.EventHandler(this.classDropdown_SelectedIndexChanged);
            // 
            // raceDropdown
            // 
            this.raceDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raceDropdown.FormattingEnabled = true;
            this.raceDropdown.Location = new System.Drawing.Point(48, 52);
            this.raceDropdown.Name = "raceDropdown";
            this.raceDropdown.Size = new System.Drawing.Size(121, 23);
            this.raceDropdown.TabIndex = 1;
            this.raceDropdown.SelectedIndexChanged += new System.EventHandler(this.raceDropdown_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            this.myToolTip.SetToolTip(this.nameLabel, "Your character name. You know what a name is, right?");
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(7, 88);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(37, 15);
            this.classLabel.TabIndex = 1;
            this.classLabel.Text = "Class";
            this.myToolTip.SetToolTip(this.classLabel, "Choose a class. This determines your skills as a professional adventurer.\r\nYour c" +
        "ombat abilities and spells in particular are defined by your class.");
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Location = new System.Drawing.Point(7, 55);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(36, 15);
            this.raceLabel.TabIndex = 0;
            this.raceLabel.Text = "Race";
            this.myToolTip.SetToolTip(this.raceLabel, "Choose a character Race. This might define your character background,\r\nrelations " +
        "to other races, and potentially skill checks.");
            // 
            // RaceClassNameSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.charDetailsGroupBox);
            this.Name = "RaceClassNameSelector";
            this.Size = new System.Drawing.Size(203, 130);
            this.Load += new System.EventHandler(this.RaceClassNameSelector_Load);
            this.charDetailsGroupBox.ResumeLayout(false);
            this.charDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox charDetailsGroupBox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.ComboBox classDropdown;
        private System.Windows.Forms.ComboBox raceDropdown;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.ToolTip myToolTip;
    }
}
