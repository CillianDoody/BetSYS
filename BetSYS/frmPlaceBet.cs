using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BetSYS
{
    public partial class frmPlaceBet : Form
    {
        frmMainMenu parent;
        public frmPlaceBet()
        {
            InitializeComponent();
        }

        public frmPlaceBet(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboSelectFixture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelectFixture.SelectedIndex == -1) {
                grpPlaceBet.Visible = false;
            }
            else {
                grpPlaceBet.Visible = true;
                cboSelectTeam.SelectedIndex = -1;
                int fixtureID = Convert.ToInt32(cboSelectFixture.SelectedItem);
                String label = Fixture.displayFixture(fixtureID);
                lblDisplayFixture.Text = label;

                cboSelectTeam.Items.Clear();

                //Load IDs into ComboBox
                DataSet ds2 = Fixture.fillFixtureTeam1(fixtureID);

                for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                {
                    cboSelectTeam.Items.Add(ds2.Tables[0].Rows[i][0]);
                }
                //Load IDs into ComboBox
                DataSet ds3 = Fixture.fillFixtureTeam2(fixtureID);

                for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
                {
                    cboSelectTeam.Items.Add(ds3.Tables[0].Rows[i][0]);
                }
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int SelectedTeam = cboSelectTeam.SelectedIndex;
            String SelectedTeamAsStr = Convert.ToString(cboSelectTeam.SelectedItem);
            int fixtureID = Convert.ToInt32(cboSelectFixture.SelectedItem);
            int accountID = Convert.ToInt32(cboSelectUser.SelectedItem);
            double Odds = Convert.ToDouble(lblOdds.Text);
            String Amount = txtAmount.Text;
            double AmountAsDouble = Convert.ToDouble(Amount);
            double balance = Customer.retrieveBalance(accountID);

            if (SelectedTeam == -1) {
                MessageBox.Show("You must choose a team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSelectTeam.Focus();
                return;
            }

            if (Amount.Length == 0) {
                MessageBox.Show("You must enter an amount to place a bet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus(); 
                return;
            }

            if (!Amount.Any(Char.IsDigit)) {
                MessageBox.Show("You must enter a number to place a bet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                txtAmount.Clear();
                return;
            }
            if (balance < Convert.ToDouble(Amount)) {
                MessageBox.Show("You do not have enough money to place this bet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                txtAmount.Clear();
                return;
            }
            else
            {
                Bets placeNewBet = new Bets(Bets.generateBetID(), AmountAsDouble, Odds, 'p',
                    DateTime.Today, SelectedTeamAsStr, fixtureID, accountID);

                placeNewBet.placeBet();

                Fixture adjustOdds = new Fixture(fixtureID);
                if (cboSelectTeam.SelectedIndex == 0) {
                    adjustOdds.AdjustOddsTeam1();
                }
                if (cboSelectTeam.SelectedIndex == 1) { 
                    adjustOdds.AdjustOddsTeam2();
                }

                Customer changeBalance = new Customer(accountID);
                changeBalance.adjustBalance(AmountAsDouble);

                MessageBox.Show("You have successfully placed a bet", "Bet Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Clear();
                cboSelectUser.SelectedIndex = -1;
                lblLogStatus.Text = "Logged in as: Not logged in";
                cboSelectTeam.SelectedIndex = -1;
                cboSelectTeam.Items.Clear();
                cboSelectTeam.Text = "Select Team";
                cboSelectFixture.SelectedIndex = -1;
                grpPlaceBet.Visible = false;
            } 

        }

        private void lblOdds_Click(object sender, EventArgs e)
        {

        }
        private void cboSelectTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAmount.Visible == false) { 
                txtAmount.Visible = true;
                lblAmount.Visible = true;
            }
            String AmountText = txtAmount.Text;
            double Odds = 1.00;
            double AmountReturned = 0;
            if (cboSelectTeam.SelectedIndex == 0)
            {
                int fixtureID = Convert.ToInt32(cboSelectFixture.SelectedItem);
                Odds = Fixture.fillOddsTeam1(fixtureID);
                lblOdds.Text = Convert.ToString(Odds);
            }
            if (cboSelectTeam.SelectedIndex == 1)
            {
                int fixtureID = Convert.ToInt32(cboSelectFixture.SelectedItem);
                Odds = Fixture.fillOddsTeam2(fixtureID);
                lblOdds.Text = Convert.ToString(Odds);
            }
            if (!AmountText.Equals("")){
                int Amount = Convert.ToInt32(AmountText);
                AmountReturned = Amount + (Amount * Odds);
                lblPotentialReturn.Text = "€ " + Convert.ToString(AmountReturned);
            }
        }
        
        private void txtAmount_TextChanged(object sender, EventArgs e) {
            String AmountText = txtAmount.Text;
            double AmountReturned = 0;

            if (!AmountText.Any(Char.IsDigit)) {
                txtAmount.Focus();
                txtAmount.Clear();
                return;
            }

            int Amount = Convert.ToInt32(AmountText);

            if (cboSelectTeam.SelectedIndex == 0) {
                AmountReturned = Amount + (Amount * 1.45);
            }

            if (cboSelectTeam.SelectedIndex == 1)
            {
                AmountReturned = Amount + (Amount * 6);
            }

            lblPotentialReturn.Text = "€ " + Convert.ToString(AmountReturned);
            lblPotentialReturnText.Visible = true;
            lblPotentialReturn.Visible = true;
        }

        private void frmPlaceBet_Load(object sender, EventArgs e)
        {
            //Load IDs into ComboBox
            DataSet ds = Fixture.fillFixtureIds();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboSelectFixture.Items.Add(ds.Tables[0].Rows[i][0]);
            }

            //Load IDs into ComboBox
            DataSet ds2 = Customer.fillAccountIds();

            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                cboSelectUser.Items.Add(ds2.Tables[0].Rows[i][0]);
            }

        }

        private void cboSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboSelectUser.SelectedIndex != -1){
            int accountID = Convert.ToInt32(cboSelectUser.SelectedItem);
            String label = Customer.displayUser(accountID);
                lblLogStatus.Text = label;
            }
        }
    }
}
