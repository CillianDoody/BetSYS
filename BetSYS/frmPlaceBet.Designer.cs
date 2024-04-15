namespace BetSYS
{
    partial class frmPlaceBet
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
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.cboSelectFixture = new System.Windows.Forms.ComboBox();
            this.lblSelectFixture = new System.Windows.Forms.Label();
            this.grpPlaceBet = new System.Windows.Forms.GroupBox();
            this.lblDisplayFixture = new System.Windows.Forms.Label();
            this.lblPotentialReturn = new System.Windows.Forms.Label();
            this.lblPotentialReturnText = new System.Windows.Forms.Label();
            this.lblOdds = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOddsText = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cboSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblSelectUser = new System.Windows.Forms.Label();
            this.cboSelectUser = new System.Windows.Forms.ComboBox();
            this.lblLogStatus = new System.Windows.Forms.Label();
            this.mnuBackToMenu.SuspendLayout();
            this.grpPlaceBet.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBackToMenu
            // 
            this.mnuBackToMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackToMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackToMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuBackToMenu.Name = "mnuBackToMenu";
            this.mnuBackToMenu.Size = new System.Drawing.Size(800, 30);
            this.mnuBackToMenu.TabIndex = 3;
            this.mnuBackToMenu.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(113, 24);
            this.mnuBack.Text = "Back to menu";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // cboSelectFixture
            // 
            this.cboSelectFixture.FormattingEnabled = true;
            this.cboSelectFixture.Location = new System.Drawing.Point(374, 94);
            this.cboSelectFixture.Name = "cboSelectFixture";
            this.cboSelectFixture.Size = new System.Drawing.Size(96, 21);
            this.cboSelectFixture.TabIndex = 8;
            this.cboSelectFixture.SelectedIndexChanged += new System.EventHandler(this.cboSelectFixture_SelectedIndexChanged);
            // 
            // lblSelectFixture
            // 
            this.lblSelectFixture.AutoSize = true;
            this.lblSelectFixture.Location = new System.Drawing.Point(252, 94);
            this.lblSelectFixture.Name = "lblSelectFixture";
            this.lblSelectFixture.Size = new System.Drawing.Size(84, 15);
            this.lblSelectFixture.TabIndex = 7;
            this.lblSelectFixture.Text = "Select Fixture:";
            // 
            // grpPlaceBet
            // 
            this.grpPlaceBet.Controls.Add(this.lblDisplayFixture);
            this.grpPlaceBet.Controls.Add(this.lblPotentialReturn);
            this.grpPlaceBet.Controls.Add(this.lblPotentialReturnText);
            this.grpPlaceBet.Controls.Add(this.lblOdds);
            this.grpPlaceBet.Controls.Add(this.label1);
            this.grpPlaceBet.Controls.Add(this.lblOddsText);
            this.grpPlaceBet.Controls.Add(this.txtAmount);
            this.grpPlaceBet.Controls.Add(this.lblAmount);
            this.grpPlaceBet.Controls.Add(this.cboSelectTeam);
            this.grpPlaceBet.Controls.Add(this.lblSelectTeam);
            this.grpPlaceBet.Controls.Add(this.btnConfirm);
            this.grpPlaceBet.Location = new System.Drawing.Point(201, 133);
            this.grpPlaceBet.Name = "grpPlaceBet";
            this.grpPlaceBet.Size = new System.Drawing.Size(382, 282);
            this.grpPlaceBet.TabIndex = 14;
            this.grpPlaceBet.TabStop = false;
            this.grpPlaceBet.Text = "Place Bet";
            this.grpPlaceBet.Visible = false;
            // 
            // lblDisplayFixture
            // 
            this.lblDisplayFixture.AutoSize = true;
            this.lblDisplayFixture.Location = new System.Drawing.Point(128, 27);
            this.lblDisplayFixture.Name = "lblDisplayFixture";
            this.lblDisplayFixture.Size = new System.Drawing.Size(105, 15);
            this.lblDisplayFixture.TabIndex = 21;
            this.lblDisplayFixture.Text = "Team1 vs Team 2";
            // 
            // lblPotentialReturn
            // 
            this.lblPotentialReturn.AutoSize = true;
            this.lblPotentialReturn.Location = new System.Drawing.Point(207, 178);
            this.lblPotentialReturn.Name = "lblPotentialReturn";
            this.lblPotentialReturn.Size = new System.Drawing.Size(14, 15);
            this.lblPotentialReturn.TabIndex = 20;
            this.lblPotentialReturn.Text = "€";
            this.lblPotentialReturn.Visible = false;
            // 
            // lblPotentialReturnText
            // 
            this.lblPotentialReturnText.AutoSize = true;
            this.lblPotentialReturnText.Location = new System.Drawing.Point(16, 178);
            this.lblPotentialReturnText.Name = "lblPotentialReturnText";
            this.lblPotentialReturnText.Size = new System.Drawing.Size(135, 15);
            this.lblPotentialReturnText.TabIndex = 19;
            this.lblPotentialReturnText.Text = "Your potential return is: ";
            this.lblPotentialReturnText.Visible = false;
            // 
            // lblOdds
            // 
            this.lblOdds.AutoSize = true;
            this.lblOdds.Location = new System.Drawing.Point(264, 140);
            this.lblOdds.Name = "lblOdds";
            this.lblOdds.Size = new System.Drawing.Size(31, 15);
            this.lblOdds.TabIndex = 18;
            this.lblOdds.Text = "1.00";
            this.lblOdds.Visible = false;
            this.lblOdds.Click += new System.EventHandler(this.lblOdds_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 17;
            // 
            // lblOddsText
            // 
            this.lblOddsText.AutoSize = true;
            this.lblOddsText.Location = new System.Drawing.Point(16, 140);
            this.lblOddsText.Name = "lblOddsText";
            this.lblOddsText.Size = new System.Drawing.Size(242, 15);
            this.lblOddsText.TabIndex = 16;
            this.lblOddsText.Text = "The odds (Decimal) of this team winning is:";
            this.lblOddsText.Visible = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(231, 96);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 15;
            this.txtAmount.Visible = false;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(16, 103);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(217, 15);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "Enter the amount you would like to bet:";
            this.lblAmount.Visible = false;
            // 
            // cboSelectTeam
            // 
            this.cboSelectTeam.FormattingEnabled = true;
            this.cboSelectTeam.Location = new System.Drawing.Point(210, 57);
            this.cboSelectTeam.Name = "cboSelectTeam";
            this.cboSelectTeam.Size = new System.Drawing.Size(121, 21);
            this.cboSelectTeam.TabIndex = 13;
            this.cboSelectTeam.Text = "Select Team";
            this.cboSelectTeam.SelectedIndexChanged += new System.EventHandler(this.cboSelectTeam_SelectedIndexChanged);
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Location = new System.Drawing.Point(16, 60);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(189, 15);
            this.lblSelectTeam.TabIndex = 12;
            this.lblSelectTeam.Text = "Select the team you think will win:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(60, 204);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(271, 72);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Place Bet";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblSelectUser
            // 
            this.lblSelectUser.AutoSize = true;
            this.lblSelectUser.Location = new System.Drawing.Point(252, 28);
            this.lblSelectUser.Name = "lblSelectUser";
            this.lblSelectUser.Size = new System.Drawing.Size(73, 15);
            this.lblSelectUser.TabIndex = 15;
            this.lblSelectUser.Text = "Select User:";
            // 
            // cboSelectUser
            // 
            this.cboSelectUser.FormattingEnabled = true;
            this.cboSelectUser.Location = new System.Drawing.Point(385, 28);
            this.cboSelectUser.Name = "cboSelectUser";
            this.cboSelectUser.Size = new System.Drawing.Size(85, 21);
            this.cboSelectUser.TabIndex = 16;
            this.cboSelectUser.SelectedIndexChanged += new System.EventHandler(this.cboSelectUser_SelectedIndexChanged);
            // 
            // lblLogStatus
            // 
            this.lblLogStatus.AutoSize = true;
            this.lblLogStatus.Location = new System.Drawing.Point(252, 61);
            this.lblLogStatus.Name = "lblLogStatus";
            this.lblLogStatus.Size = new System.Drawing.Size(157, 15);
            this.lblLogStatus.TabIndex = 17;
            this.lblLogStatus.Text = "Logged in as: Not logged in";
            // 
            // frmPlaceBet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLogStatus);
            this.Controls.Add(this.cboSelectUser);
            this.Controls.Add(this.lblSelectUser);
            this.Controls.Add(this.grpPlaceBet);
            this.Controls.Add(this.cboSelectFixture);
            this.Controls.Add(this.lblSelectFixture);
            this.Controls.Add(this.mnuBackToMenu);
            this.Name = "frmPlaceBet";
            this.Text = "Place Bet";
            this.Load += new System.EventHandler(this.frmPlaceBet_Load);
            this.mnuBackToMenu.ResumeLayout(false);
            this.mnuBackToMenu.PerformLayout();
            this.grpPlaceBet.ResumeLayout(false);
            this.grpPlaceBet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBackToMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ComboBox cboSelectFixture;
        private System.Windows.Forms.Label lblSelectFixture;
        private System.Windows.Forms.GroupBox grpPlaceBet;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cboSelectTeam;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblOdds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOddsText;
        private System.Windows.Forms.Label lblPotentialReturn;
        private System.Windows.Forms.Label lblPotentialReturnText;
        private System.Windows.Forms.Label lblDisplayFixture;
        private System.Windows.Forms.Label lblSelectUser;
        private System.Windows.Forms.ComboBox cboSelectUser;
        private System.Windows.Forms.Label lblLogStatus;
    }
}

