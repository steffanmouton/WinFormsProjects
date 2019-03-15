namespace RPGCharacterCreator
{
    partial class StartupForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.editExistingButton = new System.Windows.Forms.Button();
            this.newCharButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is the RPG Character Creator.\r\nSelect \'New Character\' to create a new one, o" +
    "r Edit Existing to modify one\r\nthat was previously created.";
            // 
            // editExistingButton
            // 
            this.editExistingButton.Location = new System.Drawing.Point(223, 92);
            this.editExistingButton.Name = "editExistingButton";
            this.editExistingButton.Size = new System.Drawing.Size(134, 76);
            this.editExistingButton.TabIndex = 2;
            this.editExistingButton.Text = "Edit Existing";
            this.editExistingButton.UseVisualStyleBackColor = true;
            this.editExistingButton.Click += new System.EventHandler(this.editExistingButton_Click);
            // 
            // newCharButton
            // 
            this.newCharButton.Location = new System.Drawing.Point(33, 92);
            this.newCharButton.Name = "newCharButton";
            this.newCharButton.Size = new System.Drawing.Size(134, 76);
            this.newCharButton.TabIndex = 3;
            this.newCharButton.Text = "New Character";
            this.newCharButton.UseVisualStyleBackColor = true;
            this.newCharButton.Click += new System.EventHandler(this.newCharButton_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 207);
            this.Controls.Add(this.newCharButton);
            this.Controls.Add(this.editExistingButton);
            this.Controls.Add(this.label1);
            this.Name = "StartupForm";
            this.Text = "StartupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editExistingButton;
        private System.Windows.Forms.Button newCharButton;
    }
}