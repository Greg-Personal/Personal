using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private TextBox txtTemp;
    private Button btnFah;
    private Button btnCel;
    private Button btnExit;
    private TextBox txtResult;
    private Label lblTemp;
    #region Windows code
    private void InitializeComponent()
    {
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.btnFah = new System.Windows.Forms.Button();
            this.btnCel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTemp
            // 
            this.lblTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTemp.Location = new System.Drawing.Point(22, 28);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(159, 20);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "Enter Temperature";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(215, 28);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(47, 20);
            this.txtTemp.TabIndex = 1;
            // 
            // btnFah
            // 
            this.btnFah.Location = new System.Drawing.Point(22, 75);
            this.btnFah.Name = "btnFah";
            this.btnFah.Size = new System.Drawing.Size(75, 39);
            this.btnFah.TabIndex = 2;
            this.btnFah.Text = "Convert to &Fahrenheit";
            this.btnFah.UseVisualStyleBackColor = true;
            this.btnFah.Click += new System.EventHandler(this.btnFah_Click);
            // 
            // btnCel
            // 
            this.btnCel.Location = new System.Drawing.Point(106, 75);
            this.btnCel.Name = "btnCel";
            this.btnCel.Size = new System.Drawing.Size(75, 39);
            this.btnCel.TabIndex = 3;
            this.btnCel.Text = "Convert to &Celsius";
            this.btnCel.UseVisualStyleBackColor = true;
            this.btnCel.Click += new System.EventHandler(this.btnCel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(187, 75);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(22, 133);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(240, 20);
            this.txtResult.TabIndex = 5;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(284, 170);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCel);
            this.Controls.Add(this.btnFah);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblTemp);
            this.Name = "frmMain";
            this.Text = "Temperature Conversion";
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

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnFah_Click(object sender, EventArgs e)
    {
        bool flag;
        double temp;
        double result;
        flag = double.TryParse(txtTemp.Text, out temp);
        if (flag == false)
        {
            MessageBox.Show("Type a number, dipshit", "You Fucked Up!");
            txtTemp.Focus();
            return;
        }
        result = temp * 1.8 + 32;
        txtResult.Text = txtTemp.Text + " degrees Celsius is " + result.ToString() + " degrees Fahrenheit";
    }

    private void btnCel_Click(object sender, EventArgs e)
    {
        bool flag;
        double temp;
        double half;
        double result;
        flag = double.TryParse(txtTemp.Text, out temp);
        if (flag == false)
        {
            MessageBox.Show("Type a number, dipshit", "You Fucked Up!");
            txtTemp.Focus();
            return;
        }
        half = temp - 32;
        result = half / 1.8;
        txtResult.Text = txtTemp.Text + " degrees Fahrenheit is " + result.ToString() + " degrees Celsius";
    }
}