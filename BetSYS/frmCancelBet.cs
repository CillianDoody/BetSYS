using BettingSYS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetSYS
{
    public partial class frmCancelBet : Form
    {
        frmMainMenu parent;
        public frmCancelBet()
        {
            InitializeComponent();
        }
        public frmCancelBet(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboSelectFixture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelectBet.SelectedIndex == -1)
            {
                btnCancelBet.Visible = false;
                lblFixture.Visible = false;
                lblTeamToWin.Visible = false;
            }
            else
            {
                int betID = Convert.ToInt32(cboSelectBet.SelectedItem);
                int fixtureID = Bets.getFixtureID(betID);
                String label = Fixture.displayFixture(fixtureID);
                lblFixture.Text = label;

                lblTeamToWin.Text = Bets.displayTeamToWin(betID);

                btnCancelBet.Visible = true;
                lblFixture.Visible = true;
                lblTeamToWin.Visible = true;
            }
        }

        private void btnCancelBet_Click(object sender, EventArgs e)
        {
            int betID = Convert.ToInt32(cboSelectBet.SelectedItem);
            if (cboSelectBet.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a bet to be canceled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSelectBet.Focus();
            }
            else
            {
                Bets cancelSelectedBet = new Bets(betID);
                cancelSelectedBet.refundBet(betID);
                cancelSelectedBet.cancelBet(betID);
                MessageBox.Show("The bet has been canceled", "Bet Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSelectBet.SelectedIndex = -1;
            }
        }

        private void lblSelectFixture_Click(object sender, EventArgs e)
        {

        }

        private void cboSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int accountID = Convert.ToInt32(cboSelectUser.SelectedItem);
            String label = Customer.displayUserName(accountID);
            lblLogStatus.Text = label;

            grpCancelBet.Visible = true;

            cboSelectBet.SelectedIndex = -1;
            cboSelectBet.Text = "";
            cboSelectBet.Items.Clear();
            DataSet ds = Bets.fillBetIDs(accountID);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboSelectBet.Items.Add(ds.Tables[0].Rows[i][0]);
            }

        }

        private void frmCancelBet_Load(object sender, EventArgs e)
        {
            DataSet ds = Customer.fillAccountIds();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboSelectUser.Items.Add(ds.Tables[0].Rows[i][0]);
            }
        }
    }
}
