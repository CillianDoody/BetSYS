namespace BettingSYS
{
    partial class frmAddFixture
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.cboTeam1 = new System.Windows.Forms.ComboBox();
            this.cboTeam2 = new System.Windows.Forms.ComboBox();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.mnuBackToMenu = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpFixtureDate = new System.Windows.Forms.DateTimePicker();
            this.txtFixtureTime = new System.Windows.Forms.TextBox();
            this.mnuBackToMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblHeading.Location = new System.Drawing.Point(150, 32);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(461, 26);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Please enter all the information to add a fixture";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Location = new System.Drawing.Point(252, 116);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(46, 13);
            this.lblTeam1.TabIndex = 1;
            this.lblTeam1.Text = "Team 1:";
            // 
            // cboTeam1
            // 
            this.cboTeam1.FormattingEnabled = true;
            this.cboTeam1.Items.AddRange(new object[] {
            "Arsenal",
            "Aston Villa FC",
            "Bournemouth AFC",
            "Brentford",
            "Brighton & Hove Albion",
            "Burnley",
            "Chelsea",
            "Crystal Palace",
            "Everton FC",
            "Fulham",
            "Liverpool FC",
            "Luton Town",
            "Manchester City FC",
            "Manchester United FC",
            "Newcastle United",
            "Nottingham Forest",
            "Sheffield United",
            "Tottenham Hotspur FC",
            "West Ham United",
            "Wolverhampton Wanderers"});
            this.cboTeam1.Location = new System.Drawing.Point(483, 116);
            this.cboTeam1.Name = "cboTeam1";
            this.cboTeam1.Size = new System.Drawing.Size(253, 21);
            this.cboTeam1.TabIndex = 2;
            this.cboTeam1.Text = "Please select the first team.";
            // 
            // cboTeam2
            // 
            this.cboTeam2.FormattingEnabled = true;
            this.cboTeam2.Items.AddRange(new object[] {
            "Arsenal",
            "Aston Villa FC",
            "Bournemouth AFC",
            "Brentford",
            "Brighton & Hove Albion",
            "Burnley",
            "Chelsea",
            "Crystal Palace",
            "Everton FC",
            "Fulham",
            "Liverpool FC",
            "Luton Town",
            "Manchester City FC",
            "Manchester United FC",
            "Newcastle United",
            "Nottingham Forest",
            "Sheffield United",
            "Tottenham Hotspur FC",
            "West Ham United",
            "Wolverhampton Wanderers"});
            this.cboTeam2.Location = new System.Drawing.Point(483, 171);
            this.cboTeam2.Name = "cboTeam2";
            this.cboTeam2.Size = new System.Drawing.Size(253, 21);
            this.cboTeam2.TabIndex = 4;
            this.cboTeam2.Text = "Please select the second team.";
            this.cboTeam2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Location = new System.Drawing.Point(252, 171);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(46, 13);
            this.lblTeam2.TabIndex = 3;
            this.lblTeam2.Text = "Team 2:";
            this.lblTeam2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(252, 228);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(252, 287);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time:";
            this.lblTime.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(255, 329);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(271, 72);
            this.btnConfirm.TabIndex = 9;
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
            this.mnuBackToMenu.TabIndex = 10;
            this.mnuBackToMenu.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(92, 20);
            this.mnuBack.Text = "Back to menu";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // dtpFixtureDate
            // 
            this.dtpFixtureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFixtureDate.Location = new System.Drawing.Point(482, 230);
            this.dtpFixtureDate.Name = "dtpFixtureDate";
            this.dtpFixtureDate.Size = new System.Drawing.Size(80, 20);
            this.dtpFixtureDate.TabIndex = 11;
            this.dtpFixtureDate.TabStop = false;
            // 
            // txtFixtureTime
            // 
            this.txtFixtureTime.Location = new System.Drawing.Point(482, 280);
            this.txtFixtureTime.MaxLength = 5;
            this.txtFixtureTime.Name = "txtFixtureTime";
            this.txtFixtureTime.Size = new System.Drawing.Size(60, 20);
            this.txtFixtureTime.TabIndex = 12;
            this.txtFixtureTime.Text = "HH:MM";
            // 
            // frmAddFixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFixtureTime);
            this.Controls.Add(this.dtpFixtureDate);
            this.Controls.Add(this.mnuBackToMenu);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cboTeam2);
            this.Controls.Add(this.lblTeam2);
            this.Controls.Add(this.cboTeam1);
            this.Controls.Add(this.lblTeam1);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmAddFixture";
            this.Text = "Add Fixture";
            this.Load += new System.EventHandler(this.frmAddFixture_Load);
            this.mnuBackToMenu.ResumeLayout(false);
            this.mnuBackToMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.ComboBox cboTeam1;
        private System.Windows.Forms.ComboBox cboTeam2;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.MenuStrip mnuBackToMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DateTimePicker dtpFixtureDate;
        private System.Windows.Forms.TextBox txtFixtureTime;
    }
}