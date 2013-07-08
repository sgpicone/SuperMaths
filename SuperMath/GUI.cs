using SuperMathDifficulty;
using SuperMathProblem;
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
            NewQuickGame();
        }

    }
}
