namespace RGBGame
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
            this.TopScoreLabel = new System.Windows.Forms.Label();
            this.Muted = new System.Windows.Forms.CheckBox();
            this.People = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.People)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 95);
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
            this.TrackBar.Size = new System.Drawing.Size(776, 56);
            this.TrackBar.TabIndex = 4;
            this.TrackBar.Value = 2;
            this.TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            this.TrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrackBar_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Easy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(763, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Medium";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(670, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Game by memetrollsXD";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TopScoreLabel
            // 
            this.TopScoreLabel.AutoSize = true;
            this.TopScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TopScoreLabel.Location = new System.Drawing.Point(6, 7);
            this.TopScoreLabel.Name = "TopScoreLabel";
            this.TopScoreLabel.Size = new System.Drawing.Size(123, 25);
            this.TopScoreLabel.TabIndex = 9;
            this.TopScoreLabel.Text = "Top Score: ";
            // 
            // Muted
            // 
            this.Muted.AutoSize = true;
            this.Muted.Location = new System.Drawing.Point(9, 428);
            this.Muted.Margin = new System.Windows.Forms.Padding(2);
            this.Muted.Name = "Muted";
            this.Muted.Size = new System.Drawing.Size(57, 19);
            this.Muted.TabIndex = 10;
            this.Muted.Text = "Mute";
            this.Muted.UseVisualStyleBackColor = true;
            this.Muted.CheckedChanged += new System.EventHandler(this.Muted_CheckedChanged);
            // 
            // People
            // 
            this.People.Location = new System.Drawing.Point(758, 12);
            this.People.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.People.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.People.Name = "People";
            this.People.Size = new System.Drawing.Size(30, 20);
            this.People.TabIndex = 11;
            this.People.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(702, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Number of people";
            // 
            // RGBStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.People);
            this.Controls.Add(this.Muted);
            this.Controls.Add(this.TopScoreLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.People)).EndInit();
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
        private System.Windows.Forms.Label TopScoreLabel;
        private System.Windows.Forms.CheckBox Muted;
        private System.Windows.Forms.NumericUpDown People;
        private System.Windows.Forms.Label label7;
    }
}

