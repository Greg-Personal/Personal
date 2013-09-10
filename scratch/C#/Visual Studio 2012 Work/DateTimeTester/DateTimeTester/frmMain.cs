using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private TextBox txtCompleteDateAndTime;
    private TextBox txtLongDate;
    private TextBox txtShortDate;
    private TextBox txtGeneralDateAndTime;
    private TextBox txtLongTime;
    private TextBox txtShortTime;
    private TextBox txtDaysToNewYears;
    private Button btnRefresh;
    private Button btnExit;
    #region Windows code
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCompleteDateAndTime = new System.Windows.Forms.TextBox();
            this.txtLongDate = new System.Windows.Forms.TextBox();
            this.txtShortDate = new System.Windows.Forms.TextBox();
            this.txtGeneralDateAndTime = new System.Windows.Forms.TextBox();
            this.txtLongTime = new System.Windows.Forms.TextBox();
            this.txtShortTime = new System.Windows.Forms.TextBox();
            this.txtDaysToNewYears = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Date and Time:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Long Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Short Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "General Date and Time:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Long Time:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Short Time:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Days Until New Years\' Eve:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCompleteDateAndTime
            // 
            this.txtCompleteDateAndTime.Location = new System.Drawing.Point(213, 27);
            this.txtCompleteDateAndTime.Name = "txtCompleteDateAndTime";
            this.txtCompleteDateAndTime.Size = new System.Drawing.Size(292, 20);
            this.txtCompleteDateAndTime.TabIndex = 7;
            // 
            // txtLongDate
            // 
            this.txtLongDate.Location = new System.Drawing.Point(213, 59);
            this.txtLongDate.Name = "txtLongDate";
            this.txtLongDate.Size = new System.Drawing.Size(292, 20);
            this.txtLongDate.TabIndex = 8;
            // 
            // txtShortDate
            // 
            this.txtShortDate.Location = new System.Drawing.Point(213, 91);
            this.txtShortDate.Name = "txtShortDate";
            this.txtShortDate.Size = new System.Drawing.Size(292, 20);
            this.txtShortDate.TabIndex = 9;
            // 
            // txtGeneralDateAndTime
            // 
            this.txtGeneralDateAndTime.Location = new System.Drawing.Point(213, 123);
            this.txtGeneralDateAndTime.Name = "txtGeneralDateAndTime";
            this.txtGeneralDateAndTime.Size = new System.Drawing.Size(292, 20);
            this.txtGeneralDateAndTime.TabIndex = 10;
            // 
            // txtLongTime
            // 
            this.txtLongTime.Location = new System.Drawing.Point(213, 156);
            this.txtLongTime.Name = "txtLongTime";
            this.txtLongTime.Size = new System.Drawing.Size(292, 20);
            this.txtLongTime.TabIndex = 11;
            // 
            // txtShortTime
            // 
            this.txtShortTime.Location = new System.Drawing.Point(213, 190);
            this.txtShortTime.Name = "txtShortTime";
            this.txtShortTime.Size = new System.Drawing.Size(292, 20);
            this.txtShortTime.TabIndex = 12;
            // 
            // txtDaysToNewYears
            // 
            this.txtDaysToNewYears.Location = new System.Drawing.Point(213, 224);
            this.txtDaysToNewYears.Name = "txtDaysToNewYears";
            this.txtDaysToNewYears.Size = new System.Drawing.Size(292, 20);
            this.txtDaysToNewYears.TabIndex = 13;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(13, 264);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(429, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(517, 295);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtDaysToNewYears);
            this.Controls.Add(this.txtShortTime);
            this.Controls.Add(this.txtLongTime);
            this.Controls.Add(this.txtGeneralDateAndTime);
            this.Controls.Add(this.txtShortDate);
            this.Controls.Add(this.txtLongDate);
            this.Controls.Add(this.txtCompleteDateAndTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Date and Time Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion

    public frmMain()
    {
        InitializeComponent();
        UpdateTimeInfo();
    }

    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }
     private void UpdateTimeInfo()
    {
        int days;
        DateTime myTime = new DateTime();
        myTime = DateTime.Now;
        DateTime newYears = new DateTime(myTime.Year, 12, 31);
        txtCompleteDateAndTime.Text = myTime.ToString("f");
        txtLongDate.Text = myTime.ToString("D");
        txtShortDate.Text = myTime.ToString("d");
        txtGeneralDateAndTime.Text = myTime.ToString("g");
        txtLongTime.Text = myTime.ToString("T");
        txtShortTime.Text = myTime.ToString("t");

        days = newYears.DayOfYear - myTime.DayOfYear;
        txtDaysToNewYears.Text = days.ToString();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        UpdateTimeInfo();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnExit_Click_1(object sender, EventArgs e)
    {
        Close();
    }

    private void btnRefresh_Click_1(object sender, EventArgs e)
    {
        UpdateTimeInfo();
    }
}