using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void doTheMath(string tomath)
        {
            string[] math = tomath.Split('+');

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            int i = 0;
            while (i >= 0)
            {
                int first = input.LastIndexOf('(');
                if (first != -1)
                {
                    int second = input.IndexOf(')', first);
                    lblResult.Text = input.Substring(first + 1, second - first - 1);
                }
                i = first;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
