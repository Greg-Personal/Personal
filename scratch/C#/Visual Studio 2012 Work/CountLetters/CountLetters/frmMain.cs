using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private const int MAXLETTERS = 26;
    private const int MAXCHARS = MAXLETTERS - 1;
    private const int LETTERA = 65;

    private Label label1;
    private TextBox txtInput;
    private Button btnCalculate;
    private ListView lstOutput;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private Button btnClose;
    #region Windows code
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = " Enter Text";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 40);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(257, 162);
            this.txtInput.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(13, 209);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(195, 210);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstOutput.Location = new System.Drawing.Point(13, 239);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(257, 157);
            this.lstOutput.TabIndex = 4;
            this.lstOutput.UseCompatibleStateImageBehavior = false;
            this.lstOutput.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Letter";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Width";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 115;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(282, 408);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Count Letters";
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

    private void btnCalculate_Click(object sender, EventArgs e)
    {
        char oneLetter;
        int index;
        int i;
        int length;
        int[] count = new int[MAXLETTERS];
        string input;
        string buff;

        length = txtInput.Text.Length;
        if (length == 0)
        {
            MessageBox.Show("You need to enter some text", "Missing Input");
            txtInput.Focus();
            return;
        }
        input = txtInput.Text;
        input = input.ToUpper();

        for (i = 0; i < input.Length; i++)
        {
            oneLetter = input[i];
            index = oneLetter - LETTERA;
            if (index < 0 || index > MAXCHARS)
                continue;
            count[index]++;
        }

        ListViewItem which;
        for (i = 0; i < MAXLETTERS; i++)
        {
            oneLetter = (char)(i + LETTERA);
            which = new ListViewItem(oneLetter.ToString());
            which.SubItems.Add("[" + count[i].ToString() + "]");
            lstOutput.Items.Add(which);
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }
}