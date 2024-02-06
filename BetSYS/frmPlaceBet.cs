using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            }

            if (cboSelectFixture.SelectedIndex == 0) {
                cboSelectTeam.Items.Clear();
                cboSelectTeam.Items.Add("Liverpool");
                cboSelectTeam.Items.Add("Manchester United");
            }

            if (cboSelectFixture.SelectedIndex == 1) {
                cboSelectTeam.Items.Clear();
                cboSelectTeam.Items.Add("Newcastle United");
                cboSelectTeam.Items.Add("Manchester City");
            }

            if (cboSelectFixture.SelectedIndex == 2) {
                cboSelectTeam.Items.Clear();
                cboSelectTeam.Items.Add("Wolverhampton Wanderers");
                cboSelectTeam.Items.Add("Crystal Palace");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int SelectedTeam = cboSelectTeam.SelectedIndex;
            String Amount = txtAmount.Text;

            if (SelectedTeam == -1) {
                MessageBox.Show("You must choose a team", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSelectTeam.Focus();
                return;
            }

            if (Amount.Length == 0) {
                MessageBox.Show("You must enter an amount to place a bet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus(); 
                return;
            }

            if (!Amount.Any(Char.IsDigit)) {
                MessageBox.Show("You must enter a number to place a bet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Focus();
                txtAmount.Clear();
                return;
            }
            else {
                MessageBox.Show("You have successfully placed a bet", "Bet Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Clear();
                cboSelectTeam.SelectedIndex = -1;
                cboSelectTeam.Items.Clear();
                cboSelectTeam.Text = "Select Team";
                cboSelectFixture.SelectedIndex = -1;
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
            double AmountReturned = 0;
            if (!AmountText.Equals("")){
                int Amount = Convert.ToInt32(AmountText);
    
                if (cboSelectTeam.SelectedIndex == 0) {
                    lblOdds.Text = "9/20";
                    lblOddsText.Visible = true;
                    lblOdds.Visible = true;
                    AmountReturned = Amount + (Amount * 1.45);
                    lblPotentialReturn.Text = "€ " + Convert.ToString(AmountReturned);
                }
                if (cboSelectTeam.SelectedIndex == 1) {
                    lblOdds.Text = "5/1";
                    lblOddsText.Visible = true;
                    lblOdds.Visible = true;
                    AmountReturned = Amount + (Amount * 6);
                    lblPotentialReturn.Text = "€ " + Convert.ToString(AmountReturned);
                }
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
    }
}
