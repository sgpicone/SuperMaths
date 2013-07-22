using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMathStage;
using SuperMathDifficulty;
using SuperMathProblem;
using System.Drawing;
using System.Threading;
using System.Media;

namespace SuperMath
{
    public partial class GUI : Form
    {
        private void Quit()
        {
            Application.Exit();
        }

        //quick test method, not final implementation
        private void DisplayStage(AStage Stage)
        {
            Label lblBase;
            TextBox answer;
            this.Stage = Stage;
            //GroupBox grpbxProblemsGroup = new GroupBox();
            this.pnlGame.SuspendLayout();
            //grpbxProblemsGroup.Text = null;
            //grpbxProblemsGroup.Name = "grpbxProblemsGroup";
            //grpbxProblemsGroup.Size = this.pnlGame.Size;
            //grpbxProblemsGroup.Location = new System.Drawing.Point(0, 0);
            //create controls for each problem
            int vstartX = 260, startY = 60, ostartX = 280;
            int incX = 0, incY = 0;
            int maxProbCount = 2;
            this.StageTimer = this.Stage.TimeLimit;
            foreach (Problem p in Stage.Problems)
            {
                if (p.Values.Count() > maxProbCount)
                    maxProbCount = p.Values.Count();
            }
            int ansStart = vstartX + maxProbCount * 40;
            //int rgb = new Random().Next(Int32.MinValue, Int32.MaxValue);
            for (int p = 0; p < this.Stage.Problems.Count(); p++)
            {
                incX = 0;
                for (int v = 0; v < this.Stage.Problems[p].Values.Count(); v++)
                {
                    lblBase = new Label();
                    //lblBase.ForeColor = Color.FromArgb(rgb);
                    //lblBase.BackColor = Color.FromArgb(-rgb);
                    lblBase.Size = new System.Drawing.Size(25, 25);
                    lblBase.Text = this.Stage.Problems[p].Values[v].ToString();
                    lblBase.Name = "lbl_Val" + v + "_Prob" + p;
                    lblBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lblBase.Location = new System.Drawing.Point(vstartX + incX, startY + incY);
                    this.pnlGame.Controls.Add(lblBase);
                    incX += 40;
                }
                incX = 0;
                for (int o = 0; o < this.Stage.Problems[p].Operators.Count(); o++)
                {
                    lblBase = new Label();
                    //lblBase.ForeColor = Color.FromArgb(rgb);
                    //lblBase.BackColor = Color.FromArgb(-rgb);
                    lblBase.Size = new System.Drawing.Size(25, 25);
                    lblBase.Text = this.Stage.Problems[p].Operators[o].OperatorToString();
                    lblBase.Name = "lbl_Op" + o + "_Prob" + p;
                    lblBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lblBase.Location = new System.Drawing.Point(ostartX + incX, startY + incY);
                    this.pnlGame.Controls.Add(lblBase);
                    incX += 40;
                }
                //rgb = new Random().Next(Int32.MinValue,Int32.MaxValue);
                //Thread.Sleep(10);
                answer = new TextBox();
                answer.TabIndex = p;
                answer.Text = "0";
                answer.Size = new System.Drawing.Size(80, 23);
                answer.Name = "Ans" + p + "Prob" + p;
                answer.Location = new System.Drawing.Point(ansStart, startY + incY);
                this.pnlGame.Controls.Add(answer);

                incY += 30;
            }
            Button btnCheckAnswers = new Button();
            btnCheckAnswers.Name = "btnCheckAnswers";
            btnCheckAnswers.Text = "Check Answers";
            btnCheckAnswers.Location = new System.Drawing.Point(ansStart - 30, startY + incY);
            btnCheckAnswers.Size = new System.Drawing.Size(140, 23);
            btnCheckAnswers.Click += new System.EventHandler(this.btnCheckAnswers_Click);
            this.pnlGame.Controls.Add(btnCheckAnswers);

            lblTimer = new Label();
            lblTimer.Name = "lblTimer";
            lblTimer.Text = StageTimer.ToString();
            lblTimer.Location = new System.Drawing.Point(ansStart - 100, startY + incY);
            lblTimer.Size = new System.Drawing.Size(140, 23);
            this.pnlGame.Controls.Add(lblTimer);

            //this.pnlGame.Controls.Add(grpbxProblemsGroup);
            this.pnlGame.ResumeLayout();
            showStartQuizScreen();
            //this.pnlGame.Visible = true;
            //this.pnlSettings.Visible = false;
            //this.pnlMain.Visible = false;
            //this.pnlDifficultySelect.Visible = false;
        }

        private void CheckAnswers()
        {
            foreach (Control c in pnlGame.Controls)
            {
                if (c is TextBox)
                {
                    this.Stage.Answers.Add(Convert.ToDouble(c.Text));
                }
            }
            string msg = this.Stage.CheckAnswers() ? "SUCCESS.\n" : "FAILURE.\n";
            msg += this.Stage.getPoints() + " points awarded.";
            MessageBox.Show(msg);
            foreach (Control c in this.pnlGame.Controls)
                c.Dispose();
            this.pnlGame.Controls.Clear();
            showMainScreen();
        }


        private void switchScreen(string screen)
        {
            this.pnlGame.Visible = false;
            this.pnlSettings.Visible = false;
            this.pnlMain.Visible = false;
            this.pnlDifficultySelect.Visible = false;
            this.pnlStartQuiz.Visible = false;
            switch (screen)
            {
                case "MAIN": this.pnlMain.Visible = true; break;
                case "GAME": this.pnlGame.Visible = true; break;
                case "SETT": this.pnlSettings.Visible = true; break;
                case "DIFF": this.pnlDifficultySelect.Visible = true; break;
                case "STRT": this.pnlStartQuiz.Visible = true; break;
            }
        }

        private void showMainScreen()
        {
            switchScreen("MAIN");
        }

        private void showGameScreen()
        {
            switchScreen("GAME");
        }

        private void showSettingsScreen()
        {
            switchScreen("SETT");
        }

        private void showDiffScreen()
        {
            switchScreen("DIFF");
        }

        private void showStartQuizScreen()
        {
            switchScreen("STRT");
        }

        private Difficulty ChooseDifficulty()
        {
            string diff = null;
            foreach (Control c in this.pnlDifficultySelect.Controls)
            {
                if (c is RadioButton)
                {
                    if ((c as RadioButton).Checked)
                    {
                        diff = c.Name;
                    }
                }
            }
            switch(diff)
            {
                case "rdDiffPnlEASY": return Difficulty.EASY;
                case "rdDiffPnlMED": return Difficulty.NORMAL;
                case "rdDiffPnlHARD": return Difficulty.HARD;
                case "rdDiffPnlVHARD": return Difficulty.VERY_HARD;
                case "rdDiffPnlIMP": return Difficulty.IMPOSSIBLE;
            }
            return Difficulty.EASY;
        }

        private void PrepareDifficultyScreen()
        {
            this.rdDiffPnlEASY.Text = Difficulty.EASY.DifficultyToString(this.AdultMode);
            this.rdDiffPnlMED.Text = Difficulty.NORMAL.DifficultyToString(this.AdultMode);
            this.rdDiffPnlHARD.Text = Difficulty.HARD.DifficultyToString(this.AdultMode);
            this.rdDiffPnlVHARD.Text = Difficulty.VERY_HARD.DifficultyToString(this.AdultMode);
            this.rdDiffPnlIMP.Text = Difficulty.IMPOSSIBLE.DifficultyToString(this.AdultMode);
        }
    }
}
