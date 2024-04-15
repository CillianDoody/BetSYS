namespace BettingSYS
{
    partial class frmEnterResults
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.cboSelectFixture = new System.Windows.Forms.ComboBox();
            this.lblSelectFixture = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.mnuBackToMenu = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.grpEnterResult = new System.Windows.Forms.GroupBox();
            this.mnuBackToMenu.SuspendLayout();
            this.grpEnterResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(49, 146);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(271, 72);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(277, 39);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(43, 20);
            this.txtScore1.TabIndex = 17;
            this.txtScore1.Text = "0";
            this.txtScore1.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Location = new System.Drawing.Point(46, 39);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(46, 15);
            this.lblTeam1.TabIndex = 16;
            this.lblTeam1.Text = "Team1";
            this.lblTeam1.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // cboSelectFixture
            // 
            this.cboSelectFixture.FormattingEnabled = true;
            this.cboSelectFixture.Location = new System.Drawing.Point(414, 107);
            this.cboSelectFixture.Name = "cboSelectFixture";
            this.cboSelectFixture.Size = new System.Drawing.Size(147, 21);
            this.cboSelectFixture.TabIndex = 13;
            this.cboSelectFixture.Text = "Please choose a fixture.";
            this.cboSelectFixture.SelectedIndexChanged += new System.EventHandler(this.cboSelectFixture_SelectedIndexChanged);
            // 
            // lblSelectFixture
            // 
            this.lblSelectFixture.AutoSize = true;
            this.lblSelectFixture.Location = new System.Drawing.Point(220, 113);
            this.lblSelectFixture.Name = "lblSelectFixture";
            this.lblSelectFixture.Size = new System.Drawing.Size(84, 15);
            this.lblSelectFixture.TabIndex = 12;
            this.lblSelectFixture.Text = "Select Fixture:";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblHeading.Location = new System.Drawing.Point(200, 28);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(418, 31);
            this.lblHeading.TabIndex = 19;
            this.lblHeading.Text = "Please enter the score of a fixture";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // mnuBackToMenu
            // 
            this.mnuBackToMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackToMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackToMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuBackToMenu.Name = "mnuBackToMenu";
            this.mnuBackToMenu.Size = new System.Drawing.Size(800, 28);
            this.mnuBackToMenu.TabIndex = 20;
            this.mnuBackToMenu.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(113, 24);
            this.mnuBack.Text = "Back to menu";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(277, 103);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(43, 20);
            this.txtScore2.TabIndex = 22;
            this.txtScore2.Text = "0";
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Location = new System.Drawing.Point(46, 103);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(46, 15);
            this.lblTeam2.TabIndex = 21;
            this.lblTeam2.Text = "Team2";
            // 
            // grpEnterResult
            // 
            this.grpEnterResult.Controls.Add(this.txtScore2);
            this.grpEnterResult.Controls.Add(this.lblTeam2);
            this.grpEnterResult.Controls.Add(this.btnConfirm);
            this.grpEnterResult.Controls.Add(this.txtScore1);
            this.grpEnterResult.Controls.Add(this.lblTeam1);
            this.grpEnterResult.Location = new System.Drawing.Point(206, 165);
            this.grpEnterResult.Name = "grpEnterResult";
            this.grpEnterResult.Size = new System.Drawing.Size(386, 251);
            this.grpEnterResult.TabIndex = 23;
            this.grpEnterResult.TabStop = false;
            this.grpEnterResult.Text = "Enter Result";
            this.grpEnterResult.Visible = false;
            // 
            // frmEnterResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpEnterResult);
            this.Controls.Add(this.mnuBackToMenu);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.cboSelectFixture);
            this.Controls.Add(this.lblSelectFixture);
            this.Name = "frmEnterResults";
            this.Text = "Enter Results";
            this.Load += new System.EventHandler(this.frmEnterResults_Load);
            this.mnuBackToMenu.ResumeLayout(false);
            this.mnuBackToMenu.PerformLayout();
            this.grpEnterResult.ResumeLayout(false);
            this.grpEnterResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.ComboBox cboSelectFixture;
        private System.Windows.Forms.Label lblSelectFixture;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.MenuStrip mnuBackToMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.GroupBox grpEnterResult;
    }
}