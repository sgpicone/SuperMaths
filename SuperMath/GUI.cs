using SuperMathDifficulty;
using SuperMathProblem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            lblMain.Text = new DataTable().Compute("325/784/120", null).ToString();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            AProblem p = new Problem(Difficulty.HARD);
            lblMain.Text = p.ToString();
            lblAnswer.Text = p.Answer.ToString();
        }
    }
}
