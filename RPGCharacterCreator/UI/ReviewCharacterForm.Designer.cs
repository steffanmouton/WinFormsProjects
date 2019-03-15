namespace RPGCharacterCreator
{
    partial class ReviewCharacterForm
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
            this.charTitle = new System.Windows.Forms.Label();
            this.raceClassNameSelector1 = new RPGCharacterCreator.RaceClassNameSelector();
            this.label2 = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.statBlockSelector1 = new RPGCharacterCreator.StatBlockSelector();
            this.SuspendLayout();
            // 
            // charTitle
            // 
            this.charTitle.AutoSize = true;
            this.charTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charTitle.Location = new System.Drawing.Point(282, 70);
            this.charTitle.Name = "charTitle";
            this.charTitle.Size = new System.Drawing.Size(226, 20);
            this.charTitle.TabIndex = 1;
            this.charTitle.Text = "NAME, the RACE CLASS ";
            this.charTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // raceClassNameSelector1
            // 
            this.raceClassNameSelector1.Location = new System.Drawing.Point(12, 12);
            this.raceClassNameSelector1.Name = "raceClassNameSelector1";
            this.raceClassNameSelector1.Size = new System.Drawing.Size(203, 130);
            this.raceClassNameSelector1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ready to save as Text File?";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(221, 395);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 5;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Want to start from Scratch?";
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(409, 395);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 7;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // statBlockSelector1
            // 
            this.statBlockSelector1.Location = new System.Drawing.Point(12, 148);
            this.statBlockSelector1.Name = "statBlockSelector1";
            this.statBlockSelector1.Size = new System.Drawing.Size(533, 214);
            this.statBlockSelector1.TabIndex = 2;
            // 
            // ReviewCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 433);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.raceClassNameSelector1);
            this.Controls.Add(this.statBlockSelector1);
            this.Controls.Add(this.charTitle);
            this.Name = "ReviewCharacterForm";
            this.Text = "ReviewCharacterForm";
            this.Load += new System.EventHandler(this.ReviewCharacterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label charTitle;
        private StatBlockSelector statBlockSelector1;
        private RaceClassNameSelector raceClassNameSelector1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button restartButton;
    }
}