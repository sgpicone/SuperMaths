using SuperMathStage;
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnQuickGame = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.pnlDifficultySelect = new System.Windows.Forms.Panel();
            this.btnDiffPnlBack = new System.Windows.Forms.Button();
            this.btnDiffPnlSelectDiff = new System.Windows.Forms.Button();
            this.lblDiffPnlDiffSelectTitle = new System.Windows.Forms.Label();
            this.rdDiffPnlIMP = new System.Windows.Forms.RadioButton();
            this.rdDiffPnlVHARD = new System.Windows.Forms.RadioButton();
            this.rdDiffPnlHARD = new System.Windows.Forms.RadioButton();
            this.rdDiffPnlMED = new System.Windows.Forms.RadioButton();
            this.rdDiffPnlEASY = new System.Windows.Forms.RadioButton();
            this.pnlStartQuiz = new System.Windows.Forms.Panel();
            this.btnStrtPnlStartQuiz = new System.Windows.Forms.Button();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.chkAdultMode = new System.Windows.Forms.CheckBox();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlDifficultySelect.SuspendLayout();
            this.pnlStartQuiz.SuspendLayout();
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
            this.pnlDifficultySelect.Controls.Add(this.btnDiffPnlBack);
            this.pnlDifficultySelect.Controls.Add(this.btnDiffPnlSelectDiff);
            this.pnlDifficultySelect.Controls.Add(this.lblDiffPnlDiffSelectTitle);
            this.pnlDifficultySelect.Controls.Add(this.rdDiffPnlIMP);
            this.pnlDifficultySelect.Controls.Add(this.rdDiffPnlVHARD);
            this.pnlDifficultySelect.Controls.Add(this.rdDiffPnlHARD);
            this.pnlDifficultySelect.Controls.Add(this.rdDiffPnlMED);
            this.pnlDifficultySelect.Controls.Add(this.rdDiffPnlEASY);
            this.pnlDifficultySelect.Location = new System.Drawing.Point(12, 47);
            this.pnlDifficultySelect.Name = "pnlDifficultySelect";
            this.pnlDifficultySelect.Size = new System.Drawing.Size(915, 587);
            this.pnlDifficultySelect.TabIndex = 0;
            // 
            // btnDiffPnlBack
            // 
            this.btnDiffPnlBack.Location = new System.Drawing.Point(824, 564);
            this.btnDiffPnlBack.Name = "btnDiffPnlBack";
            this.btnDiffPnlBack.Size = new System.Drawing.Size(88, 23);
            this.btnDiffPnlBack.TabIndex = 7;
            this.btnDiffPnlBack.Text = "Back to Menu";
            this.btnDiffPnlBack.UseVisualStyleBackColor = true;
            this.btnDiffPnlBack.Click += new System.EventHandler(this.btnDiffPnlBack_Click);
            // 
            // btnDiffPnlSelectDiff
            // 
            this.btnDiffPnlSelectDiff.Location = new System.Drawing.Point(418, 346);
            this.btnDiffPnlSelectDiff.Name = "btnDiffPnlSelectDiff";
            this.btnDiffPnlSelectDiff.Size = new System.Drawing.Size(85, 23);
            this.btnDiffPnlSelectDiff.TabIndex = 6;
            this.btnDiffPnlSelectDiff.Text = "Start Game";
            this.btnDiffPnlSelectDiff.UseVisualStyleBackColor = true;
            this.btnDiffPnlSelectDiff.Click += new System.EventHandler(this.btnSelectDiff_Click);
            // 
            // lblDiffPnlDiffSelectTitle
            // 
            this.lblDiffPnlDiffSelectTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDiffPnlDiffSelectTitle.Location = new System.Drawing.Point(415, 203);
            this.lblDiffPnlDiffSelectTitle.Name = "lblDiffPnlDiffSelectTitle";
            this.lblDiffPnlDiffSelectTitle.Size = new System.Drawing.Size(100, 23);
            this.lblDiffPnlDiffSelectTitle.TabIndex = 5;
            this.lblDiffPnlDiffSelectTitle.Text = "Select Difficulty";
            this.lblDiffPnlDiffSelectTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdDiffPnlIMP
            // 
            this.rdDiffPnlIMP.AutoSize = true;
            this.rdDiffPnlIMP.Location = new System.Drawing.Point(418, 323);
            this.rdDiffPnlIMP.Name = "rdDiffPnlIMP";
            this.rdDiffPnlIMP.Size = new System.Drawing.Size(85, 17);
            this.rdDiffPnlIMP.TabIndex = 4;
            this.rdDiffPnlIMP.TabStop = true;
            this.rdDiffPnlIMP.Text = "radioButton5";
            this.rdDiffPnlIMP.UseVisualStyleBackColor = true;
            // 
            // rdDiffPnlVHARD
            // 
            this.rdDiffPnlVHARD.AutoSize = true;
            this.rdDiffPnlVHARD.Location = new System.Drawing.Point(418, 298);
            this.rdDiffPnlVHARD.Name = "rdDiffPnlVHARD";
            this.rdDiffPnlVHARD.Size = new System.Drawing.Size(85, 17);
            this.rdDiffPnlVHARD.TabIndex = 3;
            this.rdDiffPnlVHARD.TabStop = true;
            this.rdDiffPnlVHARD.Text = "radioButton4";
            this.rdDiffPnlVHARD.UseVisualStyleBackColor = true;
            // 
            // rdDiffPnlHARD
            // 
            this.rdDiffPnlHARD.AutoSize = true;
            this.rdDiffPnlHARD.Location = new System.Drawing.Point(418, 275);
            this.rdDiffPnlHARD.Name = "rdDiffPnlHARD";
            this.rdDiffPnlHARD.Size = new System.Drawing.Size(85, 17);
            this.rdDiffPnlHARD.TabIndex = 2;
            this.rdDiffPnlHARD.TabStop = true;
            this.rdDiffPnlHARD.Text = "radioButton3";
            this.rdDiffPnlHARD.UseVisualStyleBackColor = true;
            // 
            // rdDiffPnlMED
            // 
            this.rdDiffPnlMED.AutoSize = true;
            this.rdDiffPnlMED.Location = new System.Drawing.Point(418, 252);
            this.rdDiffPnlMED.Name = "rdDiffPnlMED";
            this.rdDiffPnlMED.Size = new System.Drawing.Size(85, 17);
            this.rdDiffPnlMED.TabIndex = 1;
            this.rdDiffPnlMED.TabStop = true;
            this.rdDiffPnlMED.Text = "radioButton2";
            this.rdDiffPnlMED.UseVisualStyleBackColor = true;
            // 
            // rdDiffPnlEASY
            // 
            this.rdDiffPnlEASY.AutoSize = true;
            this.rdDiffPnlEASY.Checked = true;
            this.rdDiffPnlEASY.Location = new System.Drawing.Point(418, 229);
            this.rdDiffPnlEASY.Name = "rdDiffPnlEASY";
            this.rdDiffPnlEASY.Size = new System.Drawing.Size(85, 17);
            this.rdDiffPnlEASY.TabIndex = 0;
            this.rdDiffPnlEASY.TabStop = true;
            this.rdDiffPnlEASY.Text = "radioButton1";
            this.rdDiffPnlEASY.UseVisualStyleBackColor = true;
            // 
            // pnlStartQuiz
            // 
            this.pnlStartQuiz.AutoScroll = true;
            this.pnlStartQuiz.Controls.Add(this.btnStrtPnlStartQuiz);
            this.pnlStartQuiz.Location = new System.Drawing.Point(12, 47);
            this.pnlStartQuiz.Name = "pnlStartQuiz";
            this.pnlStartQuiz.Size = new System.Drawing.Size(915, 587);
            this.pnlStartQuiz.TabIndex = 0;
            // 
            // btnStrtPnlStartQuiz
            // 
            this.btnStrtPnlStartQuiz.Location = new System.Drawing.Point(420, 282);
            this.btnStrtPnlStartQuiz.Name = "btnStrtPnlStartQuiz";
            this.btnStrtPnlStartQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnStrtPnlStartQuiz.TabIndex = 0;
            this.btnStrtPnlStartQuiz.Text = "Start Quiz";
            this.btnStrtPnlStartQuiz.UseVisualStyleBackColor = true;
            this.btnStrtPnlStartQuiz.Click += new System.EventHandler(this.btnStrtPnlStartQuiz_Click);
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
            // tmrGameTimer
            // 
            this.tmrGameTimer.Interval = 1000;
            this.tmrGameTimer.Tick += new System.EventHandler(this.tmrGameTimer_Tick);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 646);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlStartQuiz);
            this.Controls.Add(this.pnlDifficultySelect);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlMain);
            this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlDifficultySelect.ResumeLayout(false);
            this.pnlDifficultySelect.PerformLayout();
            this.pnlStartQuiz.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private bool AdultMode;
        private int StageTimer;
        private AStage Stage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Panel pnlDifficultySelect;
        private System.Windows.Forms.Panel pnlStartQuiz;
        private System.Windows.Forms.Button btnQuickGame;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblDiffPnlDiffSelectTitle;
        private System.Windows.Forms.RadioButton rdDiffPnlIMP;
        private System.Windows.Forms.RadioButton rdDiffPnlVHARD;
        private System.Windows.Forms.RadioButton rdDiffPnlHARD;
        private System.Windows.Forms.RadioButton rdDiffPnlMED;
        private System.Windows.Forms.RadioButton rdDiffPnlEASY;
        private System.Windows.Forms.Button btnDiffPnlSelectDiff;
        private System.Windows.Forms.CheckBox chkAdultMode;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button btnDiffPnlBack;
        private System.Windows.Forms.Button btnStrtPnlStartQuiz;
        private System.Windows.Forms.Timer tmrGameTimer;
        private System.Windows.Forms.Label lblTimer;
    }
}

