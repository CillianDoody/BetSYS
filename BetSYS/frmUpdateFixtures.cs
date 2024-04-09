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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime fixtureDate = dtpFixtureDate.Value;

            if (fixtureDate < DateTime.Today) {
                MessageBox.Show("This is an invalid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFixtureDate.Focus();
                return;
            }

            else {
                MessageBox.Show("This Fixture was updated.", "Fixture updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSelectFixture.SelectedIndex = -1;
                dtpFixtureDate.Value = DateTime.Now;


            }
        }

        private void frmUpdateFixtures_Load(object sender, EventArgs e)
        {
            dtpFixtureDate.MinDate = DateTime.Today;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
