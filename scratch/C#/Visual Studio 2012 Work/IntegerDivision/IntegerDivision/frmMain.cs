using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private Label lblOper1;
    private Label lblOper2;
    private TextBox txtOper1;
    private TextBox txtOper2;
    private TextBox txtResult;
    private Button btnCalc;
    private Button btnExit;
    private Button btnClear;
    #region Windows code
    private void InitializeComponent()
    {
            this.lblOper1 = new System.Windows.Forms.Label();
            this.lblOper2 = new System.Windows.Forms.Label();
            this.txtOper1 = new System.Windows.Forms.TextBox();
            this.txtOper2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOper1
            // 
            this.lblOper1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOper1.Location = new System.Drawing.Point(12, 19);
            this.lblOper1.Name = "lblOper1";
            this.lblOper1.Size = new System.Drawing.Size(183, 20);
            this.lblOper1.TabIndex = 0;
            this.lblOper1.Text = "Enter first integer value:";
            this.lblOper1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOper2
            // 
            this.lblOper2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOper2.Location = new System.Drawing.Point(12, 46);
            this.lblOper2.Name = "lblOper2";
            this.lblOper2.Size = new System.Drawing.Size(183, 20);
            this.lblOper2.TabIndex = 1;
            this.lblOper2.Text = "Enter second integer value:";
            this.lblOper2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOper1
            // 
            this.txtOper1.Location = new System.Drawing.Point(201, 20);
            this.txtOper1.Name = "txtOper1";
            this.txtOper1.Size = new System.Drawing.Size(48, 20);
            this.txtOper1.TabIndex = 2;
            // 
            // txtOper2
            // 
            this.txtOper2.Location = new System.Drawing.Point(201, 46);
            this.txtOper2.Name = "txtOper2";
            this.txtOper2.Size = new System.Drawing.Size(48, 20);
            this.txtOper2.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 72);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(237, 20);
            this.txtResult.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 109);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(174, 109);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(93, 109);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(266, 147);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtOper2);
            this.Controls.Add(this.txtOper1);
            this.Controls.Add(this.lblOper2);
            this.Controls.Add(this.lblOper1);
            this.Name = "frmMain";
            this.Text = "Integer Division";
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
        int oper1;
        int oper2;
        int result;
        flag = int.TryParse(txtOper1.Text, out oper1);
        if (flag == false)
        {
            MessageBox.Show("Enter a whole number", "Input Error");
            txtOper1.Focus();
            return;
        }
        flag = int.TryParse(txtOper2.Text, out oper2);
        if (flag == false)
        {
            MessageBox.Show("Enter a whole number", "Input Error");
            txtOper2.Focus();
            return;
        }
        result = oper1 * oper2;
        txtResult.Text = oper1.ToString() + " times " + oper2.ToString() + " equals " + result.ToString();
        txtResult.Visible = true;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtResult.Text = "";
        txtOper1.Text = "";
        txtOper2.Text = "";
    }
}