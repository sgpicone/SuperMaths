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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnMain = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblAnswer);
            this.pnlMain.Controls.Add(this.btnMain);
            this.pnlMain.Controls.Add(this.lblMain);
            this.pnlMain.Location = new System.Drawing.Point(12, 264);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(760, 286);
            this.pnlMain.TabIndex = 0;
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(47, 145);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(161, 23);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "GO TO OTHER SCREEN";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(107, 105);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(81, 13);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "MAIN SCREEN";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(784, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Super Maths 9KK9";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(374, 104);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(55, 13);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "ANSWER";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMain);
            this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAnswer;

    }
}

