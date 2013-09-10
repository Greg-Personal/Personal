using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private Label label2;
    private Button btnCalc;
    private TextBox txtInput;
    private TextBox txtResult;
    private Label label1;
    #region Windows code
    private void InitializeComponent()
    {
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.btnCalc = new System.Windows.Forms.Button();
        this.txtInput = new System.Windows.Forms.TextBox();
        this.txtResult = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label1.Location = new System.Drawing.Point(13, 13);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(116, 23);
        this.label1.TabIndex = 0;
        this.label1.Text = "Enter Birthday:";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.label2.Location = new System.Drawing.Point(12, 48);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(116, 23);
        this.label2.TabIndex = 1;
        this.label2.Text = "Days to next Birthday:";
        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // btnCalc
        // 
        this.btnCalc.Location = new System.Drawing.Point(104, 86);
        this.btnCalc.Name = "btnCalc";
        this.btnCalc.Size = new System.Drawing.Size(75, 23);
        this.btnCalc.TabIndex = 2;
        this.btnCalc.Text = "Calculate";
        this.btnCalc.UseVisualStyleBackColor = true;
        this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
        // 
        // txtInput
        // 
        this.txtInput.Location = new System.Drawing.Point(136, 15);
        this.txtInput.Name = "txtInput";
        this.txtInput.Size = new System.Drawing.Size(136, 20);
        this.txtInput.TabIndex = 3;
        // 
        // txtResult
        // 
        this.txtResult.Location = new System.Drawing.Point(134, 51);
        this.txtResult.Name = "txtResult";
        this.txtResult.Size = new System.Drawing.Size(138, 20);
        this.txtResult.TabIndex = 4;
        // 
        // frmMain
        // 
        this.ClientSize = new System.Drawing.Size(284, 117);
        this.Controls.Add(this.txtResult);
        this.Controls.Add(this.txtInput);
        this.Controls.Add(this.btnCalc);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "frmMain";
        this.Text = "Birthday Countdown";
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
        int day;
        int month;
        int indexday;
        int indexdayplus;
        int indexmonth;
        int countdown;
        DateTime current = new DateTime();
        current = DateTime.Now;
        indexday = txtInput.Text.IndexOf("/");
        indexdayplus = indexday + 1;
        indexmonth = txtInput.Text.LastIndexOf("/");
        flag = int.TryParse(txtInput.Text.Substring(0, indexday), out month);
        if (flag == false)
        {
            MessageBox.Show("Check your birthday", "Error");
            txtInput.Focus();
            return;
        }
        flag = int.TryParse(txtInput.Text.Substring(indexdayplus, indexmonth - indexdayplus), out day);
        if (flag == false)
        {
            MessageBox.Show("Check your birthday", "Error");
            txtInput.Focus();
            return;
        }
        DateTime birth = new DateTime(current.Year, month, day);
        if (month > current.Month)
        {
            countdown = birth.DayOfYear - current.DayOfYear;
            txtResult.Text = countdown.ToString();
        }
        if (month < current.Month)
        {
            countdown = (365 - current.DayOfYear) + birth.DayOfYear;
            txtResult.Text = countdown.ToString();
        }
        if (month == current.Month)
        {
            if (day > current.Day)
            {
                countdown = birth.DayOfYear - current.DayOfYear;
                txtResult.Text = countdown.ToString();
            }
            if (day < current.Day)
            {
                countdown = (365 - current.DayOfYear) + birth.DayOfYear;
                txtResult.Text = countdown.ToString();
            }
            if (day == current.Day)
            {
                txtResult.Text = "Happy Birthday!!!";
            }
        }
    }
}