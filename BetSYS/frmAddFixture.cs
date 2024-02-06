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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BettingSYS
{
    public partial class frmAddFixture : Form
    {
        frmMainMenu parent;
        public frmAddFixture()
        {
            InitializeComponent();
        }

        public frmAddFixture(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmAddFixture_Load(object sender, EventArgs e)
        {
            dtpFixtureDate.MinDate = DateTime.Today;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int team1 = cboTeam1.SelectedIndex;
            int team2 = cboTeam2.SelectedIndex;
            DateTime fixtureDate = dtpFixtureDate.Value;
            String fixtureTime = txtFixtureTime.Text;

            if (team1 == -1) {
                MessageBox.Show("Please select the first team.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTeam1.Focus();
                return;
            }

            if (team2 == -1) {
                MessageBox.Show("Please select the second team.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTeam2.Focus();
                return;
            }

            if (team1 == team2) {
                MessageBox.Show("A team cannot play themselves.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTeam2.Focus();
                return;
            }

            if (fixtureDate < DateTime.Today) {
                MessageBox.Show("This is an invalid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFixtureDate.Focus();
                return;
            }

            if (fixtureTime.Length != 5) {
                MessageBox.Show("This is an invalid time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFixtureTime.Focus();
                return;
            }

            if (Char.IsDigit(fixtureTime[0]) == false || Char.IsDigit(fixtureTime[1]) == false) {
                MessageBox.Show("This is an invalid time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFixtureTime.Focus();
                return;
            }

            if (fixtureTime[2] != ':') {
                MessageBox.Show("There needs to be a ':'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFixtureTime.Focus();
                return;
            }

            if (Char.IsDigit(fixtureTime[3]) == false || Char.IsDigit(fixtureTime[4]) == false) {
                MessageBox.Show("This is an invalid time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFixtureTime.Focus();
                return;
            }

            int Hour = Convert.ToInt32(fixtureTime.Substring(0,2));
            int Minute = Convert.ToInt32(fixtureTime.Substring(3));

            if (Hour >= 24) {
                MessageBox.Show("This is an invalid time. The hour must be less then 24.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFixtureTime.Focus();
                return;
            }

            if (Minute >= 60) {
                MessageBox.Show("This is an invalid time. The minute must be less then 60.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFixtureTime.Focus();
                return;
            } 

            else
            {
                MessageBox.Show("This Fixture was added.", "Fixture added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboTeam1.SelectedIndex = -1;
                cboTeam1.Text = "Please select the first team.";
                cboTeam2.SelectedIndex = -1;
                cboTeam2.Text = "Please select the second team.";
                dtpFixtureDate.Value = DateTime.Now;
                txtFixtureTime.Text = "HH:MM";
            }
        }
    }
}
