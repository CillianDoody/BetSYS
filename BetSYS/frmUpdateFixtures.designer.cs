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
            this.components = new System.ComponentModel.Container();
            this.mnuBackToMenu = new System.Windows.Forms.MenuStrip();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSelectFixture = new System.Windows.Forms.Label();
            this.cboSelectFixture = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.grpUpdateFixtures = new System.Windows.Forms.GroupBox();
            this.dtpFixtureDate = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cboFixtureTime = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDisplayFixture = new System.Windows.Forms.Label();
            this.mnuBackToMenu.SuspendLayout();
            this.grpUpdateFixtures.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBackToMenu
            // 
            this.mnuBackToMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackToMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMenuToolStripMenuItem});
            this.mnuBackToMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuBackToMenu.Name = "mnuBackToMenu";
            this.mnuBackToMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
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
            this.cboSelectFixture.Location = new System.Drawing.Point(393, 112);
            this.cboSelectFixture.Name = "cboSelectFixture";
            this.cboSelectFixture.Size = new System.Drawing.Size(217, 21);
            this.cboSelectFixture.TabIndex = 6;
            this.cboSelectFixture.SelectedIndexChanged += new System.EventHandler(this.cboSelectFixture_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(68, 95);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date:";
            this.lblDate.Click += new System.EventHandler(this.label1_Click);
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
            this.grpUpdateFixtures.Controls.Add(this.lblDisplayFixture);
            this.grpUpdateFixtures.Controls.Add(this.lblTime);
            this.grpUpdateFixtures.Controls.Add(this.cboFixtureTime);
            this.grpUpdateFixtures.Controls.Add(this.dtpFixtureDate);
            this.grpUpdateFixtures.Controls.Add(this.btnUpdate);
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
            this.dtpFixtureDate.Location = new System.Drawing.Point(255, 88);
            this.dtpFixtureDate.Name = "dtpFixtureDate";
            this.dtpFixtureDate.Size = new System.Drawing.Size(79, 20);
            this.dtpFixtureDate.TabIndex = 12;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cboFixtureTime
            // 
            this.cboFixtureTime.FormattingEnabled = true;
            this.cboFixtureTime.Location = new System.Drawing.Point(255, 123);
            this.cboFixtureTime.Name = "cboFixtureTime";
            this.cboFixtureTime.Size = new System.Drawing.Size(121, 21);
            this.cboFixtureTime.TabIndex = 13;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(68, 131);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Time:";
            // 
            // lblDisplayFixture
            // 
            this.lblDisplayFixture.AutoSize = true;
            this.lblDisplayFixture.Location = new System.Drawing.Point(141, 47);
            this.lblDisplayFixture.Name = "lblDisplayFixture";
            this.lblDisplayFixture.Size = new System.Drawing.Size(90, 13);
            this.lblDisplayFixture.TabIndex = 15;
            this.lblDisplayFixture.Text = "Team1 vs Team2";
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox grpUpdateFixtures;
        private System.Windows.Forms.DateTimePicker dtpFixtureDate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cboFixtureTime;
        private System.Windows.Forms.Label lblDisplayFixture;
    }
}