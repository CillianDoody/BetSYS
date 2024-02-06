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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void fixturesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuOpenAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOpenAccount nextForm = new frmOpenAccount(this);
            nextForm.Show();
        }

        private void mnuTopUpWallet_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTopUpWallet nextForm = new frmTopUpWallet(this);
            nextForm.Show();
        }

        private void mnuAddFixture_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddFixture nextForm = new frmAddFixture(this);
            nextForm.Show();
        }

        private void mnuCloseAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCloseAccount nextForm = new frmCloseAccount(this);
            nextForm.Show();
        }

        private void updateFixtureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateFixtures nextForm = new frmUpdateFixtures(this);
            nextForm.Show();
        }

        private void mnuEnterResult_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEnterResults nextForm = new frmEnterResults(this);
            nextForm.Show();
        }

        private void picMainMenuBackground_Click(object sender, EventArgs e)
        {

        }

        private void mnuPlaceBet_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPlaceBet nextForm = new frmPlaceBet(this);
            nextForm.Show();
        }

        private void mnuCancelBet_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelBet nextForm = new frmCancelBet(this);
            nextForm.Show();
        }

        private void viewFixtureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewFixture nextForm = new frmViewFixture(this);
            nextForm.Show();
        }

        private void viewRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewYearlyRevenue nextForm = new frmViewYearlyRevenue(this);
            nextForm.Show();
        }

        private void mnuTeamAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewTeamAnalysis nextForm = new frmViewTeamAnalysis(this);
            nextForm.Show();
        }
    }
}
