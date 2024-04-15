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
                int fixtureID = Convert.ToInt32(cboSelectFixture.SelectedItem);
                String label = Fixture.displayFixture(fixtureID);
                lblDisplayFixture.Text = label;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int FixtureID = Convert.ToInt32(cboSelectFixture.SelectedItem);
            DateTime fixtureDate = dtpFixtureDate.Value;
            String fixtureTime = (String)cboFixtureTime.SelectedItem;

            if (fixtureDate < DateTime.Today) {
                MessageBox.Show("This is an invalid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFixtureDate.Focus();
                return;
            }
            if (cboFixtureTime.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboFixtureTime.Focus();
                return;
            }

            else {
                Fixture UpdateFixture = new Fixture(FixtureID, fixtureDate, fixtureTime);

                UpdateFixture.updateFixture();

                MessageBox.Show("This Fixture was updated.", "Fixture updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSelectFixture.SelectedIndex = -1;
                dtpFixtureDate.Value = DateTime.Now;
            }
        }

        private void frmUpdateFixtures_Load(object sender, EventArgs e)
        {
            dtpFixtureDate.MinDate = DateTime.Today;

            //Load times into ComboBox
            DataSet ds = Fixture.fillTimes();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboFixtureTime.Items.Add(ds.Tables[0].Rows[i][0]);
            }

            //Load IDs into ComboBox
            DataSet ds2 = Fixture.fillFixtureIds();

            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                cboSelectFixture.Items.Add(ds2.Tables[0].Rows[i][0]);
            }

        }
    }
}
