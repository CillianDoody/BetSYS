namespace BettingSYS
{
    partial class frmOpenAccount
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
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblSName = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.mnuBackToMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBackToMenu
            // 
            this.mnuBackToMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackToMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuBackToMenu.Name = "mnuBackToMenu";
            this.mnuBackToMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuBackToMenu.TabIndex = 2;
            this.mnuBackToMenu.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(92, 20);
            this.mnuBack.Text = "Back to menu";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(305, 94);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 3;
            this.lblFName.Text = "First Name:";
            this.lblFName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(392, 87);
            this.txtFName.MaxLength = 20;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(121, 20);
            this.txtFName.TabIndex = 4;
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(305, 135);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(52, 13);
            this.lblSName.TabIndex = 5;
            this.lblSName.Text = "Surname:";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(392, 128);
            this.txtSName.MaxLength = 20;
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(121, 20);
            this.txtSName.TabIndex = 6;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(305, 176);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(71, 13);
            this.lblDOB.TabIndex = 7;
            this.lblDOB.Text = "Date Of Birth:";
            this.lblDOB.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(305, 218);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Phone Number:";
            this.lblPhoneNumber.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(392, 211);
            this.txtPhoneNumber.MaxLength = 10;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(121, 20);
            this.txtPhoneNumber.TabIndex = 10;
            this.txtPhoneNumber.Text = "08";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email:";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(392, 250);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(392, 297);
            this.txtPostCode.MaxLength = 7;
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(121, 20);
            this.txtPostCode.TabIndex = 13;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(306, 304);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(55, 13);
            this.lblPostcode.TabIndex = 14;
            this.lblPostcode.Text = "Postcode:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(309, 360);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(204, 39);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(392, 170);
            this.dtpDOB.MaxDate = new System.DateTime(2023, 12, 25, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(117, 20);
            this.dtpDOB.TabIndex = 16;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // frmOpenAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.lblSName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.mnuBackToMenu);
            this.Name = "frmOpenAccount";
            this.Text = "Open Account";
            this.Load += new System.EventHandler(this.frmOpenAccount_Load);
            this.mnuBackToMenu.ResumeLayout(false);
            this.mnuBackToMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBackToMenu;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}