using BetSYS;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BettingSYS
{
    public partial class frmCloseAccount : Form
    {
        frmMainMenu parent;
        public frmCloseAccount()
        {
            InitializeComponent();
        }

        public frmCloseAccount(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCloseAccount_Load(object sender, EventArgs e)
        {

        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnCloseAccount_Click(object sender, EventArgs e)
        {
            String Email = txtEmail.Text;

            if (Email.EndsWith(".com") == false && Email.EndsWith(".ie") == false) {
                MessageBox.Show("This is not a valid email. An email must end with .ie or .com", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (Email.Contains("@outlook") == false && Email.Contains("@gmail") == false &&
               Email.Contains("@icloud") == false) {
                MessageBox.Show("This is not a valid email. An email must contain a domain name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            else {
                Customer closeAccount = new Customer();

                Boolean isAnAccount = closeAccount.SearchAccount(Email);

                if (isAnAccount == false) {
                    MessageBox.Show("This account does not exist. Please enter a regestered email.", "Account Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Clear();
                }
                else {
                    DialogResult dialog = MessageBox.Show("Are You sure you want to delete this account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialog == DialogResult.Yes) {
                        closeAccount.CloseAccount(Email);
                        MessageBox.Show("The account has been closed", "Account Closed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtEmail.Clear();
                    }  
                }
            }

        }
    }
}
