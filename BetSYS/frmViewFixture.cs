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
    public partial class frmViewFixture : Form
    {
        frmMainMenu parent;
        public frmViewFixture() 
        {
            InitializeComponent();
        }
        public frmViewFixture(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmViewFixture_Load(object sender, EventArgs e)
        {
            Fixture.displayFixtures(dgvViewFixtures);
        }
    }
}
