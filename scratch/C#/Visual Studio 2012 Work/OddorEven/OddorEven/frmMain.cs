using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private TextBox txtNumber;
    private Label lblNumber;
    private TextBox txtResult;
    private Button btnCalc;
    #region Windows code
    private void InitializeComponent()
    {
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(172, 9);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.Location = new System.Drawing.Point(12, 9);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(137, 20);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Type a Number!";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(93, 96);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 2;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult.Visible = false;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(107, 55);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 35);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Odd or Even?";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(284, 130);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumber);
            this.Name = "frmMain";
            this.Text = "Odd or Even?";
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
        double number;
        double result;
        int answer;
        double.TryParse(txtNumber.Text, out number);
        result = number / 2;
        flag = int.TryParse(result.ToString(), out answer);
        if (flag == false)
        {
            txtResult.Text = "Odd";
            txtResult.Visible = true;
        }
        if (flag == true)
        {
            txtResult.Text = "Even";
            txtResult.Visible = true;
        }
    }
}