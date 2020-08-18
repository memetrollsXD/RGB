using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace RGBGame
{
    public partial class RGBStart : Form
    {
        public static string Color;
        public static int Difficulty;
        public RGBStart()
        {
            InitializeComponent();
            LoadSettings();

            if (Properties.Settings.Default.InGame == false) {
                TopScoreLabel.Text = "Top Score: " + Properties.Settings.Default.TopScore;
            }

        }

        private void LoadSettings()
        {
            if (Properties.Settings.Default.Muted)
            {
                Muted.Checked = true;
            }

            var diff = Properties.Settings.Default.Diff;

            if (diff == 1)
            {
                TrackBar.Value = 1;
            }
            else if (diff == 2)
            {
                TrackBar.Value = 2;
            }
            else
            {
                TrackBar.Value = 3;
            }
        }

        private void ContestConfig()
        {
                int TempPeople = Decimal.ToInt32(People.Value);
                Properties.Settings.Default.People = TempPeople;
                Properties.Settings.Default.Person = 1;
                Difficulty = TrackBar.Value;
                Properties.Settings.Default.InGame = true;
                Contest gui2 = new Contest();
                gui2.Show();
                this.Hide();
        }

        private void RedBtn_Click(object sender, EventArgs e)
        {
            Color = "Red";
            Difficulty = TrackBar.Value;
            if (People.Value > 1)
            {
                ContestConfig();
            } else
            {
                Properties.Settings.Default.InGame = true;
                Game gui2 = new Game();
                gui2.Show();
                this.Hide();
            }
        }

        private void GreenBtn_Click(object sender, EventArgs e)
        {
            Color = "Green";
            Difficulty = TrackBar.Value;
            if (People.Value > 1)
            {
                ContestConfig();
            }
            else
            {
                Properties.Settings.Default.InGame = true;
                Game gui2 = new Game();
                gui2.Show();
                this.Hide();
            }
        }

        private void BlueBtn_Click_1(object sender, EventArgs e)
        {
            Color = "Blue";
            Difficulty = TrackBar.Value;
            if (People.Value > 1)
            {
                ContestConfig();
            }
            else
            {
                Properties.Settings.Default.InGame = true;
                Game gui2 = new Game();
                gui2.Show();
                this.Hide();
            }
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
            SoundPlayer player = new SoundPlayer(Properties.Resources.beep);
            player.Play();

        }

        private void Muted_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Muted.Checked)
            {
                Properties.Settings.Default.Muted = true;
            } else
            {
                Properties.Settings.Default.Muted = false;
            }
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            Properties.Settings.Default.Diff = TrackBar.Value;
            TrackBar.Value = Properties.Settings.Default.Diff;
        }
    }
    
}
