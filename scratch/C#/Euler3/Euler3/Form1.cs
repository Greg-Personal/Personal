using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Euler3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            long input = 600851475143;
            long temp = input;
            long result = 1;
            List<long> primes = new List<long>();

            primes.Add(1);
            primes.Add(2);
            for (long i = 3; i <= input; i += 2)
            {
                for (long j = i - 1; j >= 2; j--)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    else
                    {
                        if (j == 2)
                        {
                            primes.Add(i);
                        }
                    }
                }
            }

            foreach (var prime in primes)
            {
                if (temp % prime == 0)
                {
                    temp /= prime;
                    result = prime;
                }
                if (prime > temp)
                {
                    break;
                }
            }
            
            lblResult.Text = result.ToString();
        }

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            long input = 600851475143;
            long result = 1;
            bool flag = true;

            while (flag == true)
            {
                if (input % 2 == 0)
                {
                    input /= 2;
                    result = 2;
                }
                else
                {
                    flag = false;
                }
            }

            for (long i = 3; i <= input; i += 2)
            {
                for (long j = i - 1; j >= 2; j--)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    else
                    {
                        if (j == 2)
                        {
                            flag = true;
                            while (flag == true)
                            {
                                if (input % i == 0)
                                {
                                    input /= i;
                                    result = i;
                                }
                                else
                                {
                                    flag = false;
                                }
                            }
                        }
                    }
                }
            }

            lblResult.Text = result.ToString();
        }

        private void btnCalc3_Click(object sender, EventArgs e)
        {
            long input;
            bool flag = true;
            flag = long.TryParse(txtInput.Text, out input);
            if (flag == false)
            {
                MessageBox.Show("Type in a whole number", "Input Error");
                txtInput.Focus();
                return;
            }
            long result = input;


            while (flag == true)
            {
                if (input % 2 == 0)
                {
                    input /= 2;
                    result = 2;
                }
                else
                {
                    flag = false;
                }
            }

            for (long i = 3; i <= input; i += 2)
            {
                for (long j = i - 1; j >= 2; j--)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    else
                    {
                        if (j == 2)
                        {
                            flag = true;
                            while (flag == true)
                            {
                                if (input % i == 0)
                                {
                                    input /= i;
                                    result = i;
                                }
                                else
                                {
                                    flag = false;
                                }
                            }
                        }
                    }
                }
            }

            lblResult.Text = result.ToString();
        }
    }
}
