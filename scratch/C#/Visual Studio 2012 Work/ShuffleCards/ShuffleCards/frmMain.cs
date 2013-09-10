using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private Button btnShuffle;
    private Button btnClear;
    private Button btnClose;
    private TextBox txtPassCounter;
    private ListBox lstDeck;
    #region Windows code
    private void InitializeComponent()
    {
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPassCounter = new System.Windows.Forms.TextBox();
            this.lstDeck = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(13, 13);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(75, 23);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(94, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(261, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPassCounter
            // 
            this.txtPassCounter.Location = new System.Drawing.Point(13, 230);
            this.txtPassCounter.Name = "txtPassCounter";
            this.txtPassCounter.ReadOnly = true;
            this.txtPassCounter.Size = new System.Drawing.Size(323, 20);
            this.txtPassCounter.TabIndex = 4;
            // 
            // lstDeck
            // 
            this.lstDeck.FormattingEnabled = true;
            this.lstDeck.Location = new System.Drawing.Point(13, 43);
            this.lstDeck.Name = "lstDeck";
            this.lstDeck.Size = new System.Drawing.Size(323, 186);
            this.lstDeck.TabIndex = 5;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(348, 262);
            this.Controls.Add(this.lstDeck);
            this.Controls.Add(this.txtPassCounter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShuffle);
            this.Name = "frmMain";
            this.Text = "Shuffle Deck";
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

    private void btnClear_Click(object sender, EventArgs e)
    {
        lstDeck.Items.Clear();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnShuffle_Click(object sender, EventArgs e)
    {
        int j;
        int cardIndex;
        int deckSize;
        int passes;
        string buff;
        string temp;
        clsCardDeck myDeck = new clsCardDeck();

        passes = myDeck.ShuffleDeck();
        txtPassCounter.Text = "It took " + passes.ToString() + " passes to shuffle the deck.";

        deckSize = myDeck.DeckSize;

        for (cardIndex = 1; cardIndex < deckSize + 1; )
        {
            buff = "";
            for (j = 0; j < 13; j++)
            {
                temp = myDeck.getOneCard(cardIndex);
                if (temp.Length == 0)
                {
                    MessageBox.Show("Error reading deck.", "Processing Error");
                    return;
                }
                buff += temp + " ";
                cardIndex++;
            }
            lstDeck.Items.Add(buff);
        }
        lstDeck.Items.Add(" ");
    }
}