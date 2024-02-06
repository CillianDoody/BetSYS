namespace BetSYS
{
    partial class frmViewTeamAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewTeamAnalysis));
            this.mnuBackToMenu = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.picTeamAnalysis = new System.Windows.Forms.PictureBox();
            this.btn2023 = new System.Windows.Forms.Button();
            this.btn2022 = new System.Windows.Forms.Button();
            this.btn2021 = new System.Windows.Forms.Button();
            this.mnuBackToMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamAnalysis)).BeginInit();
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
            // picTeamAnalysis
            // 
            this.picTeamAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("picTeamAnalysis.Image")));
            this.picTeamAnalysis.Location = new System.Drawing.Point(0, 27);
            this.picTeamAnalysis.Name = "picTeamAnalysis";
            this.picTeamAnalysis.Size = new System.Drawing.Size(800, 422);
            this.picTeamAnalysis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTeamAnalysis.TabIndex = 4;
            this.picTeamAnalysis.TabStop = false;
            this.picTeamAnalysis.Visible = false;
            // 
            // btn2023
            // 
            this.btn2023.Location = new System.Drawing.Point(60, 53);
            this.btn2023.Name = "btn2023";
            this.btn2023.Size = new System.Drawing.Size(141, 56);
            this.btn2023.TabIndex = 5;
            this.btn2023.Text = "2023";
            this.btn2023.UseVisualStyleBackColor = true;
            this.btn2023.Click += new System.EventHandler(this.btn2023_Click);
            // 
            // btn2022
            // 
            this.btn2022.Location = new System.Drawing.Point(324, 53);
            this.btn2022.Name = "btn2022";
            this.btn2022.Size = new System.Drawing.Size(141, 56);
            this.btn2022.TabIndex = 6;
            this.btn2022.Text = "2022";
            this.btn2022.UseVisualStyleBackColor = true;
            this.btn2022.Click += new System.EventHandler(this.btn2022_Click);
            // 
            // btn2021
            // 
            this.btn2021.Location = new System.Drawing.Point(596, 53);
            this.btn2021.Name = "btn2021";
            this.btn2021.Size = new System.Drawing.Size(141, 56);
            this.btn2021.TabIndex = 7;
            this.btn2021.Text = "2021";
            this.btn2021.UseVisualStyleBackColor = true;
            this.btn2021.Click += new System.EventHandler(this.btn2021_Click);
            // 
            // frmViewTeamAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2021);
            this.Controls.Add(this.btn2022);
            this.Controls.Add(this.btn2023);
            this.Controls.Add(this.picTeamAnalysis);
            this.Controls.Add(this.mnuBackToMenu);
            this.Name = "frmViewTeamAnalysis";
            this.Text = "frmViewTeamAnalysis";
            this.mnuBackToMenu.ResumeLayout(false);
            this.mnuBackToMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBackToMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.PictureBox picTeamAnalysis;
        private System.Windows.Forms.Button btn2023;
        private System.Windows.Forms.Button btn2022;
        private System.Windows.Forms.Button btn2021;
    }
}