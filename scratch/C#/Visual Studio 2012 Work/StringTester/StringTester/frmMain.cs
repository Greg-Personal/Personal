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
    private Label label8;
    private Label label9;
    private Label label10;
    private TextBox txtInput;
    private TextBox txtLength;
    private TextBox txtToUpper;
    private TextBox txtToLower;
    private TextBox txtSearchChar;
    private TextBox txtLastChar;
    private TextBox txtStartIndex;
    private TextBox txtRemove;
    private TextBox txtReplaceChars;
    private TextBox txtReplaceResult;
    private Label label11;
    private TextBox txtReplaceWith;
    private TextBox txtSubstringResult;
    private Label lblLastIndexOf;
    private Label lblIndexOf;
    private TextBox txtLastIndexOf;
    private TextBox txtSearchIndex;
    private Label label14;
    private TextBox txtEndIndex;
    private Label lblSubstring;
    private Button btnTest;
    private Button btnExit;
    private TextBox txtRemoveResult;
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtToUpper = new System.Windows.Forms.TextBox();
            this.txtToLower = new System.Windows.Forms.TextBox();
            this.txtSearchChar = new System.Windows.Forms.TextBox();
            this.txtLastChar = new System.Windows.Forms.TextBox();
            this.txtStartIndex = new System.Windows.Forms.TextBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.txtReplaceChars = new System.Windows.Forms.TextBox();
            this.txtReplaceResult = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.txtSubstringResult = new System.Windows.Forms.TextBox();
            this.lblLastIndexOf = new System.Windows.Forms.Label();
            this.lblIndexOf = new System.Windows.Forms.Label();
            this.txtLastIndexOf = new System.Windows.Forms.TextBox();
            this.txtSearchIndex = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEndIndex = new System.Windows.Forms.TextBox();
            this.lblSubstring = new System.Windows.Forms.Label();
            this.txtRemoveResult = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "String to Test:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "String Length:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "String.ToLower():";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "String.ToUpper()";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Search for Last Character:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "txtInput.Remove() = :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Extract Substring from Index:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(12, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "txtInput.Replace() = :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(12, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Find:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(12, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Search for Character:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(181, 9);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(453, 20);
            this.txtInput.TabIndex = 10;
            this.txtInput.Text = "This is a test of various string METHODS. 1234567890 and z";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(180, 44);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(39, 20);
            this.txtLength.TabIndex = 11;
            // 
            // txtToUpper
            // 
            this.txtToUpper.Location = new System.Drawing.Point(180, 78);
            this.txtToUpper.Name = "txtToUpper";
            this.txtToUpper.Size = new System.Drawing.Size(453, 20);
            this.txtToUpper.TabIndex = 12;
            // 
            // txtToLower
            // 
            this.txtToLower.Location = new System.Drawing.Point(180, 112);
            this.txtToLower.Name = "txtToLower";
            this.txtToLower.Size = new System.Drawing.Size(453, 20);
            this.txtToLower.TabIndex = 13;
            // 
            // txtSearchChar
            // 
            this.txtSearchChar.Location = new System.Drawing.Point(180, 144);
            this.txtSearchChar.Name = "txtSearchChar";
            this.txtSearchChar.Size = new System.Drawing.Size(39, 20);
            this.txtSearchChar.TabIndex = 14;
            this.txtSearchChar.Text = "v";
            // 
            // txtLastChar
            // 
            this.txtLastChar.Location = new System.Drawing.Point(180, 178);
            this.txtLastChar.Name = "txtLastChar";
            this.txtLastChar.Size = new System.Drawing.Size(39, 20);
            this.txtLastChar.TabIndex = 15;
            this.txtLastChar.Text = "s";
            // 
            // txtStartIndex
            // 
            this.txtStartIndex.Location = new System.Drawing.Point(181, 215);
            this.txtStartIndex.Name = "txtStartIndex";
            this.txtStartIndex.Size = new System.Drawing.Size(38, 20);
            this.txtStartIndex.TabIndex = 16;
            this.txtStartIndex.Text = "18";
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(180, 250);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(80, 20);
            this.txtRemove.TabIndex = 17;
            this.txtRemove.Text = "string";
            // 
            // txtReplaceChars
            // 
            this.txtReplaceChars.Location = new System.Drawing.Point(180, 283);
            this.txtReplaceChars.Name = "txtReplaceChars";
            this.txtReplaceChars.Size = new System.Drawing.Size(127, 20);
            this.txtReplaceChars.TabIndex = 18;
            this.txtReplaceChars.Text = "1234567890";
            // 
            // txtReplaceResult
            // 
            this.txtReplaceResult.Location = new System.Drawing.Point(180, 317);
            this.txtReplaceResult.Name = "txtReplaceResult";
            this.txtReplaceResult.Size = new System.Drawing.Size(453, 20);
            this.txtReplaceResult.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(313, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Replace with:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Location = new System.Drawing.Point(417, 283);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(124, 20);
            this.txtReplaceWith.TabIndex = 21;
            this.txtReplaceWith.Text = "****";
            // 
            // txtSubstringResult
            // 
            this.txtSubstringResult.Location = new System.Drawing.Point(572, 216);
            this.txtSubstringResult.Name = "txtSubstringResult";
            this.txtSubstringResult.Size = new System.Drawing.Size(61, 20);
            this.txtSubstringResult.TabIndex = 22;
            // 
            // lblLastIndexOf
            // 
            this.lblLastIndexOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastIndexOf.Location = new System.Drawing.Point(225, 178);
            this.lblLastIndexOf.Name = "lblLastIndexOf";
            this.lblLastIndexOf.Size = new System.Drawing.Size(316, 20);
            this.lblLastIndexOf.TabIndex = 23;
            this.lblLastIndexOf.Text = "txtInput.Text.LastIndexOf(\"s\") =";
            this.lblLastIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIndexOf
            // 
            this.lblIndexOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIndexOf.Location = new System.Drawing.Point(225, 143);
            this.lblIndexOf.Name = "lblIndexOf";
            this.lblIndexOf.Size = new System.Drawing.Size(316, 20);
            this.lblIndexOf.TabIndex = 24;
            this.lblIndexOf.Text = "txtInput.Text.IndexOf(\"v\", 0) =";
            this.lblIndexOf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastIndexOf
            // 
            this.txtLastIndexOf.Location = new System.Drawing.Point(547, 178);
            this.txtLastIndexOf.Name = "txtLastIndexOf";
            this.txtLastIndexOf.Size = new System.Drawing.Size(39, 20);
            this.txtLastIndexOf.TabIndex = 25;
            // 
            // txtSearchIndex
            // 
            this.txtSearchIndex.Location = new System.Drawing.Point(547, 143);
            this.txtSearchIndex.Name = "txtSearchIndex";
            this.txtSearchIndex.Size = new System.Drawing.Size(39, 20);
            this.txtSearchIndex.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(225, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "for this many characters:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEndIndex
            // 
            this.txtEndIndex.Location = new System.Drawing.Point(371, 216);
            this.txtEndIndex.Name = "txtEndIndex";
            this.txtEndIndex.Size = new System.Drawing.Size(26, 20);
            this.txtEndIndex.TabIndex = 28;
            this.txtEndIndex.Text = "7";
            // 
            // lblSubstring
            // 
            this.lblSubstring.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubstring.Location = new System.Drawing.Point(403, 216);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.Size = new System.Drawing.Size(163, 20);
            this.lblSubstring.TabIndex = 29;
            this.lblSubstring.Text = "txtInput.Text.Substring(18, 7) =";
            this.lblSubstring.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemoveResult
            // 
            this.txtRemoveResult.Location = new System.Drawing.Point(266, 250);
            this.txtRemoveResult.Name = "txtRemoveResult";
            this.txtRemoveResult.Size = new System.Drawing.Size(367, 20);
            this.txtRemoveResult.TabIndex = 30;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 351);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 31;
            this.btnTest.Text = "&Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(559, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(646, 386);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtRemoveResult);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.txtEndIndex);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSearchIndex);
            this.Controls.Add(this.txtLastIndexOf);
            this.Controls.Add(this.lblIndexOf);
            this.Controls.Add(this.lblLastIndexOf);
            this.Controls.Add(this.txtSubstringResult);
            this.Controls.Add(this.txtReplaceWith);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtReplaceResult);
            this.Controls.Add(this.txtReplaceChars);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.txtStartIndex);
            this.Controls.Add(this.txtLastChar);
            this.Controls.Add(this.txtSearchChar);
            this.Controls.Add(this.txtToLower);
            this.Controls.Add(this.txtToUpper);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "String Tester";
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

    private void btnTest_Click(object sender, EventArgs e)
    {
        bool flag;
        int index;
        int start;
        int howMany;
        string temp;

        // Find Length
        txtLength.Text = txtInput.Text.Length.ToString();
        //Change Cases
        txtToUpper.Text = txtInput.Text.ToUpper();
        txtToLower.Text = txtInput.Text.ToLower();
        //Index Of
        index = txtInput.Text.IndexOf(txtSearchChar.Text, 0);
        lblIndexOf.Text = "txtInput.Text.IndexOf(\"" + txtSearchChar.Text + "\", 0) = ";
        txtSearchIndex.Text = index.ToString();
        // Last Index Of
        index = txtInput.Text.LastIndexOf(txtLastChar.Text);
        lblLastIndexOf.Text = "txtInput.Text.LastIndexOf(\"" + txtLastChar.Text + "\") = ";
        txtLastIndexOf.Text = index.ToString();
        // Substring
        flag = int.TryParse(txtStartIndex.Text, out start);
        if (flag == false)
        {
            MessageBox.Show("Improper numeric input. Re-enter.");
            txtStartIndex.Focus();
            return;
        }
        flag = int.TryParse(txtEndIndex.Text, out howMany);
        if (flag == false)
        {
            MessageBox.Show("Improper numberic input.  Re-enter.");
            txtEndIndex.Focus();
            return;
        }
        lblSubstring.Text = "txtInput.Text.Substring(" + start.ToString() + ", " + howMany.ToString() + ") = ";
        txtSubstringResult.Text = txtInput.Text.Substring(start, howMany);
        // Remove
        temp = txtInput.Text;
        index = temp.IndexOf(txtRemove.Text);
        if (index > 0)
        {
            txtRemoveResult.Text = temp.Remove(index, txtRemove.Text.Length);
        }
        //Replace
        temp = txtInput.Text;
        txtReplaceResult.Text = temp.Replace(txtReplaceChars.Text, txtReplaceWith.Text);
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }
}