namespace decomposeDividers
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtInputValue = new System.Windows.Forms.TextBox();
            this.lblInputValue = new System.Windows.Forms.Label();
            this.lblDividers = new System.Windows.Forms.Label();
            this.lbDividers = new System.Windows.Forms.ListBox();
            this.lbPrime = new System.Windows.Forms.ListBox();
            this.lblPrime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(155, 47);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(28, 21);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(92, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Digite um número:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(31, 47);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // txtInputValue
            // 
            this.txtInputValue.Location = new System.Drawing.Point(31, 108);
            this.txtInputValue.Name = "txtInputValue";
            this.txtInputValue.Size = new System.Drawing.Size(100, 20);
            this.txtInputValue.TabIndex = 3;
            // 
            // lblInputValue
            // 
            this.lblInputValue.AutoSize = true;
            this.lblInputValue.Location = new System.Drawing.Point(28, 92);
            this.lblInputValue.Name = "lblInputValue";
            this.lblInputValue.Size = new System.Drawing.Size(102, 13);
            this.lblInputValue.TabIndex = 4;
            this.lblInputValue.Text = "Número de Entrada:";
            // 
            // lblDividers
            // 
            this.lblDividers.AutoSize = true;
            this.lblDividers.Location = new System.Drawing.Point(28, 147);
            this.lblDividers.Name = "lblDividers";
            this.lblDividers.Size = new System.Drawing.Size(96, 13);
            this.lblDividers.TabIndex = 5;
            this.lblDividers.Text = "Números divisores:";
            // 
            // lbDividers
            // 
            this.lbDividers.FormattingEnabled = true;
            this.lbDividers.Location = new System.Drawing.Point(31, 163);
            this.lbDividers.Name = "lbDividers";
            this.lbDividers.Size = new System.Drawing.Size(100, 95);
            this.lbDividers.TabIndex = 6;
            // 
            // lbPrime
            // 
            this.lbPrime.FormattingEnabled = true;
            this.lbPrime.Location = new System.Drawing.Point(155, 163);
            this.lbPrime.Name = "lbPrime";
            this.lbPrime.Size = new System.Drawing.Size(100, 95);
            this.lbPrime.TabIndex = 7;
            // 
            // lblPrime
            // 
            this.lblPrime.AutoSize = true;
            this.lblPrime.Location = new System.Drawing.Point(152, 147);
            this.lblPrime.Name = "lblPrime";
            this.lblPrime.Size = new System.Drawing.Size(87, 13);
            this.lblPrime.TabIndex = 8;
            this.lblPrime.Text = "Divisores Primos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 287);
            this.Controls.Add(this.lblPrime);
            this.Controls.Add(this.lbPrime);
            this.Controls.Add(this.lbDividers);
            this.Controls.Add(this.lblDividers);
            this.Controls.Add(this.lblInputValue);
            this.Controls.Add(this.txtInputValue);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtInputValue;
        private System.Windows.Forms.Label lblInputValue;
        private System.Windows.Forms.Label lblDividers;
        private System.Windows.Forms.ListBox lbDividers;
        private System.Windows.Forms.ListBox lbPrime;
        private System.Windows.Forms.Label lblPrime;
    }
}

