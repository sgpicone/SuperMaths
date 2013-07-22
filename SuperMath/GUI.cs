using SuperMathDifficulty;
using SuperMathProblem;
using SuperMathStage;
using System;
using System.Data;
using System.Windows.Forms;

namespace SuperMath
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            showMainScreen();
            //List<long> values = new List<long>() { 48, 9, 2 };
            //List<Operator> ops = new List<Operator>() { Operator.DIV, Operator.MULT };
            //lblMain.Text = Calculate.CalcLong(values, ops).ToString();
            //AProblem p = new Problem(Difficulty.HARD);
            //lblMain.Text = p.ToString();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void btnQuickGame_Click(object sender, EventArgs e)
        {
            PrepareDifficultyScreen();
            showDiffScreen();
        }

        private void btnCheckAnswers_Click(object sender, EventArgs e)
        {
            tmrGameTimer.Stop();
            CheckAnswers();
        }

        private void btnSelectDiff_Click(object sender, EventArgs e)
        {
            DisplayStage(new Stage(ChooseDifficulty()));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSettingsScreen();
        }

        private void chkAdultMode_CheckedChanged(object sender, EventArgs e)
        {
            this.AdultMode = !(this.AdultMode);
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            showMainScreen();
        }

        private void btnDiffPnlBack_Click(object sender, EventArgs e)
        {
            showMainScreen();
        }

        private void btnStrtPnlStartQuiz_Click(object sender, System.EventArgs e)
        {
            showGameScreen();
            tmrGameTimer.Start();
        }

        private void tmrGameTimer_Tick(object sender, System.EventArgs e)
        {
            if (this.StageTimer > 0)
            {
                this.StageTimer -= 1;
                lblTimer.Text = StageTimer.ToString();
            }
            else
            {
                tmrGameTimer.Stop();
                CheckAnswers();
            }
        }
    }
}
