﻿namespace RPGCharacterCreator
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
            this.label1 = new System.Windows.Forms.Label();
            this.statBlockSelector1 = new RPGCharacterCreator.StatBlockSelector();
            this.raceClassNameSelector1 = new RPGCharacterCreator.RaceClassNameSelector();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAME, the RACE CLASS ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statBlockSelector1
            // 
            this.statBlockSelector1.Location = new System.Drawing.Point(12, 148);
            this.statBlockSelector1.Name = "statBlockSelector1";
            this.statBlockSelector1.Size = new System.Drawing.Size(533, 214);
            this.statBlockSelector1.TabIndex = 2;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Restart";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ReviewCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 433);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.raceClassNameSelector1);
            this.Controls.Add(this.statBlockSelector1);
            this.Controls.Add(this.label1);
            this.Name = "ReviewCharacterForm";
            this.Text = "ReviewCharacterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private StatBlockSelector statBlockSelector1;
        private RaceClassNameSelector raceClassNameSelector1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}