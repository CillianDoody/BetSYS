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
    public partial class frmUpdateFixtures : Form
    {
        frmMainMenu parent;
        public frmUpdateFixtures()
        {
            InitializeComponent();
        }
        public frmUpdateFixtures(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void grpUpdateFixtures_Enter(object sender, EventArgs e)
        {
            
        }

        private void cboSelectFixture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelectFixture.SelectedIndex == -1) {
                grpUpdateFixtures.Visible = false;
            }
            else {
                grpUpdateFixtures.Visible = true;
            }

            if (cboSelectFixture.SelectedIndex == 0) {
                dtpFixtureDate.Value = DateTime.Parse("26/12/2023");
                txtFixtureTime.Text = "12:30";
            }

            if (cboSelectFixture.SelectedIndex == 1) {
                dtpFixtureDate.Value = DateTime.Parse("31/12/2023");
                txtFixtureTime.Text = "16:45";
            }

            if (cboSelectFixture.SelectedIndex == 2) {
                dtpFixtureDate.Value = DateTime.Parse("1/1/2024");
                txtFixtureTime.Text = "20:00";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime fixtureDate = dtpFixtureDate.Value;
            String fixtureTime = txtFixtureTime.Text;

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

            int Hour = Convert.ToInt32(fixtureTime.Substring(0, 2));
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

            else {
                MessageBox.Show("This Fixture was updated.", "Fixture updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSelectFixture.SelectedIndex = -1;
                dtpFixtureDate.Value = DateTime.Now;
                txtFixtureTime.Clear();


            }
        }

        private void frmUpdateFixtures_Load(object sender, EventArgs e)
        {
            dtpFixtureDate.MinDate = DateTime.Today;
        }
    }
}
