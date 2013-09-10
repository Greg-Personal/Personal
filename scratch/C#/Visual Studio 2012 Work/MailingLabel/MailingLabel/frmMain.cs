using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private TextBox txtName;
    private Label lblAddess;
    private TextBox txtAddress;
    private Label lblCity;
    private TextBox txtCity;
    private Label lblState;
    private Label lblZip;
    private TextBox txtState;
    private TextBox txtZip;
    private TextBox txtResult;
    private Button btnDisplay;
    private Button btnExit;
    private Label lblName;
    #region Windows code
    private void InitializeComponent()
    {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddess = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(13, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(331, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblAddess
            // 
            this.lblAddess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddess.Location = new System.Drawing.Point(13, 51);
            this.lblAddess.Name = "lblAddess";
            this.lblAddess.Size = new System.Drawing.Size(64, 20);
            this.lblAddess.TabIndex = 2;
            this.lblAddess.Text = "Address:";
            this.lblAddess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(83, 51);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(331, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCity.Location = new System.Drawing.Point(13, 88);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(64, 20);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(83, 88);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(133, 20);
            this.txtCity.TabIndex = 5;
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblState.Location = new System.Drawing.Point(222, 88);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(45, 20);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State:";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblZip
            // 
            this.lblZip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblZip.Location = new System.Drawing.Point(314, 88);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(36, 20);
            this.lblZip.TabIndex = 7;
            this.lblZip.Text = "Zip:";
            this.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(273, 88);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(35, 20);
            this.txtState.TabIndex = 8;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(357, 87);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(57, 20);
            this.txtZip.TabIndex = 9;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(13, 152);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(401, 98);
            this.txtResult.TabIndex = 10;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(13, 121);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 11;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(338, 120);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(440, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddess);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mailing Label Program";
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

    private void btnDisplay_Click(object sender, EventArgs e)
    {
        String buffer;

        buffer = "Mailing Label:" + Environment.NewLine + Environment.NewLine;
        buffer = buffer + txtName.Text + Environment.NewLine;
        buffer = buffer + txtAddress.Text + Environment.NewLine;
        buffer = buffer + txtCity.Text + ", " + txtState.Text + " " + txtZip.Text;
        txtResult.Text = buffer;
    }
}