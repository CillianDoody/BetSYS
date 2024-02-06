namespace BetSYS
{
    partial class frmMainMenu
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
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.AccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTopUpWallet = new System.Windows.Forms.ToolStripMenuItem();
            this.betToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlaceBet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelBet = new System.Windows.Forms.ToolStripMenuItem();
            this.FixturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddFixture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateFixture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnterResult = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewFixtures = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTeamAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picMainMenuBackground = new System.Windows.Forms.PictureBox();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenuBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountToolStripMenuItem,
            this.betToolStripMenuItem,
            this.FixturesToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // AccountToolStripMenuItem
            // 
            this.AccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenAccount,
            this.mnuCloseAccount,
            this.mnuTopUpWallet});
            this.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem";
            this.AccountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.AccountToolStripMenuItem.Text = "Account";
            // 
            // mnuOpenAccount
            // 
            this.mnuOpenAccount.Name = "mnuOpenAccount";
            this.mnuOpenAccount.Size = new System.Drawing.Size(151, 22);
            this.mnuOpenAccount.Text = "Open Account";
            this.mnuOpenAccount.Click += new System.EventHandler(this.mnuOpenAccount_Click);
            // 
            // mnuCloseAccount
            // 
            this.mnuCloseAccount.Name = "mnuCloseAccount";
            this.mnuCloseAccount.Size = new System.Drawing.Size(151, 22);
            this.mnuCloseAccount.Text = "Close Account";
            this.mnuCloseAccount.Click += new System.EventHandler(this.mnuCloseAccount_Click);
            // 
            // mnuTopUpWallet
            // 
            this.mnuTopUpWallet.Name = "mnuTopUpWallet";
            this.mnuTopUpWallet.Size = new System.Drawing.Size(151, 22);
            this.mnuTopUpWallet.Text = "Top-up wallet";
            this.mnuTopUpWallet.Click += new System.EventHandler(this.mnuTopUpWallet_Click);
            // 
            // betToolStripMenuItem
            // 
            this.betToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPlaceBet,
            this.mnuCancelBet});
            this.betToolStripMenuItem.Name = "betToolStripMenuItem";
            this.betToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.betToolStripMenuItem.Text = "Bet";
            // 
            // mnuPlaceBet
            // 
            this.mnuPlaceBet.Name = "mnuPlaceBet";
            this.mnuPlaceBet.Size = new System.Drawing.Size(130, 22);
            this.mnuPlaceBet.Text = "Place Bet";
            this.mnuPlaceBet.Click += new System.EventHandler(this.mnuPlaceBet_Click);
            // 
            // mnuCancelBet
            // 
            this.mnuCancelBet.Name = "mnuCancelBet";
            this.mnuCancelBet.Size = new System.Drawing.Size(130, 22);
            this.mnuCancelBet.Text = "Cancel Bet";
            this.mnuCancelBet.Click += new System.EventHandler(this.mnuCancelBet_Click);
            // 
            // FixturesToolStripMenuItem
            // 
            this.FixturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddFixture,
            this.mnuUpdateFixture,
            this.mnuEnterResult,
            this.mnuViewFixtures});
            this.FixturesToolStripMenuItem.Name = "FixturesToolStripMenuItem";
            this.FixturesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.FixturesToolStripMenuItem.Text = "Fixtures";
            this.FixturesToolStripMenuItem.Click += new System.EventHandler(this.fixturesToolStripMenuItem_Click);
            // 
            // mnuAddFixture
            // 
            this.mnuAddFixture.Name = "mnuAddFixture";
            this.mnuAddFixture.Size = new System.Drawing.Size(180, 22);
            this.mnuAddFixture.Text = "Add Fixture";
            this.mnuAddFixture.Click += new System.EventHandler(this.mnuAddFixture_Click);
            // 
            // mnuUpdateFixture
            // 
            this.mnuUpdateFixture.Name = "mnuUpdateFixture";
            this.mnuUpdateFixture.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdateFixture.Text = "Update Fixture";
            this.mnuUpdateFixture.Click += new System.EventHandler(this.updateFixtureToolStripMenuItem_Click);
            // 
            // mnuEnterResult
            // 
            this.mnuEnterResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuEnterResult.Name = "mnuEnterResult";
            this.mnuEnterResult.Size = new System.Drawing.Size(180, 22);
            this.mnuEnterResult.Text = "Enter Result";
            this.mnuEnterResult.Click += new System.EventHandler(this.mnuEnterResult_Click);
            // 
            // mnuViewFixtures
            // 
            this.mnuViewFixtures.Name = "mnuViewFixtures";
            this.mnuViewFixtures.Size = new System.Drawing.Size(180, 22);
            this.mnuViewFixtures.Text = "View Fixtures";
            this.mnuViewFixtures.Click += new System.EventHandler(this.viewFixtureToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTeamAnalysis,
            this.mnuRevenue});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // mnuTeamAnalysis
            // 
            this.mnuTeamAnalysis.Name = "mnuTeamAnalysis";
            this.mnuTeamAnalysis.Size = new System.Drawing.Size(182, 22);
            this.mnuTeamAnalysis.Text = "View Team Analaysis";
            this.mnuTeamAnalysis.Click += new System.EventHandler(this.mnuTeamAnalysis_Click);
            // 
            // mnuRevenue
            // 
            this.mnuRevenue.Name = "mnuRevenue";
            this.mnuRevenue.Size = new System.Drawing.Size(182, 22);
            this.mnuRevenue.Text = "View Revenue";
            this.mnuRevenue.Click += new System.EventHandler(this.viewRevenueToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // picMainMenuBackground
            // 
            this.picMainMenuBackground.Image = global::BetSYS.Properties.Resources.Main_Menu_Background;
            this.picMainMenuBackground.Location = new System.Drawing.Point(-58, -51);
            this.picMainMenuBackground.Name = "picMainMenuBackground";
            this.picMainMenuBackground.Size = new System.Drawing.Size(858, 512);
            this.picMainMenuBackground.TabIndex = 0;
            this.picMainMenuBackground.TabStop = false;
            this.picMainMenuBackground.Click += new System.EventHandler(this.picMainMenuBackground_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.picMainMenuBackground);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenuBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem AccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FixturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuTopUpWallet;
        private System.Windows.Forms.ToolStripMenuItem mnuPlaceBet;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelBet;
        private System.Windows.Forms.ToolStripMenuItem mnuAddFixture;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateFixture;
        private System.Windows.Forms.ToolStripMenuItem mnuEnterResult;
        private System.Windows.Forms.ToolStripMenuItem mnuViewFixtures;
        private System.Windows.Forms.ToolStripMenuItem mnuTeamAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuRevenue;
        private System.Windows.Forms.PictureBox picMainMenuBackground;
    }
}