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
            this.cboSelectFixture = new System.Windows.Forms.ComboBox();
            this.lblSelectFixture = new System.Windows.Forms.Label();
            this.btnCancelBet = new System.Windows.Forms.Button();
            this.mnuBackToMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBackToMenu
            // 
            this.mnuBackToMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMenuToolStripMenuItem});
            this.mnuBackToMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuBackToMenu.Name = "mnuBackToMenu";
            this.mnuBackToMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuBackToMenu.TabIndex = 4;
            this.mnuBackToMenu.Text = "menuStrip1";
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.backToMenuToolStripMenuItem.Text = "Back to menu";
            this.backToMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblHeading.Location = new System.Drawing.Point(162, 56);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(463, 26);
            this.lblHeading.TabIndex = 20;
            this.lblHeading.Text = "Please choose the bet you would like to cancel";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboSelectFixture
            // 
            this.cboSelectFixture.FormattingEnabled = true;
            this.cboSelectFixture.Items.AddRange(new object[] {
            "Liverpool - Manchester United",
            "Newcastle United - Manchester City",
            "Wolverhampton Wanderers - Crystal Palace"});
            this.cboSelectFixture.Location = new System.Drawing.Point(391, 141);
            this.cboSelectFixture.Name = "cboSelectFixture";
            this.cboSelectFixture.Size = new System.Drawing.Size(217, 21);
            this.cboSelectFixture.TabIndex = 22;
            this.cboSelectFixture.SelectedIndexChanged += new System.EventHandler(this.cboSelectFixture_SelectedIndexChanged);
            // 
            // lblSelectFixture
            // 
            this.lblSelectFixture.AutoSize = true;
            this.lblSelectFixture.Location = new System.Drawing.Point(193, 149);
            this.lblSelectFixture.Name = "lblSelectFixture";
            this.lblSelectFixture.Size = new System.Drawing.Size(74, 13);
            this.lblSelectFixture.TabIndex = 21;
            this.lblSelectFixture.Text = "Select Fixture:";
            // 
            // btnCancelBet
            // 
            this.btnCancelBet.Location = new System.Drawing.Point(263, 277);
            this.btnCancelBet.Name = "btnCancelBet";
            this.btnCancelBet.Size = new System.Drawing.Size(264, 52);
            this.btnCancelBet.TabIndex = 23;
            this.btnCancelBet.Text = "Cancel Bet";
            this.btnCancelBet.UseVisualStyleBackColor = true;
            this.btnCancelBet.Visible = false;
            this.btnCancelBet.Click += new System.EventHandler(this.btnCancelBet_Click);
            // 
            // frmCancelBet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelBet);
            this.Controls.Add(this.cboSelectFixture);
            this.Controls.Add(this.lblSelectFixture);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.mnuBackToMenu);
            this.Name = "frmCancelBet";
            this.Text = "Cancel Bet";
            this.mnuBackToMenu.ResumeLayout(false);
            this.mnuBackToMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBackToMenu;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ComboBox cboSelectFixture;
        private System.Windows.Forms.Label lblSelectFixture;
        private System.Windows.Forms.Button btnCancelBet;
    }
}