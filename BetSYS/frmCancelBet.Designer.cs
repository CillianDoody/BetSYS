namespace BetSYS
{
    partial class frmCancelBet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuBackToMenu = new System.Windows.Forms.MenuStrip();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeading = new System.Windows.Forms.Label();
            this.cboSelectBet = new System.Windows.Forms.ComboBox();
            this.lblSelectBet = new System.Windows.Forms.Label();
            this.btnCancelBet = new System.Windows.Forms.Button();
            this.grpCancelBet = new System.Windows.Forms.GroupBox();
            this.lblFixture = new System.Windows.Forms.Label();
            this.lblTeamToWin = new System.Windows.Forms.Label();
            this.lblSelectUser = new System.Windows.Forms.Label();
            this.cboSelectUser = new System.Windows.Forms.ComboBox();
            this.lblLogStatus = new System.Windows.Forms.Label();
            this.mnuBackToMenu.SuspendLayout();
            this.grpCancelBet.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBackToMenu
            // 
            this.mnuBackToMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackToMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMenuToolStripMenuItem});
            this.mnuBackToMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuBackToMenu.Name = "mnuBackToMenu";
            this.mnuBackToMenu.Size = new System.Drawing.Size(800, 28);
            this.mnuBackToMenu.TabIndex = 4;
            this.mnuBackToMenu.Text = "menuStrip1";
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.backToMenuToolStripMenuItem.Text = "Back to menu";
            this.backToMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblHeading.Location = new System.Drawing.Point(162, 56);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(575, 31);
            this.lblHeading.TabIndex = 20;
            this.lblHeading.Text = "Please choose the bet you would like to cancel";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboSelectBet
            // 
            this.cboSelectBet.FormattingEnabled = true;
            this.cboSelectBet.Items.AddRange(new object[] {
            "Liverpool - Manchester United",
            "Newcastle United - Manchester City",
            "Wolverhampton Wanderers - Crystal Palace"});
            this.cboSelectBet.Location = new System.Drawing.Point(221, 37);
            this.cboSelectBet.Name = "cboSelectBet";
            this.cboSelectBet.Size = new System.Drawing.Size(104, 21);
            this.cboSelectBet.TabIndex = 22;
            this.cboSelectBet.SelectedIndexChanged += new System.EventHandler(this.cboSelectFixture_SelectedIndexChanged);
            // 
            // lblSelectBet
            // 
            this.lblSelectBet.AutoSize = true;
            this.lblSelectBet.Location = new System.Drawing.Point(58, 37);
            this.lblSelectBet.Name = "lblSelectBet";
            this.lblSelectBet.Size = new System.Drawing.Size(65, 15);
            this.lblSelectBet.TabIndex = 21;
            this.lblSelectBet.Text = "Select Bet:";
            this.lblSelectBet.Click += new System.EventHandler(this.lblSelectFixture_Click);
            // 
            // btnCancelBet
            // 
            this.btnCancelBet.Location = new System.Drawing.Point(61, 174);
            this.btnCancelBet.Name = "btnCancelBet";
            this.btnCancelBet.Size = new System.Drawing.Size(264, 52);
            this.btnCancelBet.TabIndex = 23;
            this.btnCancelBet.Text = "Cancel Bet";
            this.btnCancelBet.UseVisualStyleBackColor = true;
            this.btnCancelBet.Visible = false;
            this.btnCancelBet.Click += new System.EventHandler(this.btnCancelBet_Click);
            // 
            // grpCancelBet
            // 
            this.grpCancelBet.Controls.Add(this.lblTeamToWin);
            this.grpCancelBet.Controls.Add(this.lblFixture);
            this.grpCancelBet.Controls.Add(this.btnCancelBet);
            this.grpCancelBet.Controls.Add(this.cboSelectBet);
            this.grpCancelBet.Controls.Add(this.lblSelectBet);
            this.grpCancelBet.Location = new System.Drawing.Point(202, 173);
            this.grpCancelBet.Name = "grpCancelBet";
            this.grpCancelBet.Size = new System.Drawing.Size(389, 265);
            this.grpCancelBet.TabIndex = 24;
            this.grpCancelBet.TabStop = false;
            this.grpCancelBet.Text = "Cancel Bet";
            this.grpCancelBet.Visible = false;
            // 
            // lblFixture
            // 
            this.lblFixture.AutoSize = true;
            this.lblFixture.Location = new System.Drawing.Point(133, 84);
            this.lblFixture.Name = "lblFixture";
            this.lblFixture.Size = new System.Drawing.Size(102, 15);
            this.lblFixture.TabIndex = 24;
            this.lblFixture.Text = "Team1 vs Team2";
            this.lblFixture.Visible = false;
            // 
            // lblTeamToWin
            // 
            this.lblTeamToWin.AutoSize = true;
            this.lblTeamToWin.Location = new System.Drawing.Point(133, 131);
            this.lblTeamToWin.Name = "lblTeamToWin";
            this.lblTeamToWin.Size = new System.Drawing.Size(106, 15);
            this.lblTeamToWin.TabIndex = 25;
            this.lblTeamToWin.Text = "Team win @ odds";
            this.lblTeamToWin.Visible = false;
            // 
            // lblSelectUser
            // 
            this.lblSelectUser.AutoSize = true;
            this.lblSelectUser.Location = new System.Drawing.Point(255, 106);
            this.lblSelectUser.Name = "lblSelectUser";
            this.lblSelectUser.Size = new System.Drawing.Size(70, 15);
            this.lblSelectUser.TabIndex = 25;
            this.lblSelectUser.Text = "Select User";
            // 
            // cboSelectUser
            // 
            this.cboSelectUser.FormattingEnabled = true;
            this.cboSelectUser.Location = new System.Drawing.Point(423, 106);
            this.cboSelectUser.Name = "cboSelectUser";
            this.cboSelectUser.Size = new System.Drawing.Size(104, 21);
            this.cboSelectUser.TabIndex = 26;
            this.cboSelectUser.SelectedIndexChanged += new System.EventHandler(this.cboSelectUser_SelectedIndexChanged);
            // 
            // lblLogStatus
            // 
            this.lblLogStatus.AutoSize = true;
            this.lblLogStatus.Location = new System.Drawing.Point(255, 141);
            this.lblLogStatus.Name = "lblLogStatus";
            this.lblLogStatus.Size = new System.Drawing.Size(157, 15);
            this.lblLogStatus.TabIndex = 27;
            this.lblLogStatus.Text = "Logged in as: Not logged in";
            // 
            // frmCancelBet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLogStatus);
            this.Controls.Add(this.cboSelectUser);
            this.Controls.Add(this.lblSelectUser);
            this.Controls.Add(this.grpCancelBet);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.mnuBackToMenu);
            this.Name = "frmCancelBet";
            this.Text = "Cancel Bet";
            this.Load += new System.EventHandler(this.frmCancelBet_Load);
            this.mnuBackToMenu.ResumeLayout(false);
            this.mnuBackToMenu.PerformLayout();
            this.grpCancelBet.ResumeLayout(false);
            this.grpCancelBet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBackToMenu;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ComboBox cboSelectBet;
        private System.Windows.Forms.Label lblSelectBet;
        private System.Windows.Forms.Button btnCancelBet;
        private System.Windows.Forms.GroupBox grpCancelBet;
        private System.Windows.Forms.Label lblFixture;
        private System.Windows.Forms.Label lblTeamToWin;
        private System.Windows.Forms.Label lblSelectUser;
        private System.Windows.Forms.ComboBox cboSelectUser;
        private System.Windows.Forms.Label lblLogStatus;
    }
}