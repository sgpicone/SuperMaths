﻿using SuperMathDifficulty;
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
            switchScreen("MAIN");
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
            switchScreen("DIFF");
        }

        private void btnCheckAnswers_Click(object sender, EventArgs e)
        {
            CheckAnswers();
        }

        private void btnSelectDiff_Click(object sender, EventArgs e)
        {
            NewQuickGame(ChooseDifficulty());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            switchScreen("SETT");
        }

        private void chkAdultMode_CheckedChanged(object sender, EventArgs e)
        {
            this.AdultMode = !(this.AdultMode);
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            switchScreen("MAIN");
        }
    }
}
