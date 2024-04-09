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
            this.cboFixtureTime = new System.Windows.Forms.ComboBox();
            this.lblOddsTeam2 = new System.Windows.Forms.Label();
            this.lblOddsTeam1 = new System.Windows.Forms.Label();
            this.txtOddsTeam1 = new System.Windows.Forms.TextBox();
            this.txtOddsTeam2 = new System.Windows.Forms.TextBox();
            this.mnuBackToMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblHeading.Location = new System.Drawing.Point(200, 39);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(571, 31);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Please enter all the information to add a fixture";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Location = new System.Drawing.Point(365, 143);
            this.lblTeam1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(56, 16);
            this.lblTeam1.TabIndex = 1;
            this.lblTeam1.Text = "Team 1:";
            // 
            // cboTeam1
            // 
            this.cboTeam1.FormattingEnabled = true;
            this.cboTeam1.Location = new System.Drawing.Point(568, 143);
            this.cboTeam1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTeam1.Name = "cboTeam1";
            this.cboTeam1.Size = new System.Drawing.Size(336, 24);
            this.cboTeam1.TabIndex = 2;
            this.cboTeam1.Text = "Please select the first team.";
            // 
            // cboTeam2
            // 
            this.cboTeam2.FormattingEnabled = true;
            this.cboTeam2.Location = new System.Drawing.Point(568, 190);
            this.cboTeam2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTeam2.Name = "cboTeam2";
            this.cboTeam2.Size = new System.Drawing.Size(336, 24);
            this.cboTeam2.TabIndex = 4;
            this.cboTeam2.Text = "Please select the second team.";
            this.cboTeam2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Location = new System.Drawing.Point(365, 190);
            this.lblTeam2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(56, 16);
            this.lblTeam2.TabIndex = 3;
            this.lblTeam2.Text = "Team 2:";
            this.lblTeam2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(366, 309);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(366, 351);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 16);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time:";
            this.lblTime.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(340, 405);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(361, 89);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // mnuBackToMenu
            // 
            this.mnuBackToMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackToMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackToMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuBackToMenu.Name = "mnuBackToMenu";
            this.mnuBackToMenu.Size = new System.Drawing.Size(1067, 28);
            this.mnuBackToMenu.TabIndex = 10;
            this.mnuBackToMenu.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(113, 24);
            this.mnuBack.Text = "Back to menu";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // dtpFixtureDate
            // 
            this.dtpFixtureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFixtureDate.Location = new System.Drawing.Point(569, 309);
            this.dtpFixtureDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFixtureDate.Name = "dtpFixtureDate";
            this.dtpFixtureDate.Size = new System.Drawing.Size(105, 22);
            this.dtpFixtureDate.TabIndex = 11;
            this.dtpFixtureDate.TabStop = false;
            // 
            // cboFixtureTime
            // 
            this.cboFixtureTime.FormattingEnabled = true;
            this.cboFixtureTime.Location = new System.Drawing.Point(568, 351);
            this.cboFixtureTime.Name = "cboFixtureTime";
            this.cboFixtureTime.Size = new System.Drawing.Size(232, 24);
            this.cboFixtureTime.TabIndex = 12;
            this.cboFixtureTime.Text = "Please select a time for the fixture";
            this.cboFixtureTime.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // lblOddsTeam2
            // 
            this.lblOddsTeam2.AutoSize = true;
            this.lblOddsTeam2.Location = new System.Drawing.Point(365, 269);
            this.lblOddsTeam2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOddsTeam2.Name = "lblOddsTeam2";
            this.lblOddsTeam2.Size = new System.Drawing.Size(92, 16);
            this.lblOddsTeam2.TabIndex = 15;
            this.lblOddsTeam2.Text = "Odds Team 2:";
            // 
            // lblOddsTeam1
            // 
            this.lblOddsTeam1.AutoSize = true;
            this.lblOddsTeam1.Location = new System.Drawing.Point(365, 231);
            this.lblOddsTeam1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOddsTeam1.Name = "lblOddsTeam1";
            this.lblOddsTeam1.Size = new System.Drawing.Size(92, 16);
            this.lblOddsTeam1.TabIndex = 13;
            this.lblOddsTeam1.Text = "Odds Team 1:";
            // 
            // txtOddsTeam1
            // 
            this.txtOddsTeam1.Location = new System.Drawing.Point(568, 228);
            this.txtOddsTeam1.Name = "txtOddsTeam1";
            this.txtOddsTeam1.Size = new System.Drawing.Size(100, 22);
            this.txtOddsTeam1.TabIndex = 16;
            // 
            // txtOddsTeam2
            // 
            this.txtOddsTeam2.Location = new System.Drawing.Point(569, 269);
            this.txtOddsTeam2.Name = "txtOddsTeam2";
            this.txtOddsTeam2.Size = new System.Drawing.Size(100, 22);
            this.txtOddsTeam2.TabIndex = 17;
            // 
            // frmAddFixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtOddsTeam2);
            this.Controls.Add(this.txtOddsTeam1);
            this.Controls.Add(this.lblOddsTeam2);
            this.Controls.Add(this.lblOddsTeam1);
            this.Controls.Add(this.cboFixtureTime);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ComboBox cboFixtureTime;
        private System.Windows.Forms.Label lblOddsTeam2;
        private System.Windows.Forms.Label lblOddsTeam1;
        private System.Windows.Forms.TextBox txtOddsTeam1;
        private System.Windows.Forms.TextBox txtOddsTeam2;
    }
}