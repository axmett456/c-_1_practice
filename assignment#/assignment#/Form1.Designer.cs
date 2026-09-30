namespace assignment_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFood1Price = new System.Windows.Forms.Label();
            this.txtFood1Price = new System.Windows.Forms.TextBox();
            this.lblFood2Price = new System.Windows.Forms.Label();
            this.txtFood2Price = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTaxLabel = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Restaurant Bill Calculator";

            // lblFood1Price
            this.lblFood1Price.AutoSize = true;
            this.lblFood1Price.Location = new System.Drawing.Point(50, 70);
            this.lblFood1Price.Name = "lblFood1Price";
            this.lblFood1Price.TabIndex = 1;
            this.lblFood1Price.Text = "Food 1 Price: $";

            // txtFood1Price
            this.txtFood1Price.Location = new System.Drawing.Point(160, 67);
            this.txtFood1Price.Name = "txtFood1Price";
            this.txtFood1Price.Size = new System.Drawing.Size(120, 20);
            this.txtFood1Price.TabIndex = 2;

            // lblFood2Price
            this.lblFood2Price.AutoSize = true;
            this.lblFood2Price.Location = new System.Drawing.Point(50, 105);
            this.lblFood2Price.Name = "lblFood2Price";
            this.lblFood2Price.TabIndex = 3;
            this.lblFood2Price.Text = "Food 2 Price: $";

            // txtFood2Price
            this.txtFood2Price.Location = new System.Drawing.Point(160, 102);
            this.txtFood2Price.Name = "txtFood2Price";
            this.txtFood2Price.Size = new System.Drawing.Size(120, 20);
            this.txtFood2Price.TabIndex = 4;

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(50, 145);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(230, 30);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // lblTaxLabel
            this.lblTaxLabel.AutoSize = true;
            this.lblTaxLabel.Location = new System.Drawing.Point(50, 200);
            this.lblTaxLabel.Name = "lblTaxLabel";
            this.lblTaxLabel.TabIndex = 6;
            this.lblTaxLabel.Text = "7% Sales Tax: $";

            // lblTaxAmount
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Location = new System.Drawing.Point(160, 200);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.TabIndex = 7;
            this.lblTaxAmount.Text = "0.00";

            // lblTotalLabel
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.Location = new System.Drawing.Point(50, 240);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.TabIndex = 8;
            this.lblTotalLabel.Text = "Total Amount: $";

            // lblTotalAmount
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.Location = new System.Drawing.Point(160, 240);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.TabIndex = 9;
            this.lblTotalAmount.Text = "0.00";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 300);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotalLabel);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.lblTaxLabel);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFood2Price);
            this.Controls.Add(this.lblFood2Price);
            this.Controls.Add(this.txtFood1Price);
            this.Controls.Add(this.lblFood1Price);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Restaurant Bill Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFood1Price;
        private System.Windows.Forms.TextBox txtFood1Price;
        private System.Windows.Forms.Label lblFood2Price;
        private System.Windows.Forms.TextBox txtFood2Price;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTaxLabel;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalAmount;
    }
}

