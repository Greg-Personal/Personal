namespace Euler6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtDifference = new System.Windows.Forms.TextBox();
            this.txtSumSquare = new System.Windows.Forms.TextBox();
            this.txtSquareSum = new System.Windows.Forms.TextBox();
            this.btnCalc1 = new System.Windows.Forms.Button();
            this.btnCalc2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(97, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(75, 20);
            this.txtInput.TabIndex = 0;
            // 
            // txtDifference
            // 
            this.txtDifference.Location = new System.Drawing.Point(97, 54);
            this.txtDifference.Name = "txtDifference";
            this.txtDifference.ReadOnly = true;
            this.txtDifference.Size = new System.Drawing.Size(75, 20);
            this.txtDifference.TabIndex = 1;
            // 
            // txtSumSquare
            // 
            this.txtSumSquare.Location = new System.Drawing.Point(16, 33);
            this.txtSumSquare.Name = "txtSumSquare";
            this.txtSumSquare.ReadOnly = true;
            this.txtSumSquare.Size = new System.Drawing.Size(75, 20);
            this.txtSumSquare.TabIndex = 2;
            // 
            // txtSquareSum
            // 
            this.txtSquareSum.Location = new System.Drawing.Point(178, 33);
            this.txtSquareSum.Name = "txtSquareSum";
            this.txtSquareSum.ReadOnly = true;
            this.txtSquareSum.Size = new System.Drawing.Size(75, 20);
            this.txtSquareSum.TabIndex = 3;
            // 
            // btnCalc1
            // 
            this.btnCalc1.Location = new System.Drawing.Point(13, 90);
            this.btnCalc1.Name = "btnCalc1";
            this.btnCalc1.Size = new System.Drawing.Size(75, 23);
            this.btnCalc1.TabIndex = 4;
            this.btnCalc1.Text = "Calc1";
            this.btnCalc1.UseVisualStyleBackColor = true;
            this.btnCalc1.Click += new System.EventHandler(this.btnCalc1_Click);
            // 
            // btnCalc2
            // 
            this.btnCalc2.Location = new System.Drawing.Point(197, 89);
            this.btnCalc2.Name = "btnCalc2";
            this.btnCalc2.Size = new System.Drawing.Size(75, 23);
            this.btnCalc2.TabIndex = 5;
            this.btnCalc2.Text = "Calc2";
            this.btnCalc2.UseVisualStyleBackColor = true;
            this.btnCalc2.Click += new System.EventHandler(this.btnCalc2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 125);
            this.Controls.Add(this.btnCalc2);
            this.Controls.Add(this.btnCalc1);
            this.Controls.Add(this.txtSquareSum);
            this.Controls.Add(this.txtSumSquare);
            this.Controls.Add(this.txtDifference);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Euler 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtDifference;
        private System.Windows.Forms.TextBox txtSumSquare;
        private System.Windows.Forms.TextBox txtSquareSum;
        private System.Windows.Forms.Button btnCalc1;
        private System.Windows.Forms.Button btnCalc2;
    }
}

