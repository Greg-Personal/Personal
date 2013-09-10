using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euler7
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
            flag = int.TryParse(txtInput.Text, out number);
            List<long> primes = GetPrimes(number);
            txtResult.Text = primes[number - 1].ToString();
        }

        private List<long> GetPrimes(int number)
        {
            List<long> primes = new List<long>();

            primes.Add(1);
            primes.Add(2);
            for (long i = 3; primes.Count < number; i += 2)
            {
                for (long j = i - 2; j >= 1; j -= 2)
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

        private List<long> GetPrimes2(int number)
        {
            List<long> primes = new List<long>();

            primes.Add(2);
            for (long i = 3; primes.Count < number; i += 2)
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

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            int number;
            bool flag;
            flag = int.TryParse(txtInput.Text, out number);
            List<long> primes = GetPrimes2(number);
            txtResult.Text = primes[number - 1].ToString();
        }
    }
}
