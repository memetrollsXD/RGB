﻿namespace RGBGame
{
    partial class Contest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contest));
            this.ColorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ScoreLbl = new System.Windows.Forms.Label();
            this.YourColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Playerlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ColorBtn
            // 
            this.ColorBtn.BackColor = System.Drawing.Color.White;
            this.ColorBtn.Location = new System.Drawing.Point(284, 142);
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(205, 178);
            this.ColorBtn.TabIndex = 0;
            this.ColorBtn.UseVisualStyleBackColor = false;
            this.ColorBtn.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ColorBtn_MouseDoubleClick);
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 95);
            this.label1.TabIndex = 1;
            this.label1.Text = "RGB";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScoreLbl
            // 
            this.ScoreLbl.AutoSize = true;
            this.ScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.ScoreLbl.Location = new System.Drawing.Point(280, 365);
            this.ScoreLbl.Name = "ScoreLbl";
            this.ScoreLbl.Size = new System.Drawing.Size(411, 95);
            this.ScoreLbl.TabIndex = 2;
            this.ScoreLbl.Text = "Loading...";
            this.ScoreLbl.Click += new System.EventHandler(this.ScoreLbl_Click);
            // 
            // YourColor
            // 
            this.YourColor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.YourColor.Location = new System.Drawing.Point(713, 12);
            this.YourColor.Name = "YourColor";
            this.YourColor.Size = new System.Drawing.Size(75, 23);
            this.YourColor.TabIndex = 3;
            this.YourColor.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(713, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your Color";
            // 
            // Playerlbl
            // 
            this.Playerlbl.AutoSize = true;
            this.Playerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Playerlbl.Location = new System.Drawing.Point(12, 26);
            this.Playerlbl.Name = "Playerlbl";
            this.Playerlbl.Size = new System.Drawing.Size(142, 39);
            this.Playerlbl.TabIndex = 5;
            this.Playerlbl.Text = "Player 1";
            // 
            // Contest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Playerlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YourColor);
            this.Controls.Add(this.ScoreLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Contest";
            this.Text = "RGB (Random Good Bogus)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button ColorBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ScoreLbl;
        private System.Windows.Forms.Button YourColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Playerlbl;
    }
}