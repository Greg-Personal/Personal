using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private TextBox txtDisplay;
    private Button btnPlus;
    private Button btnMinus;
    private Button btnDivide;
    private Button btnTimes;
    private Button btnEquals;
    private Button btnExit;

    bool flag;
    double first;
    double second;
    string method;

    #region Windows code
    private void InitializeComponent()
    {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(9, 10);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(75, 20);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(90, 10);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(27, 23);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(90, 41);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(27, 23);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(123, 41);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(27, 23);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.Location = new System.Drawing.Point(123, 10);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(27, 23);
            this.btnTimes.TabIndex = 4;
            this.btnTimes.Text = "*";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(156, 12);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(49, 52);
            this.btnEquals.TabIndex = 5;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(9, 41);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(217, 72);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtDisplay);
            this.Name = "frmMain";
            this.Text = "Calculator mk2";
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
        flag = double.TryParse(txtDisplay.Text, out first);
        if (flag == false)
        {
            MessageBox.Show("Put in a number, dipshit.", "Input Error");
            txtDisplay.Focus();
            return;
        }
        method = "+";
        txtDisplay.Clear();
        txtDisplay.Focus();
    }

    private void btnMinus_Click(object sender, EventArgs e)
    {
        flag = double.TryParse(txtDisplay.Text, out first);
        if (flag == false)
        {
            MessageBox.Show("Put in a number, dipshit.", "Input Error");
            txtDisplay.Focus();
            return;
        }
        method = "-";
        txtDisplay.Clear();
        txtDisplay.Focus();
    }

    private void btnTimes_Click(object sender, EventArgs e)
    {
        flag = double.TryParse(txtDisplay.Text, out first);
        if (flag == false)
        {
            MessageBox.Show("Put in a number, dipshit.", "Input Error");
            txtDisplay.Focus();
            return;
        }
        method = "*";
        txtDisplay.Clear();
        txtDisplay.Focus();
    }

    private void btnDivide_Click(object sender, EventArgs e)
    {
        flag = double.TryParse(txtDisplay.Text, out first);
        if (flag == false)
        {
            MessageBox.Show("Put in a number, dipshit.", "Input Error");
            txtDisplay.Focus();
            return;
        }
        method = "/";
        txtDisplay.Clear();
        txtDisplay.Focus();
    }

    private void btnEquals_Click(object sender, EventArgs e)
    {
        flag = double.TryParse(txtDisplay.Text, out second);
        if (flag == false)
        {
            MessageBox.Show("Put in a number, dipshit.", "Input Error");
            txtDisplay.Focus();
            return;
        }
        switch (method)
        {
            case "+":
                txtDisplay.Text = (first + second).ToString();
                break;
            case "-":
                txtDisplay.Text = (first - second).ToString();
                break;
            case "*":
                txtDisplay.Text = (first * second).ToString();
                break;
            case "/":
                txtDisplay.Text = (first / second).ToString();
                break;
        }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }
}