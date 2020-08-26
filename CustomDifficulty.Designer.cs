namespace RGBGame
{
    partial class CustomDifficulty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDifficulty));
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customDiffNV = new System.Windows.Forms.NumericUpDown();
            this.ResetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customDiffNV)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(193, 71);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.6F);
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Custom difficulty in milliseconds";
            // 
            // customDiffNV
            // 
            this.customDiffNV.Location = new System.Drawing.Point(138, 45);
            this.customDiffNV.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.customDiffNV.Name = "customDiffNV";
            this.customDiffNV.Size = new System.Drawing.Size(120, 20);
            this.customDiffNV.TabIndex = 3;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(112, 71);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // CustomDifficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 108);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.customDiffNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomDifficulty";
            this.Text = "RGB - Custom Difficulty";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.CustomDifficulty_HelpButtonClicked);
            this.Load += new System.EventHandler(this.CustomDifficulty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customDiffNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown customDiffNV;
        private System.Windows.Forms.Button ResetBtn;
    }
}