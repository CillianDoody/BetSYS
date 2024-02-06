using BetSYS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BettingSYS
{
    public partial class frmOpenAccount : Form
    {
        frmMainMenu parent;

        public frmOpenAccount()
        {
            InitializeComponent();
        }

        public frmOpenAccount(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void AccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Forename = txtFName.Text;
            string Surname = txtSName.Text;
            DateTime DOB = dtpDOB.Value.Date;
            string PhoneNumber = txtPhoneNumber.Text;
            string Email = txtEmail.Text;
            string Postcode = txtPostCode.Text;

            if (Forename.Equals("")) {
                MessageBox.Show("Forename must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();
                return;
            }

            if (Forename.Any(char.IsDigit) || Forename.Any(char.IsSymbol)){
                MessageBox.Show("Forename must not have a number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();
                return;
            }

            if (Surname.Equals("")) {
                MessageBox.Show("Surname must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSName.Focus();
                return;
            }
            if (Surname.Any(char.IsDigit) || Surname.Any(char.IsSymbol)) {
                MessageBox.Show("Surname must not have a number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSName.Focus();
                return;
            }

            if (DOB > DateTime.Today.AddYears(-18)) {
                MessageBox.Show("You must be older then 18 years old to make an account.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDOB.Focus();
                return;
            }

            if (PhoneNumber.Equals("")) {
                MessageBox.Show("Phone number must be entered.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                return;
            }

            if (PhoneNumber.Any(char.IsDigit) == false) {
                MessageBox.Show("Phone number must be 10 digits.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                return;
            }

            if (PhoneNumber.Length > 10 || PhoneNumber.Length < 10) {
                MessageBox.Show("Phone number must be 10 characters long.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                return;
            }

            if (PhoneNumber[0] != '0' || PhoneNumber[1] != '8') {
                MessageBox.Show("This is not a valid Irish mobile phone number. An Irish mobile phone number must begin with 08.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
                return;
            }

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

            if (Postcode.Length > 7 || Postcode.Length < 7) {
                MessageBox.Show("This is not a valid postcode. A postcode length must be 7", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostCode.Focus();
                return;
            }

            if (Char.IsLetter(Postcode[0]) == false)
            {
                MessageBox.Show("This is not a valid postcode. A postcode must start with a letter!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostCode.Focus();
                return;
            }

            else {
                Customer openAccount = new Customer(Customer.generateAccountID(), Forename, Surname, DOB, 
                    PhoneNumber, Email, Postcode, 'a', 0.00);             
                
                openAccount.addCustomer();

                MessageBox.Show("The account has been opened", "Account opened", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFName.Clear();
                txtSName.Clear();
                txtPhoneNumber.Text = "08";
                txtEmail.Clear();
                txtPostCode.Clear();
            }
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmOpenAccount_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Today.AddYears(-18);
        }
    }
}
