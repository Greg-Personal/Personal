using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private Button btnPlus;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox txtFirst;
    private TextBox txtSecond;
    private TextBox txtResult;
    private Button btnMinus;
    private Button btnTimes;
    private Button btnExit;
    private Button btnDivide;
    #region Windows code
    private void InitializeComponent()
    {
            this.btnPlus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(12, 81);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(28, 23);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Result:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(126, 16);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(46, 20);
            this.txtFirst.TabIndex = 4;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(126, 48);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(46, 20);
            this.txtSecond.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(126, 120);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(46, 20);
            this.txtResult.TabIndex = 6;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(53, 81);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(28, 23);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.Location = new System.Drawing.Point(99, 81);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(28, 23);
            this.btnTimes.TabIndex = 8;
            this.btnTimes.Text = "x";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(144, 81);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(28, 23);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(99, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(184, 185);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlus);
            this.Name = "frmMain";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion

    public frmMain()
    {
        InitializeComponent();
    }

    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    private void btnPlus_Click(object sender, EventArgs e)
    {
        bool flag;
        double first;
        double second;

        flag = double.TryParse(txtFirst.Text, out first);
        if (flag == false)
        {
            MessageBox.Show("Put in a number, dipshit.", "Input Error");
            txtFirst.Focus();
            return;
        }
        flag = double.TryParse(txtSecond.Text, out second);
        if (flag == false)
        {
            MessageBox.Show("Put in a number, dipshit.", "Input Error");
            txtSecond.Focus();
            return;
        }

        txtResult.Text = (first + second).ToString();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnMinus_Click(object sender, EventArgs e)
    {
        bool flag;
        double first;
        double second;

        flag = double.TryParse(txtFirst.Text, out first);
        if (flag == false)
        {
            MessageBox.Show("Put in a number, dipshit.", "Input Error");
            txtFirst.Focus();
            return;
        }
        flag = double.TryParse(txtSecond.Text, out second);
        if (flag == false)
        {
            MessageBox.Show("Put in a number, dipshit.", "Input Error");
            txtSecond.Focus();
            return;
        }

        txtResult.Text = (first - second).ToString();
    }

    private void btnTimes_Click(object sender, EventArgs e)
    {
        bool flag;
        double first;
        double second;

        flag = double.TryParse(txtFirst.Text, out first);
        if (flag == false)
        {
            MessageBox.Show("Put in a number, dipshit.", "Input Error");
            txtFirst.Focus();
            return;
        }
        flag = double.TryParse(txtSecond.Text, out second);
        if (flag == false)
        {
            MessageBox.Show("Put in a number, dipshit.", "Input Error");
            txtSecond.Focus();
            return;
        }

        txtResult.Text = (first * second).ToString();
    }

    private void btnDivide_Click(object sender, EventArgs e)
    {
        bool flag;
        double first;
        double second;

        flag = double.TryParse(txtFirst.Text, out first);
        if (flag == false)
        {
            MessageBox.Show("Put in a number, dipshit.", "Input Error");
            txtFirst.Focus();
            return;
        }
        flag = double.TryParse(txtSecond.Text, out second);
        if (flag == false)
        {
            MessageBox.Show("Put in a number, dipshit.", "Input Error");
            txtSecond.Focus();
            return;
        }

        txtResult.Text = (first / second).ToString();
    }
}