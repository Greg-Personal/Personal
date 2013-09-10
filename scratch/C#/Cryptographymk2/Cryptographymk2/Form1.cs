using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptographymk2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            string[] input = txtCode.Text.Split(' ');
            int[] numbers = new int[input.Length];
            int i;

            txtOutput.Text = "";
            for (i = 0; i < input.Length; i++)
            {
                numbers[i] = input[i].Length;
            }

            for (i = 0; i < input.Length; i++)
            {
                if (numbers[i] > 0 && numbers[i] < 27)
                {
                    txtOutput.Text = txtOutput.Text + (char)(numbers[i] + 64);
                }
            }
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            string input = txtCode.Text.ToUpper();
            int[] numbers = new int[input.Length];
            int max = 26;
            int i;
            int j;
            string buff = "";
            Random rnd = new Random();

            for (i = 0; i < input.Length; i++)
            {
                char myChar = input[i];
                numbers[i] = myChar - 64;
            }

            for (i = 0; i < input.Length; i++)
            {
                for (j = 0; j < numbers[i]; j++)
                {
                    buff = buff + (char)(rnd.Next(max) + 65);
                }
                buff = buff + " ";
            }
            txtOutput.Text = "";
            txtOutput.Text = buff.ToLower();
        }
    }
}
