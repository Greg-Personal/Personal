using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebugTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int exp1 = 0;
            int exp2 = 5;
            int result;

            try
            {
                throw new ArgumentOutOfRangeException();
                result = exp2 / exp1;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Divide by Zero Error", "Exception Thrown");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception Thrown");
            }
            finally
            {
                MessageBox.Show("In finally");
            }
        }
    }
}
