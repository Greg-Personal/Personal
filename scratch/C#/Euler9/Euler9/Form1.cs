using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Euler9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblA.Text = "";
            lblB.Text = "";
            lblC.Text = "";
            txtInput.Clear();
        }

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            int max;
            int a = 1;
            int b = a+1;
            int c;
            bool flag;

            flag = int.TryParse(txtInput.Text, out max);

            flag = false;
            for (a = 1; a < b; a++)
            {
                c = max - (a + b);
                for (b = a+1; b < c; b++)
                {
                    c = max - (a + b);
                    if ((a*a) + (b*b) == (c*c))
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    lblA.Text = a.ToString();
                    lblB.Text = b.ToString();
                    lblC.Text = c.ToString();
                    break;
                }
            }
        }
    }
}
