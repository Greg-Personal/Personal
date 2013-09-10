using System;
using System.Windows.Forms;

public class frmMain : Form
{
    private TextBox txtCoin;
    private Label lblCoin;
    private TextBox txtChange;
    private Button btnCoke;
    private Button btnDiet;
    private Button btnSprite;
    private Button btnBarqs;
    private Button btnPunch;
    private Button btnWater;
    private Button btnChange;
    private TextBox txtDrink;
    private Label lblMachine;
    #region Windows code
    private void InitializeComponent()
    {
        this.txtCoin = new System.Windows.Forms.TextBox();
        this.lblCoin = new System.Windows.Forms.Label();
        this.txtChange = new System.Windows.Forms.TextBox();
        this.btnCoke = new System.Windows.Forms.Button();
        this.btnDiet = new System.Windows.Forms.Button();
        this.btnSprite = new System.Windows.Forms.Button();
        this.btnBarqs = new System.Windows.Forms.Button();
        this.btnPunch = new System.Windows.Forms.Button();
        this.btnWater = new System.Windows.Forms.Button();
        this.btnChange = new System.Windows.Forms.Button();
        this.lblMachine = new System.Windows.Forms.Label();
        this.txtDrink = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // txtCoin
        // 
        this.txtCoin.Location = new System.Drawing.Point(255, 51);
        this.txtCoin.Name = "txtCoin";
        this.txtCoin.Size = new System.Drawing.Size(56, 20);
        this.txtCoin.TabIndex = 0;
        // 
        // lblCoin
        // 
        this.lblCoin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblCoin.Location = new System.Drawing.Point(245, 31);
        this.lblCoin.Name = "lblCoin";
        this.lblCoin.Size = new System.Drawing.Size(66, 17);
        this.lblCoin.TabIndex = 1;
        this.lblCoin.Text = "Insert Coin:";
        // 
        // txtChange
        // 
        this.txtChange.Location = new System.Drawing.Point(255, 311);
        this.txtChange.Name = "txtChange";
        this.txtChange.ReadOnly = true;
        this.txtChange.Size = new System.Drawing.Size(56, 20);
        this.txtChange.TabIndex = 3;
        // 
        // btnCoke
        // 
        this.btnCoke.Location = new System.Drawing.Point(197, 77);
        this.btnCoke.Name = "btnCoke";
        this.btnCoke.Size = new System.Drawing.Size(105, 25);
        this.btnCoke.TabIndex = 4;
        this.btnCoke.Text = "Coke $ 0.75";
        this.btnCoke.UseVisualStyleBackColor = true;
        this.btnCoke.Click += new System.EventHandler(this.btnCoke_Click);
        // 
        // btnDiet
        // 
        this.btnDiet.Location = new System.Drawing.Point(197, 108);
        this.btnDiet.Name = "btnDiet";
        this.btnDiet.Size = new System.Drawing.Size(105, 23);
        this.btnDiet.TabIndex = 5;
        this.btnDiet.Text = "Diet Coke $ 0.75";
        this.btnDiet.UseVisualStyleBackColor = true;
        this.btnDiet.Click += new System.EventHandler(this.btnDiet_Click);
        // 
        // btnSprite
        // 
        this.btnSprite.Location = new System.Drawing.Point(197, 137);
        this.btnSprite.Name = "btnSprite";
        this.btnSprite.Size = new System.Drawing.Size(105, 23);
        this.btnSprite.TabIndex = 6;
        this.btnSprite.Text = "Sprite $ 0.75";
        this.btnSprite.UseVisualStyleBackColor = true;
        this.btnSprite.Click += new System.EventHandler(this.btnSprite_Click);
        // 
        // btnBarqs
        // 
        this.btnBarqs.Location = new System.Drawing.Point(197, 166);
        this.btnBarqs.Name = "btnBarqs";
        this.btnBarqs.Size = new System.Drawing.Size(105, 22);
        this.btnBarqs.TabIndex = 7;
        this.btnBarqs.Text = "Root Beer $ 0.75";
        this.btnBarqs.UseVisualStyleBackColor = true;
        this.btnBarqs.Click += new System.EventHandler(this.btnBarqs_Click);
        // 
        // btnPunch
        // 
        this.btnPunch.Location = new System.Drawing.Point(197, 194);
        this.btnPunch.Name = "btnPunch";
        this.btnPunch.Size = new System.Drawing.Size(105, 24);
        this.btnPunch.TabIndex = 8;
        this.btnPunch.Text = "Fruit Punch $ 1.25";
        this.btnPunch.UseVisualStyleBackColor = true;
        this.btnPunch.Click += new System.EventHandler(this.btnPunch_Click);
        // 
        // btnWater
        // 
        this.btnWater.Location = new System.Drawing.Point(197, 224);
        this.btnWater.Name = "btnWater";
        this.btnWater.Size = new System.Drawing.Size(105, 26);
        this.btnWater.TabIndex = 9;
        this.btnWater.Text = "Water $ 1.00";
        this.btnWater.UseVisualStyleBackColor = true;
        this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
        // 
        // btnChange
        // 
        this.btnChange.Location = new System.Drawing.Point(245, 267);
        this.btnChange.Name = "btnChange";
        this.btnChange.Size = new System.Drawing.Size(66, 38);
        this.btnChange.TabIndex = 10;
        this.btnChange.Text = "Coin Return";
        this.btnChange.UseVisualStyleBackColor = true;
        this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
        // 
        // lblMachine
        // 
        this.lblMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblMachine.Location = new System.Drawing.Point(24, 84);
        this.lblMachine.Name = "lblMachine";
        this.lblMachine.Size = new System.Drawing.Size(151, 120);
        this.lblMachine.TabIndex = 11;
        this.lblMachine.Text = "Drink Coke!";
        this.lblMachine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // txtDrink
        // 
        this.txtDrink.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.txtDrink.Location = new System.Drawing.Point(51, 371);
        this.txtDrink.Name = "txtDrink";
        this.txtDrink.ReadOnly = true;
        this.txtDrink.Size = new System.Drawing.Size(216, 13);
        this.txtDrink.TabIndex = 12;
        this.txtDrink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        this.txtDrink.Visible = false;
        // 
        // frmMain
        // 
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(323, 442);
        this.Controls.Add(this.txtDrink);
        this.Controls.Add(this.lblMachine);
        this.Controls.Add(this.btnChange);
        this.Controls.Add(this.btnWater);
        this.Controls.Add(this.btnPunch);
        this.Controls.Add(this.btnBarqs);
        this.Controls.Add(this.btnSprite);
        this.Controls.Add(this.btnDiet);
        this.Controls.Add(this.btnCoke);
        this.Controls.Add(this.txtChange);
        this.Controls.Add(this.lblCoin);
        this.Controls.Add(this.txtCoin);
        this.Name = "frmMain";
        this.Text = "Coke Machine";
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

    private void btnCoke_Click(object sender, EventArgs e)
    {
        bool flag;
        bool funds;
        double cash;
        double change;
        string fchange;
        flag = double.TryParse(txtCoin.Text, out cash);
        if (flag == false)
        {
            MessageBox.Show("Put in Money, Idiot", "Y U NO PAY???");
            txtCoin.Focus();
            return;
        }
        funds = cash >= 0.75;
        if (funds == false)
        {
            MessageBox.Show("Put in MORE Money, Idiot", "Y U NO PAY ENOUGH???");
            txtCoin.Focus();
            return;
        }
        change = cash - 0.75;
        fchange = string.Format("{0:C}", change);
        txtChange.Text = fchange;
        txtDrink.Text = "You Got a Coke!";
        txtDrink.Visible = true;
        txtCoin.Text = "";
    }

    private void btnDiet_Click(object sender, EventArgs e)
    {
        bool flag;
        bool funds;
        double cash;
        double change;
        string fchange;
        flag = double.TryParse(txtCoin.Text, out cash);
        if (flag == false)
        {
            MessageBox.Show("Put in Money, Idiot", "Y U NO PAY???");
            txtCoin.Focus();
            return;
        }
        funds = cash >= 0.75;
        if (funds == false)
        {
            MessageBox.Show("Put in MORE Money, Idiot", "Y U NO PAY ENOUGH???");
            txtCoin.Focus();
            return;
        }
        change = cash - 0.75;
        fchange = string.Format("{0:C}", change);
        txtChange.Text = fchange;
        txtDrink.Text = "You Got a Diet Coke, fatty!";
        txtDrink.Visible = true;
        txtCoin.Text = "";
    }

    private void btnSprite_Click(object sender, EventArgs e)
    {
        bool flag;
        bool funds;
        double cash;
        double change;
        string fchange;
        flag = double.TryParse(txtCoin.Text, out cash);
        if (flag == false)
        {
            MessageBox.Show("Put in Money, Idiot", "Y U NO PAY???");
            txtCoin.Focus();
            return;
        }
        funds = cash >= 0.75;
        if (funds == false)
        {
            MessageBox.Show("Put in MORE Money, Idiot", "Y U NO PAY ENOUGH???");
            txtCoin.Focus();
            return;
        }
        change = cash - 0.75;
        fchange = string.Format("{0:C}", change);
        txtChange.Text = fchange;
        txtDrink.Text = "You Got a Sprite!";
        txtDrink.Visible = true;
        txtCoin.Text = "";
    }

    private void btnBarqs_Click(object sender, EventArgs e)
    {
        bool flag;
        bool funds;
        double cash;
        double change;
        string fchange;
        flag = double.TryParse(txtCoin.Text, out cash);
        if (flag == false)
        {
            MessageBox.Show("Put in Money, Idiot", "Y U NO PAY???");
            txtCoin.Focus();
            return;
        }
        funds = cash >= 0.75;
        if (funds == false)
        {
            MessageBox.Show("Put in MORE Money, Idiot", "Y U NO PAY ENOUGH???");
            txtCoin.Focus();
            return;
        }
        change = cash - 0.75;
        fchange = string.Format("{0:C}", change);
        txtChange.Text = fchange;
        txtDrink.Text = "You Got a Root Beer, kid!";
        txtDrink.Visible = true;
        txtCoin.Text = "";
    }

    private void btnPunch_Click(object sender, EventArgs e)
    {
        bool flag;
        bool funds;
        double cash;
        double change;
        string fchange;
        flag = double.TryParse(txtCoin.Text, out cash);
        if (flag == false)
        {
            MessageBox.Show("Put in Money, Idiot", "Y U NO PAY???");
            txtCoin.Focus();
            return;
        }
        funds = cash >= 1.25;
        if (funds == false)
        {
            MessageBox.Show("Put in MORE Money, Idiot", "Y U NO PAY ENOUGH???");
            txtCoin.Focus();
            return;
        }
        change = cash - 1.25;
        fchange = string.Format("{0:C}", change);
        txtChange.Text = fchange;
        txtDrink.Text = "You Got a Fruit Punch!";
        txtDrink.Visible = true;
        txtCoin.Text = "";
    }

    private void btnWater_Click(object sender, EventArgs e)
    {
        bool flag;
        bool funds;
        double cash;
        double change;
        string fchange;
        flag = double.TryParse(txtCoin.Text, out cash);
        if (flag == false)
        {
            MessageBox.Show("Put in Money, Idiot", "Y U NO PAY???");
            txtCoin.Focus();
            return;
        }
        funds = cash >= 1.00;
        if (funds == false)
        {
            MessageBox.Show("Put in MORE Money, Idiot", "Y U NO PAY ENOUGH???");
            txtCoin.Focus();
            return;
        }
        change = cash - 1.00;
        fchange = string.Format("{0:C}", change);
        txtChange.Text = fchange;
        txtDrink.Text = "You Got a Water.  Good call!";
        txtDrink.Visible = true;
        txtCoin.Text = "";
    }

    private void btnChange_Click(object sender, EventArgs e)
    {
        txtChange.Text = txtCoin.Text;
        txtDrink.Text = "You get Nothing!";
        txtCoin.Text = "";
    }
}