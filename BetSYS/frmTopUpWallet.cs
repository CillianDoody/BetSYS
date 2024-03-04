using BetSYS;
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

namespace BettingSYS
{
    public partial class frmTopUpWallet : Form
    {
        frmMainMenu parent;
        public frmTopUpWallet()
        {
            InitializeComponent();
        }
        public frmTopUpWallet(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void cboMoneyOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmTopUpWallet_Load(object sender, EventArgs e)
        {
            dtpExpiryDate.MinDate = DateTime.Today;
        }

        private void txtCVC_TextChanged(object sender, EventArgs e)
        {

        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String Email = txtAccountEmail.Text;
            String CardNo = txtCardNo.Text;
            DateTime ExpiryDate = dtpExpiryDate.Value;
            String Cvc = txtCVC.Text;
            int moneyToAdd = cboMoneyOptions.SelectedIndex;

            if (Email.EndsWith(".com") == false && Email.EndsWith(".ie") == false)
            {
                MessageBox.Show("This is not a valid email. An email must end with .ie or .com", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAccountEmail.Focus();
                return;
            }
            if (Email.Contains("@outlook") == false && Email.Contains("@gmail") == false &&
               Email.Contains("@icloud") == false)
            {
                MessageBox.Show("This is not a valid email. An email must contain a domain name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAccountEmail.Focus();
                return;
            }

            if (CardNo.Length != 16) {
                MessageBox.Show("Card number must be 16 digits long.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCardNo.Focus();
                return;
            }
            
            if (CardNo.Any(char.IsLetter)) {
                MessageBox.Show("Card number must not have a letter.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCardNo.Focus();
                return;
            }

            if((ExpiryDate > DateTime.Today) == false) {
                MessageBox.Show("This card is expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpExpiryDate.Focus();
                return;
            }

            if (Cvc.Length !=3) {
                MessageBox.Show("Cvc must be 3 digits long.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCVC.Focus();
                return;
            }

            if (Cvc.Any(char.IsLetter)) {
                MessageBox.Show("Cvc must not have a letter.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCVC.Focus();
                return;
            }

            if (moneyToAdd == -1){
                MessageBox.Show("Please select a value", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMoneyOptions.Focus();
                return;
            }

            else { 
                Customer closeAccount = new Customer(Email);

                Boolean isAnAccount = closeAccount.SearchAccount();

                if (isAnAccount == false) {
                    MessageBox.Show("This account does not exist. Please enter a regestered email.", "Account Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAccountEmail.Clear();
                }
                else {
                    Customer topUpBalance = new Customer(Email);
                    topUpBalance.TopUpBalance(moneyToAdd);
                    MessageBox.Show("Money has been added to the account.", "Money Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCardNo.Clear();
                    txtCVC.Clear();
                    dtpExpiryDate.Value = DateTime.Today;
                    cboMoneyOptions.SelectedIndex = -1;
                    cboMoneyOptions.Text = "Please select the ammount you wish to add to the wallet";
                }
            }

        }
    }
}
