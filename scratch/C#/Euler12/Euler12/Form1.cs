using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Euler12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            int input;
            bool flag;
            flag = int.TryParse(txtInput.Text, out input);
            double number = BruteForce(input);
            txtResult.Text = number.ToString();
        }

        private double BruteForce(int input)
        {
            double number = 0;
            List<double> factors = new List<double>();
            for (double i = 1; factors.Count <= input; i++)
            {
                factors.Clear();
                number += i;
                for (double j = number; j > 0; j--)
                {
                    if (number % j == 0)
                    {
                        factors.Add(j);
                    }
                }
            }
            return number;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtInput.Clear();
        }
    }
}
