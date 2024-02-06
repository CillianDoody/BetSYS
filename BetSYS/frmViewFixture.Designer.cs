namespace BetSYS
{
    partial class frmViewFixture
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
            this.lblLiverpool = new System.Windows.Forms.Label();
            this.lblManchesterUnited = new System.Windows.Forms.Label();
            this.lblMatchDate = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMatchTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.grpMatch1 = new System.Windows.Forms.GroupBox();
            this.grpMatch2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.lblManchesterCity = new System.Windows.Forms.Label();
            this.lblNewcastleUnited = new System.Windows.Forms.Label();
            this.grpMatch3 = new System.Windows.Forms.GroupBox();
            this.lblMatchTime3 = new System.Windows.Forms.Label();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.lblMatchDate3 = new System.Windows.Forms.Label();
            this.lblDate3 = new System.Windows.Forms.Label();
            this.lblCrystalPalace = new System.Windows.Forms.Label();
            this.lblWolverhamptonWanderers = new System.Windows.Forms.Label();
            this.mnuBackToMenu.SuspendLayout();
            this.grpMatch1.SuspendLayout();
            this.grpMatch2.SuspendLayout();
            this.grpMatch3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBackToMenu
            // 
            this.mnuBackToMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackToMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuBackToMenu.Name = "mnuBackToMenu";
            this.mnuBackToMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuBackToMenu.TabIndex = 3;
            this.mnuBackToMenu.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(92, 20);
            this.mnuBack.Text = "Back to menu";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // lblLiverpool
            // 
            this.lblLiverpool.AutoSize = true;
            this.lblLiverpool.Location = new System.Drawing.Point(34, 26);
            this.lblLiverpool.Name = "lblLiverpool";
            this.lblLiverpool.Size = new System.Drawing.Size(50, 13);
            this.lblLiverpool.TabIndex = 4;
            this.lblLiverpool.Text = "Liverpool";
            // 
            // lblManchesterUnited
            // 
            this.lblManchesterUnited.AutoSize = true;
            this.lblManchesterUnited.Location = new System.Drawing.Point(34, 66);
            this.lblManchesterUnited.Name = "lblManchesterUnited";
            this.lblManchesterUnited.Size = new System.Drawing.Size(97, 13);
            this.lblManchesterUnited.TabIndex = 5;
            this.lblManchesterUnited.Text = "Manchester United";
            // 
            // lblMatchDate
            // 
            this.lblMatchDate.AutoSize = true;
            this.lblMatchDate.Location = new System.Drawing.Point(326, 66);
            this.lblMatchDate.Name = "lblMatchDate";
            this.lblMatchDate.Size = new System.Drawing.Size(65, 13);
            this.lblMatchDate.TabIndex = 7;
            this.lblMatchDate.Text = "26/12/2023";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(342, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // lblMatchTime
            // 
            this.lblMatchTime.AutoSize = true;
            this.lblMatchTime.Location = new System.Drawing.Point(640, 66);
            this.lblMatchTime.Name = "lblMatchTime";
            this.lblMatchTime.Size = new System.Drawing.Size(34, 13);
            this.lblMatchTime.TabIndex = 9;
            this.lblMatchTime.Text = "12:30";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(639, 26);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time";
            // 
            // grpMatch1
            // 
            this.grpMatch1.Controls.Add(this.lblMatchTime);
            this.grpMatch1.Controls.Add(this.lblTime);
            this.grpMatch1.Controls.Add(this.lblMatchDate);
            this.grpMatch1.Controls.Add(this.lblDate);
            this.grpMatch1.Controls.Add(this.lblManchesterUnited);
            this.grpMatch1.Controls.Add(this.lblLiverpool);
            this.grpMatch1.Location = new System.Drawing.Point(22, 37);
            this.grpMatch1.Name = "grpMatch1";
            this.grpMatch1.Size = new System.Drawing.Size(755, 113);
            this.grpMatch1.TabIndex = 10;
            this.grpMatch1.TabStop = false;
            this.grpMatch1.Text = "Match 1";
            // 
            // grpMatch2
            // 
            this.grpMatch2.Controls.Add(this.label1);
            this.grpMatch2.Controls.Add(this.lblTime2);
            this.grpMatch2.Controls.Add(this.label3);
            this.grpMatch2.Controls.Add(this.lblDate2);
            this.grpMatch2.Controls.Add(this.lblManchesterCity);
            this.grpMatch2.Controls.Add(this.lblNewcastleUnited);
            this.grpMatch2.Location = new System.Drawing.Point(23, 169);
            this.grpMatch2.Name = "grpMatch2";
            this.grpMatch2.Size = new System.Drawing.Size(755, 113);
            this.grpMatch2.TabIndex = 11;
            this.grpMatch2.TabStop = false;
            this.grpMatch2.Text = "Match 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "16:45";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Location = new System.Drawing.Point(639, 26);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(30, 13);
            this.lblTime2.TabIndex = 8;
            this.lblTime2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "31/12/2023";
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Location = new System.Drawing.Point(342, 26);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(30, 13);
            this.lblDate2.TabIndex = 6;
            this.lblDate2.Text = "Date";
            // 
            // lblManchesterCity
            // 
            this.lblManchesterCity.AutoSize = true;
            this.lblManchesterCity.Location = new System.Drawing.Point(34, 66);
            this.lblManchesterCity.Name = "lblManchesterCity";
            this.lblManchesterCity.Size = new System.Drawing.Size(83, 13);
            this.lblManchesterCity.TabIndex = 5;
            this.lblManchesterCity.Text = "Manchester City";
            // 
            // lblNewcastleUnited
            // 
            this.lblNewcastleUnited.AutoSize = true;
            this.lblNewcastleUnited.Location = new System.Drawing.Point(34, 26);
            this.lblNewcastleUnited.Name = "lblNewcastleUnited";
            this.lblNewcastleUnited.Size = new System.Drawing.Size(91, 13);
            this.lblNewcastleUnited.TabIndex = 4;
            this.lblNewcastleUnited.Text = "Newcastle United";
            // 
            // grpMatch3
            // 
            this.grpMatch3.Controls.Add(this.lblMatchTime3);
            this.grpMatch3.Controls.Add(this.lblTime3);
            this.grpMatch3.Controls.Add(this.lblMatchDate3);
            this.grpMatch3.Controls.Add(this.lblDate3);
            this.grpMatch3.Controls.Add(this.lblCrystalPalace);
            this.grpMatch3.Controls.Add(this.lblWolverhamptonWanderers);
            this.grpMatch3.Location = new System.Drawing.Point(22, 302);
            this.grpMatch3.Name = "grpMatch3";
            this.grpMatch3.Size = new System.Drawing.Size(755, 113);
            this.grpMatch3.TabIndex = 12;
            this.grpMatch3.TabStop = false;
            this.grpMatch3.Text = "Match 3";
            // 
            // lblMatchTime3
            // 
            this.lblMatchTime3.AutoSize = true;
            this.lblMatchTime3.Location = new System.Drawing.Point(640, 66);
            this.lblMatchTime3.Name = "lblMatchTime3";
            this.lblMatchTime3.Size = new System.Drawing.Size(34, 13);
            this.lblMatchTime3.TabIndex = 9;
            this.lblMatchTime3.Text = "20:00";
            // 
            // lblTime3
            // 
            this.lblTime3.AutoSize = true;
            this.lblTime3.Location = new System.Drawing.Point(639, 26);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(30, 13);
            this.lblTime3.TabIndex = 8;
            this.lblTime3.Text = "Time";
            // 
            // lblMatchDate3
            // 
            this.lblMatchDate3.AutoSize = true;
            this.lblMatchDate3.Location = new System.Drawing.Point(329, 66);
            this.lblMatchDate3.Name = "lblMatchDate3";
            this.lblMatchDate3.Size = new System.Drawing.Size(62, 13);
            this.lblMatchDate3.TabIndex = 7;
            this.lblMatchDate3.Text = "  1/1/2024 ";
            // 
            // lblDate3
            // 
            this.lblDate3.AutoSize = true;
            this.lblDate3.Location = new System.Drawing.Point(342, 26);
            this.lblDate3.Name = "lblDate3";
            this.lblDate3.Size = new System.Drawing.Size(30, 13);
            this.lblDate3.TabIndex = 6;
            this.lblDate3.Text = "Date";
            // 
            // lblCrystalPalace
            // 
            this.lblCrystalPalace.AutoSize = true;
            this.lblCrystalPalace.Location = new System.Drawing.Point(34, 66);
            this.lblCrystalPalace.Name = "lblCrystalPalace";
            this.lblCrystalPalace.Size = new System.Drawing.Size(74, 13);
            this.lblCrystalPalace.TabIndex = 5;
            this.lblCrystalPalace.Text = "Crystal Palace";
            // 
            // lblWolverhamptonWanderers
            // 
            this.lblWolverhamptonWanderers.AutoSize = true;
            this.lblWolverhamptonWanderers.Location = new System.Drawing.Point(34, 26);
            this.lblWolverhamptonWanderers.Name = "lblWolverhamptonWanderers";
            this.lblWolverhamptonWanderers.Size = new System.Drawing.Size(137, 13);
            this.lblWolverhamptonWanderers.TabIndex = 4;
            this.lblWolverhamptonWanderers.Text = "Wolverhampton Wanderers";
            // 
            // frmViewFixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpMatch3);
            this.Controls.Add(this.grpMatch2);
            this.Controls.Add(this.grpMatch1);
            this.Controls.Add(this.mnuBackToMenu);
            this.Name = "frmViewFixture";
            this.Text = "frmViewFixture";
            this.mnuBackToMenu.ResumeLayout(false);
            this.mnuBackToMenu.PerformLayout();
            this.grpMatch1.ResumeLayout(false);
            this.grpMatch1.PerformLayout();
            this.grpMatch2.ResumeLayout(false);
            this.grpMatch2.PerformLayout();
            this.grpMatch3.ResumeLayout(false);
            this.grpMatch3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBackToMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblLiverpool;
        private System.Windows.Forms.Label lblManchesterUnited;
        private System.Windows.Forms.Label lblMatchDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMatchTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox grpMatch1;
        private System.Windows.Forms.GroupBox grpMatch2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Label lblManchesterCity;
        private System.Windows.Forms.Label lblNewcastleUnited;
        private System.Windows.Forms.GroupBox grpMatch3;
        private System.Windows.Forms.Label lblMatchTime3;
        private System.Windows.Forms.Label lblTime3;
        private System.Windows.Forms.Label lblMatchDate3;
        private System.Windows.Forms.Label lblDate3;
        private System.Windows.Forms.Label lblCrystalPalace;
        private System.Windows.Forms.Label lblWolverhamptonWanderers;
    }
}