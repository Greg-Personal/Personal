using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int result = 0;
            int j = 1;
            int k = 1;

            for (int i = 1; i < 4000000; k = i)
            {
                if (i % 2 == 0)
                {
                    result += i;
                }
                i += j;
                j = k;
            }
            txtResult.Text = result.ToString();
        }
    }
}
