using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euler_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            int max;
            bool flag;
            flag = int.TryParse(txtInput.Text, out max);
            int result = max;

            flag = false;
            while (true)
            {
                for (int i = max; i > 0; i--)
                {
                    if (result % i == 0)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == false)
                {
                    result += max;
                }
                else
                {
                    break;
                }
            }
            txtOutput.Text = result.ToString();
        }
    }
}
