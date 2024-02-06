namespace BettingSYS
{
    partial class frmCloseAccount
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCloseAccount = new System.Windows.Forms.Button();
            this.mnuBackToMenu = new System.Windows.Forms.MenuStrip();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackToMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(93, 133);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(270, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Please enter the email of the account you wish to close:";
            this.lblEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(421, 126);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // btnCloseAccount
            // 
            this.btnCloseAccount.Location = new System.Drawing.Point(259, 285);
            this.btnCloseAccount.Name = "btnCloseAccount";
            this.btnCloseAccount.Size = new System.Drawing.Size(264, 52);
            this.btnCloseAccount.TabIndex = 2;
            this.btnCloseAccount.Text = "Close Account";
            this.btnCloseAccount.UseVisualStyleBackColor = true;
            this.btnCloseAccount.Click += new System.EventHandler(this.btnCloseAccount_Click);
            // 
            // mnuBackToMenu
            // 
            this.mnuBackToMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMenuToolStripMenuItem});
            this.mnuBackToMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuBackToMenu.Name = "mnuBackToMenu";
            this.mnuBackToMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuBackToMenu.TabIndex = 3;
            this.mnuBackToMenu.Text = "menuStrip1";
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.backToMenuToolStripMenuItem.Text = "Back to menu";
            this.backToMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
            // 
            // frmCloseAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuBackToMenu);
            this.Controls.Add(this.btnCloseAccount);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Name = "frmCloseAccount";
            this.Text = "Close Account";
            this.Load += new System.EventHandler(this.frmCloseAccount_Load);
            this.mnuBackToMenu.ResumeLayout(false);
            this.mnuBackToMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCloseAccount;
        private System.Windows.Forms.MenuStrip mnuBackToMenu;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
    }
}