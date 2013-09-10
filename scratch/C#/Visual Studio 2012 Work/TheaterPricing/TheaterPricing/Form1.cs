using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheaterPricing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            bool flag;
            int age;
            int price = 10;
            flag = int.TryParse(txtAge.Text, out age);
            if (age > 64 || age < 13)
            {
                price /= 2;
            }
            txtPrice.Text = price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string size = txtSize.Text;
            int price;
            switch (size)
            {
                case "Small":
                    price = 6;
                    txtCost.Text = price.ToString();
                    break;
                case "Medium":
                    price = 7;
                    txtCost.Text = price.ToString();
                    break;
                case "Large":
                    price = 8;
                    txtCost.Text = price.ToString();
                    break;
                default:
                    MessageBox.Show("Please enter Small, Medium, or Large.", "Error!");
                    txtSize.Focus();
                    break;
            }
        }
    }
}
