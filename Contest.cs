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
   
    public partial class Contest : Form
    {

        public Contest()
        {
            InitializeComponent();
        }
        private void Game_Load(object sender, EventArgs e)
        {
            //int Diff = RGBStart.Difficulty;
            int Diff = Properties.Settings.Default.Diff;
            timer1.Start();
            if (Diff == 1)
            {
                timer1.Interval = 500;
            }
            else if (Diff == 2)
            {
                timer1.Interval = 400;
            }
            else if (Diff == 3)
            {
                timer1.Interval = 350;
            }
            else if (Diff > 3)
            {
                timer1.Interval = Properties.Settings.Default.Diff;
            }

        }

        class Score
        {
            public static int ScoreInt;
        }

        private void ChangeColor()
        {
            Random r = new Random();

            int color = r.Next(1, 4);

            if (color == 1)
            {
                ColorBtn.BackColor = Color.Red;
            }
            else if (color == 2)
            {
                ColorBtn.BackColor = Color.Green;
            }
            else if (color == 3)
            {
                ColorBtn.BackColor = Color.Blue;
            }

        }

        private void PlaySound()
        {
            if (!Properties.Settings.Default.Muted)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.beep);
                player.Play();
            }
            else
            {
                return;
            }
        }

        private void PlaySoundN()
        {
            if (!Properties.Settings.Default.Muted)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.beepn);
                player.Play();
            }
            else
            {
                return;
            }
        }

        private void ColorBtn_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Boomer alert");
        }

        private void GameOver()
        {
            Score.ScoreInt = 0;
            Properties.Settings.Default.InGame = false;
            Properties.Settings.Default.Save();
            RGBStart gui2 = new RGBStart();
            gui2.Show();
            this.Hide();
        }

        private void ContestCheckF()
        {
            var Settings = Properties.Settings.Default;
            // People is max players
            // Person is what player out of the all players is playing (1-3)
            if (Settings.Person < Settings.People) // Checks if all people already played
            {
                if (Settings.Person == 1)
                {
                    Settings.Player1 = Score.ScoreInt;
                    Score.ScoreInt = 0;
                    Settings.Person++;
                }
                else if (Settings.Person == 2)
                {
                    Settings.Player2 = Score.ScoreInt;
                    Score.ScoreInt = 0;
                    Settings.Person++;
                }
                else if (Settings.Person == 3)
                {
                    Settings.Player3 = Score.ScoreInt;
                    Score.ScoreInt = 0;
                    Settings.Person++;
                }
            } else
            {
                if (Settings.People == 2)
                {
                    Settings.Player2 = Score.ScoreInt;
                    MessageBox.Show("Good job! Here are your scores:\n\n" +
"Player1: " + Settings.Player1 + "\n" +
"Player2: " + Settings.Player2 + "\n");
                    Score.ScoreInt = 0;
                    GameOver();
                } else
                {
                    Settings.Player3 = Score.ScoreInt;
                    MessageBox.Show("Good job! Here are your scores:\n\n" +
"Player1: " + Settings.Player1 + "\n" +
"Player2: " + Settings.Player2 + "\n" +
"Player3: " + Settings.Player3 + "\n");
                    Score.ScoreInt = 0;
                    GameOver();
                }

            }
        }

        private void ContestCheck()
        {
            var Settings = Properties.Settings.Default;
            // People is max players
            // Person is what player out of the all players is playing (1-3)
            if (Settings.Person < Settings.People) // Checks if all people already played
            {
                if (Settings.Person == 1)
                {
                    Settings.Player1 = Score.ScoreInt;
                }
                else if (Settings.Person == 2)
                {
                    Settings.Player2 = Score.ScoreInt;
                }
                else if (Settings.Person == 3)
                {
                    Settings.Player3 = Score.ScoreInt;
                }
            }
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.InGame == true)
            {
                string ColorS = RGBStart.Color;

                if (ColorBtn.BackColor == Color.Red & ColorS == "Red" || ColorBtn.BackColor == Color.Green & ColorS == "Green" || ColorBtn.BackColor == Color.Blue & ColorS == "Blue")
                {
                    Score.ScoreInt++;
                    ChangeColor();
                    PlaySound();
                    ContestCheck();
                }
                else
                {
                    PlaySoundN();
                    ContestCheckF();
                }
            }
            else
            {
                Properties.Settings.Default.InGame = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Playerlbl.Text = "Player " + Properties.Settings.Default.Person;
            ScoreLbl.Text = "Score: " + Score.ScoreInt;
            string ColorStr = RGBStart.Color;

            if (ColorStr == "Red")
            {
                YourColor.BackColor = Color.Red;
            }
            else if (ColorStr == "Green")
            {
                YourColor.BackColor = Color.Green;
            }
            else if (ColorStr == "Blue")
            {
                YourColor.BackColor = Color.Blue;
            }

            ChangeColor();
        }

        private void ScoreLbl_Click(object sender, EventArgs e)
        {
            ScoreLbl.Text = "Easter Egg :P";
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit RGB?", "Random Good Bogus", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}