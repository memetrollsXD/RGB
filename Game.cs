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
    public partial class Game : Form
    {

        public Game()
        {
            InitializeComponent();
        }
        private void Game_Load(object sender, EventArgs e)
        {
            int Diff = RGBStart.Difficulty;
            timer1.Start();
            if (Diff == 1)
            {
                timer1.Interval = 500;
            } else if (Diff == 2)
            {
                timer1.Interval = 400;
            } else if (Diff == 3)
            {
                timer1.Interval = 250;
            } else
            {
                timer1.Interval = RGBStart.Difficulty;
            }

        }

        class GameOver
        {
            public static bool GameOverBool = false;
        }

        class Score
        {
            public static int ScoreInt;
        }


        private void ColorBtn_Click(object sender, EventArgs e)
        {
            if (GameOver.GameOverBool == false)
            {
                string ColorS = RGBStart.Color;
                
                if (ColorBtn.BackColor == Color.Red & ColorS == "Red")
                {
                    Score.ScoreInt++;
                } else if (ColorBtn.BackColor == Color.Green & ColorS == "Green") {
                    Score.ScoreInt++;
                } else if (ColorBtn.BackColor == Color.Blue & ColorS == "Blue")
                {
                    Score.ScoreInt++;
                } else
                {
                    MessageBox.Show("Game over! Score: " + Score.ScoreInt);
                    Score.ScoreInt = 0;
                    RGBStart gui2 = new RGBStart();
                    gui2.Show();
                    this.Hide();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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


            Random r = new Random();

            int color = r.Next(1, 4);

            if (color == 1)
            {
                ColorBtn.BackColor = Color.Red;
            } else if (color == 2) {
                ColorBtn.BackColor = Color.Green;
            } else if (color == 3)
            {
                ColorBtn.BackColor = Color.Blue;
            }

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
