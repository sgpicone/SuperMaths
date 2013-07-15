namespace SuperMath
{
    partial class GUI
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnQuickGame = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.pnlDifficultySelect = new System.Windows.Forms.Panel();
            this.btnSelectDiff = new System.Windows.Forms.Button();
            this.lblDiffSelectTitle = new System.Windows.Forms.Label();
            this.rdIMP = new System.Windows.Forms.RadioButton();
            this.rdVHARD = new System.Windows.Forms.RadioButton();
            this.rdHARD = new System.Windows.Forms.RadioButton();
            this.rdMED = new System.Windows.Forms.RadioButton();
            this.rdEASY = new System.Windows.Forms.RadioButton();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.chkAdultMode = new System.Windows.Forms.CheckBox();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlDifficultySelect.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(939, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Super Maths";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnQuickGame);
            this.pnlMain.Controls.Add(this.btnSettings);
            this.pnlMain.Controls.Add(this.btnQuit);
            this.pnlMain.Location = new System.Drawing.Point(12, 47);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(915, 587);
            this.pnlMain.TabIndex = 0;
            // 
            // btnQuickGame
            // 
            this.btnQuickGame.Location = new System.Drawing.Point(418, 226);
            this.btnQuickGame.Name = "btnQuickGame";
            this.btnQuickGame.Size = new System.Drawing.Size(75, 23);
            this.btnQuickGame.TabIndex = 0;
            this.btnQuickGame.Text = "Quick Game";
            this.btnQuickGame.UseVisualStyleBackColor = true;
            this.btnQuickGame.Click += new System.EventHandler(this.btnQuickGame_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(418, 272);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(418, 315);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pnlGame
            // 
            this.pnlGame.AutoScroll = true;
            this.pnlGame.Location = new System.Drawing.Point(12, 47);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(915, 587);
            this.pnlGame.TabIndex = 0;
            // 
            // pnlDifficultySelect
            // 
            this.pnlDifficultySelect.Controls.Add(this.btnSelectDiff);
            this.pnlDifficultySelect.Controls.Add(this.lblDiffSelectTitle);
            this.pnlDifficultySelect.Controls.Add(this.rdIMP);
            this.pnlDifficultySelect.Controls.Add(this.rdVHARD);
            this.pnlDifficultySelect.Controls.Add(this.rdHARD);
            this.pnlDifficultySelect.Controls.Add(this.rdMED);
            this.pnlDifficultySelect.Controls.Add(this.rdEASY);
            this.pnlDifficultySelect.Location = new System.Drawing.Point(12, 47);
            this.pnlDifficultySelect.Name = "pnlDifficultySelect";
            this.pnlDifficultySelect.Size = new System.Drawing.Size(915, 587);
            this.pnlDifficultySelect.TabIndex = 0;
            // 
            // btnSelectDiff
            // 
            this.btnSelectDiff.Location = new System.Drawing.Point(418, 346);
            this.btnSelectDiff.Name = "btnSelectDiff";
            this.btnSelectDiff.Size = new System.Drawing.Size(85, 23);
            this.btnSelectDiff.TabIndex = 6;
            this.btnSelectDiff.Text = "Start Game";
            this.btnSelectDiff.UseVisualStyleBackColor = true;
            this.btnSelectDiff.Click += new System.EventHandler(this.btnSelectDiff_Click);
            // 
            // lblDiffSelectTitle
            // 
            this.lblDiffSelectTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDiffSelectTitle.Location = new System.Drawing.Point(415, 203);
            this.lblDiffSelectTitle.Name = "lblDiffSelectTitle";
            this.lblDiffSelectTitle.Size = new System.Drawing.Size(100, 23);
            this.lblDiffSelectTitle.TabIndex = 5;
            this.lblDiffSelectTitle.Text = "Select Difficulty";
            this.lblDiffSelectTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdIMP
            // 
            this.rdIMP.AutoSize = true;
            this.rdIMP.Location = new System.Drawing.Point(418, 323);
            this.rdIMP.Name = "rdIMP";
            this.rdIMP.Size = new System.Drawing.Size(85, 17);
            this.rdIMP.TabIndex = 4;
            this.rdIMP.TabStop = true;
            this.rdIMP.Text = "radioButton5";
            this.rdIMP.UseVisualStyleBackColor = true;
            // 
            // rdVHARD
            // 
            this.rdVHARD.AutoSize = true;
            this.rdVHARD.Location = new System.Drawing.Point(418, 298);
            this.rdVHARD.Name = "rdVHARD";
            this.rdVHARD.Size = new System.Drawing.Size(85, 17);
            this.rdVHARD.TabIndex = 3;
            this.rdVHARD.TabStop = true;
            this.rdVHARD.Text = "radioButton4";
            this.rdVHARD.UseVisualStyleBackColor = true;
            // 
            // rdHARD
            // 
            this.rdHARD.AutoSize = true;
            this.rdHARD.Location = new System.Drawing.Point(418, 275);
            this.rdHARD.Name = "rdHARD";
            this.rdHARD.Size = new System.Drawing.Size(85, 17);
            this.rdHARD.TabIndex = 2;
            this.rdHARD.TabStop = true;
            this.rdHARD.Text = "radioButton3";
            this.rdHARD.UseVisualStyleBackColor = true;
            // 
            // rdMED
            // 
            this.rdMED.AutoSize = true;
            this.rdMED.Location = new System.Drawing.Point(418, 252);
            this.rdMED.Name = "rdMED";
            this.rdMED.Size = new System.Drawing.Size(85, 17);
            this.rdMED.TabIndex = 1;
            this.rdMED.TabStop = true;
            this.rdMED.Text = "radioButton2";
            this.rdMED.UseVisualStyleBackColor = true;
            // 
            // rdEASY
            // 
            this.rdEASY.AutoSize = true;
            this.rdEASY.Checked = true;
            this.rdEASY.Location = new System.Drawing.Point(418, 229);
            this.rdEASY.Name = "rdEASY";
            this.rdEASY.Size = new System.Drawing.Size(85, 17);
            this.rdEASY.TabIndex = 0;
            this.rdEASY.TabStop = true;
            this.rdEASY.Text = "radioButton1";
            this.rdEASY.UseVisualStyleBackColor = true;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.btnBackToMenu);
            this.pnlSettings.Controls.Add(this.chkAdultMode);
            this.pnlSettings.Location = new System.Drawing.Point(12, 47);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(915, 587);
            this.pnlSettings.TabIndex = 0;
            // 
            // chkAdultMode
            // 
            this.chkAdultMode.AutoSize = true;
            this.chkAdultMode.Location = new System.Drawing.Point(4, 567);
            this.chkAdultMode.Name = "chkAdultMode";
            this.chkAdultMode.Size = new System.Drawing.Size(80, 17);
            this.chkAdultMode.TabIndex = 0;
            this.chkAdultMode.Text = "Adult Mode";
            this.chkAdultMode.UseVisualStyleBackColor = true;
            this.chkAdultMode.CheckedChanged += new System.EventHandler(this.chkAdultMode_CheckedChanged);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(806, 561);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(106, 23);
            this.btnBackToMenu.TabIndex = 1;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 646);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlDifficultySelect);
            this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlDifficultySelect.ResumeLayout(false);
            this.pnlDifficultySelect.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private bool AdultMode;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Panel pnlDifficultySelect;
        private System.Windows.Forms.Button btnQuickGame;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblDiffSelectTitle;
        private System.Windows.Forms.RadioButton rdIMP;
        private System.Windows.Forms.RadioButton rdVHARD;
        private System.Windows.Forms.RadioButton rdHARD;
        private System.Windows.Forms.RadioButton rdMED;
        private System.Windows.Forms.RadioButton rdEASY;
        private System.Windows.Forms.Button btnSelectDiff;
        private System.Windows.Forms.CheckBox chkAdultMode;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}

