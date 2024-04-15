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
            int score1AsInt = Convert.ToInt32(score1);
            int score2AsInt = Convert.ToInt32(score2);
            String Team1 = lblTeam1.Text;
            String Team2 = lblTeam2.Text;
            int fixtureID = Convert.ToInt32(cboSelectFixture.SelectedItem);

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
                
                Fixture setStatus = new Fixture(fixtureID);
                if (score1AsInt > score2AsInt)
                {
                    Bets payOutWinners = new Bets(Team1, fixtureID);
                    payOutWinners.payOutBet();
                    payOutWinners.setBetStatus();
                    setStatus.updateFixtureStatus();
                }
                if (score1AsInt < score2AsInt)
                {
                    Bets payOutWinners = new Bets(Team2, fixtureID);
                    payOutWinners.payOutBet();
                    payOutWinners.setBetStatus();

                    setStatus.updateFixtureStatus();
                }
                else
                {
                    Bets payOutWinners = new Bets(Team1, fixtureID);
                    payOutWinners.setBetStatus();
                    setStatus.updateFixtureStatus();
                }
                MessageBox.Show("The result has been entered.", "Result Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSelectFixture.SelectedIndex = -1;
                cboSelectFixture.Items.Clear();
                //Load IDs into ComboBox
                DataSet ds = Fixture.fillFixtureIds();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cboSelectFixture.Items.Add(ds.Tables[0].Rows[i][0]);
                }
                grpEnterResult.Visible = false;
                txtScore1.Text = "0";
                txtScore2.Text = "0";
            }
        }

        private void frmEnterResults_Load(object sender, EventArgs e)
        {
            //Load IDs into ComboBox
            DataSet ds = Fixture.fillFixtureIds();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboSelectFixture.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }

        private void cboSelectFixture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelectFixture.SelectedIndex != -1)
            {
                int fixtureID = Convert.ToInt32(cboSelectFixture.SelectedItem);
                grpEnterResult.Visible = true;
                lblTeam1.Text = Fixture.displayTeam1(fixtureID);
                lblTeam2.Text = Fixture.displayTeam2(fixtureID);
            }
        }
    }
}
