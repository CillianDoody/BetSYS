namespace BettingSYS
{
    partial class frmUpdateFixtures
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
            this.lblSelectFixture = new System.Windows.Forms.Label();
            this.cboSelectFixture = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtFixtureTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.grpUpdateFixtures = new System.Windows.Forms.GroupBox();
            this.dtpFixtureDate = new System.Windows.Forms.DateTimePicker();
            this.mnuBackToMenu.SuspendLayout();
            this.grpUpdateFixtures.SuspendLayout();
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
            // lblSelectFixture
            // 
            this.lblSelectFixture.AutoSize = true;
            this.lblSelectFixture.Location = new System.Drawing.Point(208, 120);
            this.lblSelectFixture.Name = "lblSelectFixture";
            this.lblSelectFixture.Size = new System.Drawing.Size(74, 13);
            this.lblSelectFixture.TabIndex = 5;
            this.lblSelectFixture.Text = "Select Fixture:";
            // 
            // cboSelectFixture
            // 
            this.cboSelectFixture.FormattingEnabled = true;
            this.cboSelectFixture.Items.AddRange(new object[] {
            "Liverpool - Manchester United",
            "Newcastle United - Manchester City",
            "Wolverhampton Wanderers - Crystal Palace"});
            this.cboSelectFixture.Location = new System.Drawing.Point(393, 112);
            this.cboSelectFixture.Name = "cboSelectFixture";
            this.cboSelectFixture.Size = new System.Drawing.Size(217, 21);
            this.cboSelectFixture.TabIndex = 6;
            this.cboSelectFixture.SelectedIndexChanged += new System.EventHandler(this.cboSelectFixture_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(59, 39);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date:";
            this.lblDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFixtureTime
            // 
            this.txtFixtureTime.Location = new System.Drawing.Point(290, 94);
            this.txtFixtureTime.Name = "txtFixtureTime";
            this.txtFixtureTime.Size = new System.Drawing.Size(43, 20);
            this.txtFixtureTime.TabIndex = 10;
            this.txtFixtureTime.Text = "HH:MM";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(59, 94);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(62, 184);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(271, 72);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblHeading.Location = new System.Drawing.Point(165, 44);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(491, 26);
            this.lblHeading.TabIndex = 12;
            this.lblHeading.Text = "Please enter all the information to update a fixture";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // grpUpdateFixtures
            // 
            this.grpUpdateFixtures.Controls.Add(this.dtpFixtureDate);
            this.grpUpdateFixtures.Controls.Add(this.btnUpdate);
            this.grpUpdateFixtures.Controls.Add(this.txtFixtureTime);
            this.grpUpdateFixtures.Controls.Add(this.lblTime);
            this.grpUpdateFixtures.Controls.Add(this.lblDate);
            this.grpUpdateFixtures.Location = new System.Drawing.Point(211, 156);
            this.grpUpdateFixtures.Name = "grpUpdateFixtures";
            this.grpUpdateFixtures.Size = new System.Drawing.Size(382, 282);
            this.grpUpdateFixtures.TabIndex = 13;
            this.grpUpdateFixtures.TabStop = false;
            this.grpUpdateFixtures.Text = "Update";
            this.grpUpdateFixtures.Visible = false;
            this.grpUpdateFixtures.Enter += new System.EventHandler(this.grpUpdateFixtures_Enter);
            // 
            // dtpFixtureDate
            // 
            this.dtpFixtureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFixtureDate.Location = new System.Drawing.Point(254, 33);
            this.dtpFixtureDate.Name = "dtpFixtureDate";
            this.dtpFixtureDate.Size = new System.Drawing.Size(79, 20);
            this.dtpFixtureDate.TabIndex = 12;
            // 
            // frmUpdateFixtures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpUpdateFixtures);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.cboSelectFixture);
            this.Controls.Add(this.lblSelectFixture);
            this.Controls.Add(this.mnuBackToMenu);
            this.Name = "frmUpdateFixtures";
            this.Text = "Update Fixture";
            this.Load += new System.EventHandler(this.frmUpdateFixtures_Load);
            this.mnuBackToMenu.ResumeLayout(false);
            this.mnuBackToMenu.PerformLayout();
            this.grpUpdateFixtures.ResumeLayout(false);
            this.grpUpdateFixtures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBackToMenu;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
        private System.Windows.Forms.Label lblSelectFixture;
        private System.Windows.Forms.ComboBox cboSelectFixture;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtFixtureTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox grpUpdateFixtures;
        private System.Windows.Forms.DateTimePicker dtpFixtureDate;
    }
}