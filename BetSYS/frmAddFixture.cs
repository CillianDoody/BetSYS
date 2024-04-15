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

            //Load Teams into ComboBoxes
            DataSet ds = Fixture.fillTeams();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboTeam1.Items.Add(ds.Tables[0].Rows[i][0]);
                cboTeam2.Items.Add(ds.Tables[0].Rows[i][0]);
            }

            //Load times into ComboBox
            DataSet ds2 = Fixture.fillTimes();

            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                cboFixtureTime.Items.Add(ds2.Tables[0].Rows[i][0]);
            }
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
            String OddsTeam1 = txtOddsTeam1.Text;
            String OddsTeam2 = txtOddsTeam2.Text;
            int fixtureTime = cboFixtureTime.SelectedIndex;
            DateTime fixtureDate = dtpFixtureDate.Value.Date;

            String Team1AsStr = cboTeam1.GetItemText(cboTeam1.SelectedItem);
            String Team2AsStr = cboTeam2.GetItemText(cboTeam2.SelectedItem);
            String FixtureTimeAsStr = cboFixtureTime.GetItemText(cboFixtureTime.SelectedItem);
            Double OddsTeam1AsDouble = Convert.ToDouble(txtOddsTeam1.Text);
            Double OddsTeam2AsDouble = Convert.ToDouble(txtOddsTeam2.Text);

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

            if (team2 == -1)
            {
                MessageBox.Show("Please select the second team.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTeam2.Focus();
                return;
            }

            if (OddsTeam1.Length != 4)
            {
                MessageBox.Show("This length is too long, this only accepts up to 4 characters in a decimal format e.g. 1.46", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOddsTeam1.Focus();
                return;
            }

            if (char.IsDigit(OddsTeam1[0]) == false)
            {
                MessageBox.Show("Please enter odds in decimal format for team 1. e.g. 1.00", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOddsTeam1.Focus();
                return;
            }

            if (char.ToString(OddsTeam1[1]) != ".")
            {
                MessageBox.Show("Please enter odds in decimal format for team 1. e.g. 1.00", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOddsTeam1.Focus();
                return;
            }

            if (char.IsDigit(OddsTeam1[2]) == false)
            {
                MessageBox.Show("Please enter odds in decimal format for team 1. e.g. 1.00", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOddsTeam1.Focus();
                return;
            }

            if (char.IsDigit(OddsTeam1[3]) == false)
            {
                MessageBox.Show("Please enter odds in decimal format for team 1. e.g. 1.00", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOddsTeam1.Focus();
                return;
            }

            if (OddsTeam1.Length != 4)
            {
                MessageBox.Show("This length is too long, this only accepts up to 4 characters in a decimal format e.g. 1.46", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOddsTeam1.Focus();
                return;
            }

            if (char.IsDigit(OddsTeam2[0]) == false)
            {
                MessageBox.Show("Please enter odds in decimal format for team 2. e.g. 1.00", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOddsTeam2.Focus();
                return;
            }

            if (char.ToString(OddsTeam2[1]) != ".")
            {
                MessageBox.Show("Please enter odds in decimal format for team 2. e.g. 1.00", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOddsTeam2.Focus();
                return;
            }

            if (char.IsDigit(OddsTeam2[2]) == false)
            {
                MessageBox.Show("Please enter odds in decimal format for team 2. e.g. 1.00", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOddsTeam2.Focus();
                return;
            }

            if (char.IsDigit(OddsTeam2[3]) == false)
            {
                MessageBox.Show("Please enter odds in decimal format for team 2. e.g. 1.00", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOddsTeam2.Focus();
                return;
            }

            if (fixtureDate < DateTime.Today) {
                MessageBox.Show("This is an invalid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFixtureDate.Focus();
                return;
            }

            if (fixtureTime == -1) {
                MessageBox.Show("This is an invalid time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboFixtureTime.Focus();
                return;
            }

            else
            { 
                Fixture AddFixture = new Fixture(Fixture.generateFixtureID(), Team1AsStr, Team2AsStr, OddsTeam1AsDouble,
                    OddsTeam2AsDouble, fixtureDate, FixtureTimeAsStr, 0, 0, 'U');

                AddFixture.addFixture();
                MessageBox.Show("This Fixture was added.", "Fixture added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboTeam1.SelectedIndex = -1;
                cboTeam1.Text = "Please select the first team.";
                cboTeam2.SelectedIndex = -1;
                cboTeam2.Text = "Please select the second team.";
                txtOddsTeam1.Text = "";
                txtOddsTeam2.Text = "";
                dtpFixtureDate.Value = DateTime.Now;
                cboFixtureTime.SelectedIndex = -1;
                cboFixtureTime.Text = "Please select a time for the fixture";
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
