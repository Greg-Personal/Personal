using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Euler10
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
            bool flag;
            long result = 0;
            flag = int.TryParse(txtInput.Text, out number);
            List<long> primes = GetPrimes(number);

            foreach (long prime in primes)
            {
                result += prime;
            }

            lblResult.Text = result.ToString();
        }

        private List<long> SievePrimes(int number)
        {
            List<long> primes = new List<long>();

            primes.Add(2);
            primes.Add(3);
            primes.Add(5);
            primes.Add(7);
            for (long i = 11; i < number; i+=2)
            {
                if (i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    for (long j = (long)Math.Sqrt(i); j >= 1; j--)
                    {
                        if (i % j == 0 && j != 1)
                        {
                            break;
                        }
                        else
                        {
                            if (j == 1)
                            {
                                primes.Add(i);
                            }
                        }
                    }
                }
            }
            return primes;
        }

        private List<long> SievePrimes2(int number)
        {
            List<long> primes = new List<long>();
            bool flag = false;

            primes.Add(2);
            primes.Add(3);
            primes.Add(5);
            primes.Add(7);
            for (long i = 11; i < number; i += 2)
            {
                if (i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                {
                    for (long root = (long)Math.Sqrt(i); root > 0; root--)
                    {
                        if (primes.Contains(root))
                        {
                            flag = false;
                            for (int j = primes.IndexOf(root); j > -1; j--)
                            {
                                if (i % primes[j] == 0)
                                {
                                    break;
                                }
                                else
                                {
                                    if (j == 0)
                                    {
                                        primes.Add(i);
                                        flag = true;
                                    }
                                }
                            }
                            if (flag == true)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            return primes;
        }
        
        private List<long> GetPrimes(int number)
        {
            List<long> primes = new List<long>();

            primes.Add(2);
            for (long i = 3; i < number; i += 2)
            {
                for (long j = (long)Math.Sqrt(i); j >= 1; j--)
                {
                    if (i % j == 0 && j != 1)
                    {
                        break;
                    }
                    else
                    {
                        if (j == 1)
                        {
                            primes.Add(i);
                        }
                    }
                }
            }

            return primes;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "2000000";
            lblResult.Text = "";
        }

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            int number;
            bool flag;
            long result = 0;
            flag = int.TryParse(txtInput.Text, out number);
            List<long> primes = SievePrimes(number);
            foreach (long prime in primes)
            {
                result += prime;
            }

            lblResult.Text = result.ToString();
        }

        private void btnCalc3_Click(object sender, EventArgs e)
        {
            int number;
            bool flag;
            long result = 0;
            flag = int.TryParse(txtInput.Text, out number);
            List<long> primes = SievePrimes2(number);
            foreach (long prime in primes)
            {
                result += prime;
            }

            lblResult.Text = result.ToString();
        }
    }
}
