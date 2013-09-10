using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc1_Click(object sender, EventArgs e)
        {
            const int max = 999;
            int first = max;
            int second = max;
            int product = 0;
            string temp;
            string reverse;
            int half;

            while (true)
            {
                second = max;
                while (second > 1)
                {
                    product = first * second;
                    temp = product.ToString();
                    reverse = "";
                    for (int i = temp.Length - 1; i >= 0; i--)
                    {
                        reverse = reverse + temp[i];
                    }
                    half = temp.Length / 2;
                    if (temp.Substring(0, half) == reverse.Substring(0, half))
                    {
                        break;
                    }
                    second--; 
                }
                if (second > 1)
                {
                    break;
                }
                else
                {
                    first--;
                }
            }

            lblResult.Text = first.ToString() + " times " + second.ToString() + " equals " + product.ToString();
        }

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            const int max = 999;
            int first = max;
            int second = max;
            int product = 0;
            string temp;
            string reverse;
            int half;

            while (true)
            {
                product = first * second;
                temp = product.ToString();
                reverse = "";
                for (int i = temp.Length - 1; i >= 0; i--)
                {
                    reverse = reverse + temp[i];
                }
                half = temp.Length / 2;
                if (temp.Substring(0, half) == reverse.Substring(0, half))
                {
                    break;
                }
                else
                {
                    if (first == second)
                    {
                        --second;
                    }
                    else
                    {
                        --first;
                    }
                }
            }

            lblResult.Text = first.ToString() + " times " + second.ToString() + " equals " + product.ToString();
        }

        private void btnCalc3_Click(object sender, EventArgs e)
        {
            const int max = 999;
            int first = max;
            int firstresult = max;
            int second = max;
            int secondresult = max;
            int product = 0;
            string temp;
            string reverse;
            int half;
            int result = 0;

            while (second > 1)
            {
                product = first * second;
                temp = product.ToString();
                reverse = "";
                for (int i = temp.Length - 1; i >= 0; i--)
                {
                    reverse = reverse + temp[i];
                }
                half = temp.Length / 2;
                
                if (temp.Substring(0, half) == reverse.Substring(0, half))
                {
                    if (product > result)
                    {
                        firstresult = first;
                        secondresult = second;
                        result = product;
                    }
                }

                if (first == second)
                {
                    --second;
                }
                else
                {
                    --first;
                }

            }

            lblResult.Text = firstresult.ToString() + " times " + secondresult.ToString() + " equals " + result.ToString();
        }

        private void btnCalc4_Click(object sender, EventArgs e)
        {
            const int max =999;
            int first = max;
            int second = max;
            int result = 0;
            int firstresult = max;
            int secondresult = max;
            int product = 0;
            string temp;
            string reverse;
            int half;

            while (first > 1)
            {
                second = max;
                while (second > 1)
                {
                    product = first * second;
                    temp = product.ToString();
                    reverse = "";
                    for (int i = temp.Length - 1; i >= 0; i--)
                    {
                        reverse = reverse + temp[i];
                    }
                    half = temp.Length / 2;
                    if (temp.Substring(0, half) == reverse.Substring(0, half))
                    {
                        if (product > result)
                        {
                            result = product;
                            firstresult = first;
                            secondresult = second;
                        }
                    }
                    second--;
                }
                first--;
            }

            lblResult.Text = firstresult.ToString() + " times " + secondresult.ToString() + " equals " + result.ToString();

        }

        private void btnCalc5_Click(object sender, EventArgs e)
        {
            const int max = 999;
            int first = max;
            int second = max;
            int result = 0;
            int firstresult = max;
            int secondresult = max;
            int product = 0;
            string temp;
            string reverse;
            int half;

            while (first > 1)
            {
                second = max;
                while (second > 1)
                {
                    if (secondresult > first)
                    {
                        break;
                    }
                    product = first * second;
                    temp = product.ToString();
                    reverse = "";
                    for (int i = temp.Length - 1; i >= 0; i--)
                    {
                        reverse = reverse + temp[i];
                    }
                    half = temp.Length / 2;
                    if (temp.Substring(0, half) == reverse.Substring(0, half))
                    {
                        if (product > result)
                        {
                            result = product;
                            firstresult = first;
                            secondresult = second;
                        }
                    }
                    second--;
                }
                if (secondresult > first)
                {
                    break;
                }
                first--;
            }

            lblResult.Text = firstresult.ToString() + " times " + secondresult.ToString() + " equals " + result.ToString();
        }
    }
}
