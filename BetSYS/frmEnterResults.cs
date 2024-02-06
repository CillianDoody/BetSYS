using BetSYS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BettingSYS
{
    public partial class frmEnterResults : Form
    {
        frmMainMenu parent;
        public frmEnterResults()
        {
            InitializeComponent();
        }

        public frmEnterResults(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String score1 = txtScore1.Text;
            String score2 = txtScore2.Text;

            if (cboSelectFixture.SelectedIndex == -1) {
                MessageBox.Show("You must enter a fixture.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSelectFixture.Focus();
                return;
            }

            if (!score1.Any(Char.IsDigit)) {
                MessageBox.Show("This is an invalid score.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtScore1.Focus();
                return;
            }

            if (!score2.Any(Char.IsDigit)) {
                MessageBox.Show("This is an invalid score.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtScore2.Focus();
                return;
            }

            else {
                MessageBox.Show("The result has been entered.", "Result Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSelectFixture.SelectedIndex = -1;
                txtScore1.Text = "0";
                txtScore2.Text = "0";
            }
        }
    }
}
