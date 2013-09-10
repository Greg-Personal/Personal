using System;
using System.Windows.Forms;

public class frmMain : Form
{
    const int TIE = 0;
    const int PLAYERWINS = 1;
    const int DEALERWINS = 2;

    int betResult;
    int wager;
    int balance;
    int position;

    clsInBetweenRules myRules = new clsInBetweenRules();
    string[] cards = new string[3];

    private Label label1;
    private Label label2;
    private TextBox txtBalance;
    private TextBox txtWager;
    private Button btnDeal;
    private Button btnBet;
    private Button btnReset;
    private GroupBox groupBox1;
    private Label lblMore;
    private Label lblHi;
    private Label lblMiddle;
    private Label lblLow;
    private Label lblLess;
    private Label label5;
    private TextBox txtLow;
    private Label label4;
    private TextBox txtHi;
    private Button btnClose;
    private Label lblResult;
    #region Windows code
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtWager = new System.Windows.Forms.TextBox();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnBet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtHi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLess = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.lblHi = new System.Windows.Forms.Label();
            this.lblMore = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance: $";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(165, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wager: $";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(99, 8);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(60, 20);
            this.txtBalance.TabIndex = 2;
            // 
            // txtWager
            // 
            this.txtWager.Location = new System.Drawing.Point(249, 8);
            this.txtWager.Name = "txtWager";
            this.txtWager.Size = new System.Drawing.Size(100, 20);
            this.txtWager.TabIndex = 3;
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(13, 53);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeal.TabIndex = 4;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(119, 53);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(75, 23);
            this.btnBet.TabIndex = 5;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(366, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMore);
            this.groupBox1.Controls.Add(this.lblHi);
            this.groupBox1.Controls.Add(this.lblMiddle);
            this.groupBox1.Controls.Add(this.lblLow);
            this.groupBox1.Controls.Add(this.lblLess);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLow);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHi);
            this.groupBox1.Location = new System.Drawing.Point(13, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 128);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hand";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(366, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(143, 84);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(153, 23);
            this.lblResult.TabIndex = 0;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(66, 60);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(36, 20);
            this.txtLow.TabIndex = 9;
            // 
            // txtHi
            // 
            this.txtHi.Location = new System.Drawing.Point(204, 60);
            this.txtHi.Name = "txtHi";
            this.txtHi.Size = new System.Drawing.Size(36, 20);
            this.txtHi.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(66, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Low";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(204, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "High";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLess
            // 
            this.lblLess.Location = new System.Drawing.Point(18, 25);
            this.lblLess.Name = "lblLess";
            this.lblLess.Size = new System.Drawing.Size(36, 23);
            this.lblLess.TabIndex = 11;
            this.lblLess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLow
            // 
            this.lblLow.Location = new System.Drawing.Point(63, 25);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(36, 23);
            this.lblLow.TabIndex = 12;
            this.lblLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMiddle
            // 
            this.lblMiddle.Location = new System.Drawing.Point(130, 25);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(36, 23);
            this.lblMiddle.TabIndex = 13;
            this.lblMiddle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHi
            // 
            this.lblHi.Location = new System.Drawing.Point(201, 25);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(36, 23);
            this.lblHi.TabIndex = 14;
            this.lblHi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMore
            // 
            this.lblMore.Location = new System.Drawing.Point(258, 25);
            this.lblMore.Name = "lblMore";
            this.lblMore.Size = new System.Drawing.Size(36, 23);
            this.lblMore.TabIndex = 15;
            this.lblMore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(450, 262);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.txtWager);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "In Between";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion

    public frmMain()
    {
        bool flag;
        InitializeComponent();

        txtBalance.Text = myRules.Balance.ToString();
        txtWager.Text = myRules.Wager.ToString();
        flag = int.TryParse(txtBalance.Text, out balance);
        flag = int.TryParse(txtWager.Text, out wager);

        myRules.Shuffle();
    }

    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    private void btnDeal_Click(object sender, EventArgs e)
    {
        int retval;

        ClearRanges();
        lblResult.Text = "";

        retval = myRules.Balance;
        if (retval == 0)
        {
            MessageBox.Show("You're broke.  Game Over.");
            return;
        }

        retval = myRules.getCardsLeft();
        if (retval < 3)
        {
            lblResult.Text = "Deck was shuffled. . .";
            myRules.Shuffle();
        }
        myRules.DealHand(cards, ref betResult, ref position);
        ShowHiLow();
    }

    private void btnBet_Click(object sender, EventArgs e)
    {
        bool flag = int.TryParse(txtWager.Text, out wager);
        if (flag == false)
        {
            MessageBox.Show("Dollar Bets Only.  Re-enter.", "Input Error");
            txtWager.Focus();
            return;
        }

        switch (betResult)
        {
            case TIE:
                lblResult.Text = "Tie. Dealer Wins.";
                myRules.Balance -= wager;
                break;

            case PLAYERWINS:
                lblResult.Text = "You win!";
                myRules.Balance += wager;
                break;

            case DEALERWINS:
                lblResult.Text = "Sorry, you lose.";
                myRules.Balance -= wager;
                break;
        }
        txtBalance.Text = myRules.Balance.ToString();
        switch (position)
        {
            case 1:
                lblLess.Text = cards[2];
                break;
            case 2:
                lblLow.Text = cards[2];
                break;
            case 3:
                lblMiddle.Text = cards[2];
                break;
            case 4:
                lblHi.Text = cards[2];
                break;
            case 5:
                lblMore.Text = cards[2];
                break;
            default:
                MessageBox.Show("Results Error.", "Processing Error");
                break;
        }
    }

    private void ShowHiLow()
    {
        txtLow.Text = cards[0];
        txtHi.Text = cards[1];
    }

    private void ClearRanges()
    {
        lblLess.Text = "";
        lblLow.Text = "";
        lblMiddle.Text = "";
        lblHi.Text = "";
        lblMore.Text = "";
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        myRules.Balance = 100;
        txtBalance.Text = "100";
        txtWager.Text = "10";
        ClearRanges();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }
}