using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euler6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            int number;
            int sumSqares = 0;
            int squareSums = 0;
            bool flag;

            flag = int.TryParse(txtInput.Text, out number);

            for (int i = number; i > 0; i--)
            {
                sumSqares += (i * i);
            }
            txtSumSquare.Text = sumSqares.ToString();

            for (int i = number; i > 0; i--)
            {
                squareSums += i;
            }

            squareSums *= squareSums;
            txtSquareSum.Text = squareSums.ToString();

            txtDifference.Text = (squareSums - sumSqares).ToString();
        }

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            int number = ToInt(txtInput.Text);
            int sumSquares = SumSquares(number);
            int squareSums = SquareSums(number);
            txtDifference.Text = (squareSums - sumSquares).ToString();
        }

        private int ToInt(string number)
        {
            bool flag;
            int result;
            flag = int.TryParse(number, out result);
            return result;
        }

        private int SumSquares(int number)
        {
            int sumSquares = 0;
            for (int i = number; i > 0; i--)
            {
                sumSquares += (i * i);
            }
            txtSumSquare.Text = sumSquares.ToString();
            return sumSquares;
        }

        private int SquareSums(int number)
        {
            int squareSums = 0;
            for (int i = number; i > 0; i--)
            {
                squareSums += i;
            }
            squareSums *= squareSums;
            txtSquareSum.Text = squareSums.ToString();
            return squareSums;
        }
    }
}
