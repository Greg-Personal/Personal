using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private TextBox txtLeapYearResult;
    private TextBox txtEasterResult;
    private Label label1;
    private TextBox txtInput;
    private Button btnCalc;
    private Button btnClose;
    #region Windows code
    private void InitializeComponent()
    {
            this.txtLeapYearResult = new System.Windows.Forms.TextBox();
            this.txtEasterResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLeapYearResult
            // 
            this.txtLeapYearResult.Location = new System.Drawing.Point(13, 133);
            this.txtLeapYearResult.Name = "txtLeapYearResult";
            this.txtLeapYearResult.ReadOnly = true;
            this.txtLeapYearResult.Size = new System.Drawing.Size(259, 20);
            this.txtLeapYearResult.TabIndex = 0;
            // 
            // txtEasterResult
            // 
            this.txtEasterResult.Location = new System.Drawing.Point(12, 159);
            this.txtEasterResult.Name = "txtEasterResult";
            this.txtEasterResult.ReadOnly = true;
            this.txtEasterResult.Size = new System.Drawing.Size(259, 20);
            this.txtEasterResult.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Year:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(152, 32);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(119, 20);
            this.txtInput.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(13, 89);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(196, 89);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEasterResult);
            this.Controls.Add(this.txtLeapYearResult);
            this.Name = "frmMain";
            this.Text = "Class Designer";
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

    private void btnCalc_Click(object sender, EventArgs e)
    {
        bool flag;
        int year;
        int leap;
        clsDates myDate = new clsDates();

        flag = int.TryParse(txtInput.Text, out year);
        if (flag == false)
        {
            MessageBox.Show("Digit characters only in YYYY format", "Input Error");
            txtInput.Focus();
            return;
        }
        leap = myDate.getLeapYear(year);
        txtLeapYearResult.Text = year.ToString() + " is " + ((leap == 1)? "" : "not ") + "a leap year";
        txtEasterResult.Text = myDate.getEaster(year);
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }
}