using System;
using System.Windows.Forms;

public class frmMain : Form
{
    const int MAXITERATIONS = 200000; //Limit on Loop Passes

    private Label label1;
    private TextBox txtMax;
    private Button btnStart;
    private Button btnClose;
    private TextBox txtAnswer;
    #region Windows code
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate Numbers between 0 and:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(209, 11);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(57, 20);
            this.txtMax.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 50);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(191, 50);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(12, 89);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(254, 20);
            this.txtAnswer.TabIndex = 4;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(278, 120);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Duplicate Random Numbers";
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

    private void btnStart_Click(object sender, EventArgs e)
    {
        bool flag;
        int counter;
        int max;
        int last;
        int current;
        Random randomnumber = new Random();

        flag = int.TryParse(txtMax.Text, out max);
        if (flag == false)
        {
            MessageBox.Show("Digit characters only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            txtMax.Focus();
            return;
        }

        counter = 0;
        last = (int)randomnumber.Next(max);
        do
        {
            current = randomnumber.Next(max);
            if (last == current)
            {
                break;
            }
            last = current;
            counter++;
        } while (counter < MAXITERATIONS);

        if (counter < MAXITERATIONS)
        {
            txtAnswer.Text = "It took " + counter.ToString() + " passes to match";
        }
        else
        {
            txtAnswer.Text = "No back to back match";
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }
}