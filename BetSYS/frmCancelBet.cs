using BettingSYS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetSYS
{
    public partial class frmCancelBet : Form
    {
        frmMainMenu parent;
        public frmCancelBet()
        {
            InitializeComponent();
        }
        public frmCancelBet(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboSelectFixture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelectFixture.SelectedIndex == -1)
            {
                btnCancelBet.Visible = false;
            }
            else
            {
                btnCancelBet.Visible = true;
            }
        }

        private void btnCancelBet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The bet has been canceled", "Bet Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboSelectFixture.SelectedIndex = -1;
        }
    }
}
