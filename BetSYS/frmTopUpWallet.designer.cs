namespace BettingSYS
{
    partial class frmTopUpWallet
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
            this.lblAmmount = new System.Windows.Forms.Label();
            this.cboMoneyOptions = new System.Windows.Forms.ComboBox();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblCVC = new System.Windows.Forms.Label();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.mnuBackToMenu = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.mnuBackToMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAmmount
            // 
            this.lblAmmount.AutoSize = true;
            this.lblAmmount.Location = new System.Drawing.Point(93, 260);
            this.lblAmmount.Name = "lblAmmount";
            this.lblAmmount.Size = new System.Drawing.Size(261, 13);
            this.lblAmmount.TabIndex = 0;
            this.lblAmmount.Text = "How much money would you like to add to the wallet?";
            // 
            // cboMoneyOptions
            // 
            this.cboMoneyOptions.DisplayMember = "5";
            this.cboMoneyOptions.FormattingEnabled = true;
            this.cboMoneyOptions.Items.AddRange(new object[] {
            "€5.00",
            "€10.00",
            "€25.00",
            "€50.00",
            "€100.00",
            "€200.00",
            "€250.00"});
            this.cboMoneyOptions.Location = new System.Drawing.Point(386, 260);
            this.cboMoneyOptions.Name = "cboMoneyOptions";
            this.cboMoneyOptions.Size = new System.Drawing.Size(289, 21);
            this.cboMoneyOptions.TabIndex = 1;
            this.cboMoneyOptions.Text = "Please select the ammount you wish to add to the wallet";
            this.cboMoneyOptions.SelectedIndexChanged += new System.EventHandler(this.cboMoneyOptions_SelectedIndexChanged);
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(98, 71);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(72, 13);
            this.lblCardNo.TabIndex = 2;
            this.lblCardNo.Text = "Card Number:";
            this.lblCardNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(386, 68);
            this.txtCardNo.MaxLength = 16;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(289, 20);
            this.txtCardNo.TabIndex = 3;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(98, 131);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(64, 13);
            this.lblExpiryDate.TabIndex = 4;
            this.lblExpiryDate.Text = "Expiry Date:";
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Location = new System.Drawing.Point(98, 196);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(29, 13);
            this.lblCVC.TabIndex = 6;
            this.lblCVC.Text = "Cvc:";
            // 
            // txtCVC
            // 
            this.txtCVC.Location = new System.Drawing.Point(386, 189);
            this.txtCVC.MaxLength = 3;
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(70, 20);
            this.txtCVC.TabIndex = 7;
            this.txtCVC.TextChanged += new System.EventHandler(this.txtCVC_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(252, 326);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(271, 72);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // mnuBackToMenu
            // 
            this.mnuBackToMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackToMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuBackToMenu.Name = "mnuBackToMenu";
            this.mnuBackToMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuBackToMenu.TabIndex = 9;
            this.mnuBackToMenu.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(92, 20);
            this.mnuBack.Text = "Back to menu";
            this.mnuBack.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiryDate.Location = new System.Drawing.Point(386, 131);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(83, 20);
            this.dtpExpiryDate.TabIndex = 10;
            // 
            // frmTopUpWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpExpiryDate);
            this.Controls.Add(this.mnuBackToMenu);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtCVC);
            this.Controls.Add(this.lblCVC);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.lblCardNo);
            this.Controls.Add(this.cboMoneyOptions);
            this.Controls.Add(this.lblAmmount);
            this.Name = "frmTopUpWallet";
            this.Text = "Top-up Wallet";
            this.Load += new System.EventHandler(this.frmTopUpWallet_Load);
            this.mnuBackToMenu.ResumeLayout(false);
            this.mnuBackToMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmmount;
        private System.Windows.Forms.ComboBox cboMoneyOptions;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblCVC;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.MenuStrip mnuBackToMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
    }
}