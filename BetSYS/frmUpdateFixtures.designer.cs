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
            this.lblOddsTeam1 = new System.Windows.Forms.Label();
            this.lblOddsTeam2 = new System.Windows.Forms.Label();
            this.txtOddsTeam1 = new System.Windows.Forms.TextBox();
            this.txtOddsTeam2 = new System.Windows.Forms.TextBox();
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
            this.mnuBackToMenu.Size = new System.Drawing.Size(1067, 28);
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
            // lblSelectFixture
            // 
            this.lblSelectFixture.AutoSize = true;
            this.lblSelectFixture.Location = new System.Drawing.Point(277, 148);
            this.lblSelectFixture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectFixture.Name = "lblSelectFixture";
            this.lblSelectFixture.Size = new System.Drawing.Size(90, 16);
            this.lblSelectFixture.TabIndex = 5;
            this.lblSelectFixture.Text = "Select Fixture:";
            // 
            // cboSelectFixture
            // 
            this.cboSelectFixture.FormattingEnabled = true;
            this.cboSelectFixture.Location = new System.Drawing.Point(524, 138);
            this.cboSelectFixture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSelectFixture.Name = "cboSelectFixture";
            this.cboSelectFixture.Size = new System.Drawing.Size(288, 24);
            this.cboSelectFixture.TabIndex = 6;
            this.cboSelectFixture.SelectedIndexChanged += new System.EventHandler(this.cboSelectFixture_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(79, 48);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 16);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date:";
            this.lblDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(83, 226);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(361, 89);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblHeading.Location = new System.Drawing.Point(220, 54);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(609, 31);
            this.lblHeading.TabIndex = 12;
            this.lblHeading.Text = "Please enter all the information to update a fixture";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // grpUpdateFixtures
            // 
            this.grpUpdateFixtures.Controls.Add(this.txtOddsTeam2);
            this.grpUpdateFixtures.Controls.Add(this.txtOddsTeam1);
            this.grpUpdateFixtures.Controls.Add(this.lblOddsTeam2);
            this.grpUpdateFixtures.Controls.Add(this.lblOddsTeam1);
            this.grpUpdateFixtures.Controls.Add(this.dtpFixtureDate);
            this.grpUpdateFixtures.Controls.Add(this.btnUpdate);
            this.grpUpdateFixtures.Controls.Add(this.lblDate);
            this.grpUpdateFixtures.Location = new System.Drawing.Point(281, 192);
            this.grpUpdateFixtures.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpUpdateFixtures.Name = "grpUpdateFixtures";
            this.grpUpdateFixtures.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpUpdateFixtures.Size = new System.Drawing.Size(509, 347);
            this.grpUpdateFixtures.TabIndex = 13;
            this.grpUpdateFixtures.TabStop = false;
            this.grpUpdateFixtures.Text = "Update";
            this.grpUpdateFixtures.Visible = false;
            this.grpUpdateFixtures.Enter += new System.EventHandler(this.grpUpdateFixtures_Enter);
            // 
            // dtpFixtureDate
            // 
            this.dtpFixtureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFixtureDate.Location = new System.Drawing.Point(339, 41);
            this.dtpFixtureDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFixtureDate.Name = "dtpFixtureDate";
            this.dtpFixtureDate.Size = new System.Drawing.Size(104, 22);
            this.dtpFixtureDate.TabIndex = 12;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblOddsTeam1
            // 
            this.lblOddsTeam1.AutoSize = true;
            this.lblOddsTeam1.Location = new System.Drawing.Point(74, 102);
            this.lblOddsTeam1.Name = "lblOddsTeam1";
            this.lblOddsTeam1.Size = new System.Drawing.Size(58, 16);
            this.lblOddsTeam1.TabIndex = 13;
            this.lblOddsTeam1.Text = "Odds for";
            this.lblOddsTeam1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblOddsTeam2
            // 
            this.lblOddsTeam2.AutoSize = true;
            this.lblOddsTeam2.Location = new System.Drawing.Point(74, 151);
            this.lblOddsTeam2.Name = "lblOddsTeam2";
            this.lblOddsTeam2.Size = new System.Drawing.Size(58, 16);
            this.lblOddsTeam2.TabIndex = 14;
            this.lblOddsTeam2.Text = "Odds for";
            // 
            // txtOddsTeam1
            // 
            this.txtOddsTeam1.Location = new System.Drawing.Point(339, 96);
            this.txtOddsTeam1.Name = "txtOddsTeam1";
            this.txtOddsTeam1.Size = new System.Drawing.Size(100, 22);
            this.txtOddsTeam1.TabIndex = 15;
            // 
            // txtOddsTeam2
            // 
            this.txtOddsTeam2.Location = new System.Drawing.Point(339, 145);
            this.txtOddsTeam2.Name = "txtOddsTeam2";
            this.txtOddsTeam2.Size = new System.Drawing.Size(100, 22);
            this.txtOddsTeam2.TabIndex = 16;
            // 
            // frmUpdateFixtures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpUpdateFixtures);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.cboSelectFixture);
            this.Controls.Add(this.lblSelectFixture);
            this.Controls.Add(this.mnuBackToMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblOddsTeam1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtOddsTeam2;
        private System.Windows.Forms.TextBox txtOddsTeam1;
        private System.Windows.Forms.Label lblOddsTeam2;
    }
}