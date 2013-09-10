using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private TextBox txtFeet;
    private TextBox txtInches;
    private Label label1;
    private Label label2;
    private ListView lsvList;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private Button btnCalc;
    #region Windows code
    private void InitializeComponent()
    {
            this.txtFeet = new System.Windows.Forms.TextBox();
            this.txtInches = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvList = new System.Windows.Forms.ListView();
            this.btnCalc = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtFeet
            // 
            this.txtFeet.Location = new System.Drawing.Point(97, 23);
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(37, 20);
            this.txtFeet.TabIndex = 0;
            // 
            // txtInches
            // 
            this.txtInches.Location = new System.Drawing.Point(97, 49);
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(37, 20);
            this.txtInches.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Feet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inches:";
            // 
            // lsvList
            // 
            this.lsvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvList.Location = new System.Drawing.Point(16, 78);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(118, 91);
            this.lsvList.TabIndex = 4;
            this.lsvList.UseCompatibleStateImageBehavior = false;
            this.lsvList.View = System.Windows.Forms.View.Details;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(38, 175);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gender";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Weight";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(160, 219);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lsvList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInches);
            this.Controls.Add(this.txtFeet);
            this.Name = "frmMain";
            this.Text = "Weight";
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
        double height;
        double feet;
        double inches;
        double mweight;
        double fweight;
        int i;
        ListViewItem which;
        string[,] myData = new string[2, 2];

        lsvList.Items.Clear();
        flag = double.TryParse(txtFeet.Text, out feet);
        flag = double.TryParse(txtInches.Text, out inches);
        height = (feet * 12) + inches;
        mweight = (3.5 * height) - 108;
        fweight = (4.0 * height) - 128;
        myData[0, 0] = "Male";
        myData[1, 0] = "Female";
        myData[0, 1] = mweight.ToString();
        myData[1, 1] = fweight.ToString();
        for (i = 0; i < 2; i++)
        {
            which = new ListViewItem(myData[i, 0]);
            which.SubItems.Add(myData[i, 1]);
            lsvList.Items.Add(which);
        }

    }
}