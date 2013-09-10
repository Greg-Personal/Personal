using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private Label label1;
    private TextBox txtMax;
    private Button btnCalc;
    private Button btnClose;
    private ListView lsvTable;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    #region Windows code
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lsvTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table to run from 0 through:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(174, 22);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(42, 20);
            this.txtMax.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 56);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(141, 56);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lsvTable
            // 
            this.lsvTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvTable.Location = new System.Drawing.Point(13, 86);
            this.lsvTable.Name = "lsvTable";
            this.lsvTable.Size = new System.Drawing.Size(208, 164);
            this.lsvTable.TabIndex = 4;
            this.lsvTable.UseCompatibleStateImageBehavior = false;
            this.lsvTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "N * N";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "N * N * N";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(233, 262);
            this.Controls.Add(this.lsvTable);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Table of Numbers";
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
        int number;
        int i;
        ListViewItem which;

        flag = int.TryParse(txtMax.Text, out number);
        if (flag == false)
        {
            MessageBox.Show("Numeric Data Only", "Input Error");
            txtMax.Focus();
            return;
        }
        if (number < 0)
        {
            number = number * -1;
        }
        number++;

        int[,] myData = new int[number, 3];
        for (i = 0; i < number; i++)
        {
            myData[i, 0] = i;
            myData[i, 1] = i * i;
            myData[i, 2] = i * i * i;
        }

        for (i = 0; i < number; i++)
        {
            which = new ListViewItem(myData[i, 0].ToString());
            which.SubItems.Add(myData[i, 1].ToString());
            which.SubItems.Add(myData[i, 2].ToString());
            lsvTable.Items.Add(which);
        }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }
}