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
    public partial class CustomDifficulty : Form
    {
        public CustomDifficulty()
        {
            InitializeComponent();
            customDiffNV.Value = Properties.Settings.Default.Diff;
            TopMost = true;
            BringToFront();
            Focus();
            customDiffNV.Select();

        }

        private void CustomDifficulty_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("You can choose your own timer interval in milliseconds (How fast the color button switches to another color). Easy is 500 milliseconds and hard is 350");
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            decimal customdiffdec = customDiffNV.Value;
            int customdiffint = Decimal.ToInt32(customdiffdec);
            Properties.Settings.Default.Diff = customdiffint;
            this.Close();
        }

        private void CustomDifficulty_Load(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Diff = 2;
            this.Close();
        }

    }
}
