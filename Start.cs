using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBGame
{
    public partial class RGBStart : Form
    {
        public static string Color;
        public static int Difficulty;
        public RGBStart()
        {
            InitializeComponent();
        }


        private void RedBtn_Click(object sender, EventArgs e)
        {
            Color = "Red";
            Difficulty = TrackBar.Value;
            Game gui2 = new Game();
            gui2.Show();
            this.Hide();
        }

        private void GreenBtn_Click(object sender, EventArgs e)
        {
            Color = "Green";
            Difficulty = TrackBar.Value;
            Game gui2 = new Game();
            gui2.Show();
            this.Hide();
        }

        private void BlueBtn_Click_1(object sender, EventArgs e)
        {
            Color = "Blue";
            Difficulty = TrackBar.Value;
            Game gui2 = new Game();
            gui2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game gui2 = new Game();
            gui2.Show();
            this.Hide();
        }

        private void RGBStart_FormClosing(object sender, FormClosingEventArgs e)
        {
                if (MessageBox.Show("Do you really want to exit RGB?", "Random Good Bogus", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    
}
