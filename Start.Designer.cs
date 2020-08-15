﻿namespace RGBGame
{
    partial class RGBStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RGBStart));
            this.label1 = new System.Windows.Forms.Label();
            this.RedBtn = new System.Windows.Forms.Button();
            this.GreenBtn = new System.Windows.Forms.Button();
            this.BlueBtn = new System.Windows.Forms.Button();
            this.TrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a color";
            // 
            // RedBtn
            // 
            this.RedBtn.BackColor = System.Drawing.Color.Red;
            this.RedBtn.Location = new System.Drawing.Point(12, 143);
            this.RedBtn.Name = "RedBtn";
            this.RedBtn.Size = new System.Drawing.Size(161, 158);
            this.RedBtn.TabIndex = 1;
            this.RedBtn.UseVisualStyleBackColor = false;
            this.RedBtn.Click += new System.EventHandler(this.RedBtn_Click);
            // 
            // GreenBtn
            // 
            this.GreenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GreenBtn.Location = new System.Drawing.Point(324, 143);
            this.GreenBtn.Name = "GreenBtn";
            this.GreenBtn.Size = new System.Drawing.Size(161, 158);
            this.GreenBtn.TabIndex = 2;
            this.GreenBtn.UseVisualStyleBackColor = false;
            this.GreenBtn.Click += new System.EventHandler(this.GreenBtn_Click);
            // 
            // BlueBtn
            // 
            this.BlueBtn.BackColor = System.Drawing.Color.Blue;
            this.BlueBtn.Location = new System.Drawing.Point(627, 143);
            this.BlueBtn.Name = "BlueBtn";
            this.BlueBtn.Size = new System.Drawing.Size(161, 158);
            this.BlueBtn.TabIndex = 3;
            this.BlueBtn.UseVisualStyleBackColor = false;
            this.BlueBtn.Click += new System.EventHandler(this.BlueBtn_Click_1);
            // 
            // TrackBar
            // 
            this.TrackBar.Location = new System.Drawing.Point(12, 363);
            this.TrackBar.Maximum = 3;
            this.TrackBar.Minimum = 1;
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(776, 45);
            this.TrackBar.TabIndex = 4;
            this.TrackBar.Value = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Easy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(763, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Medium";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(677, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Game by memetrollsXD";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // RGBStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrackBar);
            this.Controls.Add(this.BlueBtn);
            this.Controls.Add(this.GreenBtn);
            this.Controls.Add(this.RedBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RGBStart";
            this.Text = "RGB (Random Good Bogus)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RGBStart_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RedBtn;
        private System.Windows.Forms.Button GreenBtn;
        private System.Windows.Forms.Button BlueBtn;
        private System.Windows.Forms.TrackBar TrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
