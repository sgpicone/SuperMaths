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

        private void Quit()
        {
            Application.Exit();
        }

        private void NewQuickGame()
        {
            AStage Stage = new Stage(Difficulty.HARD);
            Label lblBase;
            TextBox answer;
            this.pnlGame.SuspendLayout();
            //create controls for each problem
            int vstartX = 140, vstartY = 60, ostartX = 160, ostartY = 60;
            int vincX = 0, incY = 0, oincX = 0; 
            for(int p = 0; p < Stage.Problems.Count(); p++)
            {
                vincX = 0; 
                for(int v = 0; v < Stage.Problems[p].Values.Count(); v++)
                {
                    lblBase = new Label();
                    lblBase.Size = new System.Drawing.Size(20, 23);
                    lblBase.Text = Stage.Problems[p].Values[v].ToString();
                    lblBase.Name = "lbl_Val" + v + "_Prob" + p;
                    lblBase.Location = new System.Drawing.Point(vstartX + vincX, vstartY + incY);
                    this.pnlGame.Controls.Add(lblBase);
                    vincX += 40;
                }
                oincX = 0;
                for(int o = 0; o < Stage.Problems[p].Operators.Count(); o++)
                {
                    lblBase = new Label();
                    lblBase.Size = new System.Drawing.Size(20, 23);
                    lblBase.Text = Stage.Problems[p].Operators[o].OperatorToString();
                    lblBase.Name = "lbl_Op" + o + "_Prob" + p;
                    lblBase.Location = new System.Drawing.Point(ostartX + oincX, ostartY + incY);
                    this.pnlGame.Controls.Add(lblBase);
                    oincX += 40;
                }

                answer = new TextBox();
                answer.TabIndex = p;
                answer.Size = new System.Drawing.Size(40, 23);
                answer.Name = "Ans" + p + "Prob" + p;
                answer.Location = new System.Drawing.Point(vstartX + vincX, vstartY + incY);
                this.pnlGame.Controls.Add(answer);

                incY += 30;
            }
            Button btnCheckAnswers = new Button();

            this.pnlGame.ResumeLayout();
            this.pnlGame.Visible = true;
            this.pnlSettings.Visible = false;
            this.pnlMain.Visible = false;
            this.pnlDifficultySelect.Visible = false;
        }
    }
}
