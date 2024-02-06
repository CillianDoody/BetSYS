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

namespace BetSYS
{
    public partial class frmViewTeamAnalysis : Form
    {
        frmMainMenu parent;
        public frmViewTeamAnalysis()
        {
            InitializeComponent();
        }
        public frmViewTeamAnalysis(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btn2023_Click(object sender, EventArgs e)
        {
            picTeamAnalysis.Visible = true;
            btn2023.Visible = false;
            btn2022.Visible = false;
            btn2021.Visible = false;
        }

        private void btn2022_Click(object sender, EventArgs e)
        {
            picTeamAnalysis.Visible = true;
            btn2023.Visible = false;
            btn2022.Visible = false;
            btn2021.Visible = false;
        }

        private void btn2021_Click(object sender, EventArgs e)
        {
            picTeamAnalysis.Visible = true;
            btn2023.Visible = false;
            btn2022.Visible = false;
            btn2021.Visible = false;
        }
    }
}
