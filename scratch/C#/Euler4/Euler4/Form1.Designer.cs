namespace WindowsFormsApplication1
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
            this.lblResult = new System.Windows.Forms.Label();
            this.Calc1 = new System.Windows.Forms.Button();
            this.btnCalc2 = new System.Windows.Forms.Button();
            this.btnCalc3 = new System.Windows.Forms.Button();
            this.btnCalc4 = new System.Windows.Forms.Button();
            this.btnCalc5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(13, 13);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(267, 23);
            this.lblResult.TabIndex = 0;
            // 
            // Calc1
            // 
            this.Calc1.Location = new System.Drawing.Point(12, 68);
            this.Calc1.Name = "Calc1";
            this.Calc1.Size = new System.Drawing.Size(75, 23);
            this.Calc1.TabIndex = 1;
            this.Calc1.Text = "Calc1";
            this.Calc1.UseVisualStyleBackColor = true;
            this.Calc1.Click += new System.EventHandler(this.Calc1_Click);
            // 
            // btnCalc2
            // 
            this.btnCalc2.Location = new System.Drawing.Point(111, 68);
            this.btnCalc2.Name = "btnCalc2";
            this.btnCalc2.Size = new System.Drawing.Size(75, 23);
            this.btnCalc2.TabIndex = 2;
            this.btnCalc2.Text = "Calc2";
            this.btnCalc2.UseVisualStyleBackColor = true;
            this.btnCalc2.Click += new System.EventHandler(this.btnCalc2_Click);
            // 
            // btnCalc3
            // 
            this.btnCalc3.Location = new System.Drawing.Point(205, 68);
            this.btnCalc3.Name = "btnCalc3";
            this.btnCalc3.Size = new System.Drawing.Size(75, 23);
            this.btnCalc3.TabIndex = 3;
            this.btnCalc3.Text = "Calc3";
            this.btnCalc3.UseVisualStyleBackColor = true;
            this.btnCalc3.Click += new System.EventHandler(this.btnCalc3_Click);
            // 
            // btnCalc4
            // 
            this.btnCalc4.Location = new System.Drawing.Point(12, 101);
            this.btnCalc4.Name = "btnCalc4";
            this.btnCalc4.Size = new System.Drawing.Size(75, 23);
            this.btnCalc4.TabIndex = 4;
            this.btnCalc4.Text = "Calc4";
            this.btnCalc4.UseVisualStyleBackColor = true;
            this.btnCalc4.Click += new System.EventHandler(this.btnCalc4_Click);
            // 
            // btnCalc5
            // 
            this.btnCalc5.Location = new System.Drawing.Point(111, 101);
            this.btnCalc5.Name = "btnCalc5";
            this.btnCalc5.Size = new System.Drawing.Size(75, 23);
            this.btnCalc5.TabIndex = 5;
            this.btnCalc5.Text = "Calc5";
            this.btnCalc5.UseVisualStyleBackColor = true;
            this.btnCalc5.Click += new System.EventHandler(this.btnCalc5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 136);
            this.Controls.Add(this.btnCalc5);
            this.Controls.Add(this.btnCalc4);
            this.Controls.Add(this.btnCalc3);
            this.Controls.Add(this.btnCalc2);
            this.Controls.Add(this.Calc1);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button Calc1;
        private System.Windows.Forms.Button btnCalc2;
        private System.Windows.Forms.Button btnCalc3;
        private System.Windows.Forms.Button btnCalc4;
        private System.Windows.Forms.Button btnCalc5;
    }
}

