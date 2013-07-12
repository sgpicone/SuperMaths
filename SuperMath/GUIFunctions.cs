using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMathStage;
using SuperMathDifficulty;
using SuperMathProblem;

namespace SuperMath
{
    public partial class GUI : Form
    {
        AStage Stage;
        private void Quit()
        {
            Application.Exit();
        }

        //quick test method, not final implementation
        private void NewQuickGame(Difficulty diff)
        {
            Stage = new Stage(diff);
            Label lblBase;
            TextBox answer;
            this.pnlGame.SuspendLayout();
            //create controls for each problem
            int vstartX = 140, startY = 60, ostartX = 160;
            int incX = 0, incY = 0;
            int maxProbCount = 2;
            foreach (Problem p in Stage.Problems)
            {
                if (p.Values.Count() > maxProbCount)
                    maxProbCount = p.Values.Count();
            }
            int ansStart = vstartX + maxProbCount * 40;
            for(int p = 0; p < Stage.Problems.Count(); p++)
            {
                incX = 0; 
                for(int v = 0; v < Stage.Problems[p].Values.Count(); v++)
                {
                    lblBase = new Label();
                    lblBase.Size = new System.Drawing.Size(25, 25);
                    lblBase.Text = Stage.Problems[p].Values[v].ToString();
                    lblBase.Name = "lbl_Val" + v + "_Prob" + p;
                    lblBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lblBase.Location = new System.Drawing.Point(vstartX + incX, startY + incY);
                    this.pnlGame.Controls.Add(lblBase);
                    incX += 40;
                }
                incX = 0;
                for(int o = 0; o < Stage.Problems[p].Operators.Count(); o++)
                {
                    lblBase = new Label();
                    lblBase.Size = new System.Drawing.Size(25, 25);
                    lblBase.Text = Stage.Problems[p].Operators[o].OperatorToString();
                    lblBase.Name = "lbl_Op" + o + "_Prob" + p;
                    lblBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lblBase.Location = new System.Drawing.Point(ostartX + incX, startY + incY);
                    this.pnlGame.Controls.Add(lblBase);
                    incX += 40;
                }

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
            btnCheckAnswers.Location = new System.Drawing.Point(ansStart-30, startY + incY);
            btnCheckAnswers.Size = new System.Drawing.Size(140, 23);
            btnCheckAnswers.Click += btnCheckAnswers_Click;
            this.pnlGame.Controls.Add(btnCheckAnswers);

            this.pnlGame.ResumeLayout();
            switchScreen("GAME");
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
            switchScreen("MAIN");
        }


        private void switchScreen(string screen)
        {
            this.pnlGame.Visible = false;
            this.pnlSettings.Visible = false;
            this.pnlMain.Visible = false;
            this.pnlDifficultySelect.Visible = false;
            switch (screen)
            {
                case "MAIN": this.pnlMain.Visible = true; break;
                case "GAME": this.pnlGame.Visible = true; break;
                case "SETT": this.pnlSettings.Visible = true; break;
                case "DIFF": this.pnlDifficultySelect.Visible = true; break;
            }
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
                case "rdEASY": return Difficulty.EASY;
                case "rdNMED": return Difficulty.NORMAL;
                case "rdHARD": return Difficulty.HARD;
                case "rdVHARD": return Difficulty.VERY_HARD;
                case "rdIMP": return Difficulty.IMPOSSIBLE;
            }
            return Difficulty.EASY;
        }

        private void PrepareDifficultyScreen(bool adult)
        {
            this.rdEASY.Text = Difficulty.EASY.DifficultyToString(adult);
            this.rdMED.Text = Difficulty.NORMAL.DifficultyToString(adult);
            this.rdHARD.Text = Difficulty.HARD.DifficultyToString(adult);
            this.rdVHARD.Text = Difficulty.VERY_HARD.DifficultyToString(adult);
            this.rdIMP.Text = Difficulty.IMPOSSIBLE.DifficultyToString(adult);
        }
    }
}
