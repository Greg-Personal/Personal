using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Euler1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int i = 0;
            int result = 0;

            while (i < 1000)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
                i++;
            }
            txtResult.Text = result.ToString();
        }

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            int result = 0;

            for (int first = 3; first < 1000; first += 3)
            {
                result += first;
            }

            for (int second = 5; second < 1000; second += 5)
            {
                if (second % 3 != 0)
                {
                    result += second;
                }
            }
            txtResult.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtInput.Clear();
            txtMax.Clear();
        }

        private void btnCalc3_Click(object sender, EventArgs e)
        {
            bool flag;
            string[] input = txtInput.Text.Split(',');
            int[] numbers = new int[input.Length];
            int max;
            int result = 0;
            List<int> valid = new List<int>();

            flag = int.TryParse(txtMax.Text, out max);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number only", "Input Error");
                txtMax.Focus();
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                flag = int.TryParse(input[i], out numbers[i]);
                if (flag == false)
                {
                    MessageBox.Show("Enter whole numbers separated by commas only", "Input Error");
                    txtInput.Focus();
                    return;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = numbers[i]; j < max; j += numbers[i])
                {
                    if (valid.IndexOf(j) == -1)
                    {
                        result += j;
                        valid.Add(j);
                    }
                }
            }

            txtResult.Text = result.ToString();
        }
    }
}
