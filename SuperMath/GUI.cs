﻿using System;
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
            List<long> values = new List<long>() { 48, 9, 2 };
            List<Operator> ops = new List<Operator>() { Operator.DIV, Operator.MULT };
            lblMain.Text = Calculate.CalcLong(values, ops).ToString();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            List<long> values = new List<long>() { 48, 9, 2 };
            List<Operator> ops = new List<Operator>() { Operator.DIV, Operator.MULT };
            lblMain.Text = Calculate.CalcDouble(values, ops).ToString();
        }
    }
}