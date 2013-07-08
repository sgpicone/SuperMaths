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
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(784, 23);
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
            this.pnlMain.Size = new System.Drawing.Size(760, 503);
            this.pnlMain.TabIndex = 0;
            // 
            // btnQuickGame
            // 
            this.btnQuickGame.Location = new System.Drawing.Point(340, 160);
            this.btnQuickGame.Name = "btnQuickGame";
            this.btnQuickGame.Size = new System.Drawing.Size(75, 23);
            this.btnQuickGame.TabIndex = 0;
            this.btnQuickGame.Text = "Quick Game";
            this.btnQuickGame.UseVisualStyleBackColor = true;
            this.btnQuickGame.Click += new System.EventHandler(this.btnQuickGame_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(340, 206);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(340, 249);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pnlGame
            // 
            this.pnlGame.Location = new System.Drawing.Point(12, 47);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(760, 503);
            this.pnlGame.TabIndex = 0;
            // 
            // pnlDifficultySelect
            // 
            this.pnlDifficultySelect.Location = new System.Drawing.Point(12, 47);
            this.pnlDifficultySelect.Name = "pnlDifficultySelect";
            this.pnlDifficultySelect.Size = new System.Drawing.Size(760, 503);
            this.pnlDifficultySelect.TabIndex = 0;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Location = new System.Drawing.Point(12, 47);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(760, 503);
            this.pnlSettings.TabIndex = 0;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlDifficultySelect);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.lblTitle);
            this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Panel pnlDifficultySelect;
        private System.Windows.Forms.Button btnQuickGame;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnQuit;

    }
}

