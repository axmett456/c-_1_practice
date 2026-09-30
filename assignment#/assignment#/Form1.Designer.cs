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
            this.txtfoodtwoname = new System.Windows.Forms.TextBox();
            this.lblfood2name = new System.Windows.Forms.Label();
            this.txtfood1name = new System.Windows.Forms.TextBox();
            this.lblfood1name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Restaurant Bill Calculator";
            // 
            // lblFood1Price
            // 
            this.lblFood1Price.AutoSize = true;
            this.lblFood1Price.Location = new System.Drawing.Point(51, 97);
            this.lblFood1Price.Name = "lblFood1Price";
            this.lblFood1Price.Size = new System.Drawing.Size(79, 13);
            this.lblFood1Price.TabIndex = 1;
            this.lblFood1Price.Text = "Food 1 Price: $";
            // 
            // txtFood1Price
            // 
            this.txtFood1Price.Location = new System.Drawing.Point(161, 94);
            this.txtFood1Price.Name = "txtFood1Price";
            this.txtFood1Price.Size = new System.Drawing.Size(120, 20);
            this.txtFood1Price.TabIndex = 2;
            // 
            // lblFood2Price
            // 
            this.lblFood2Price.AutoSize = true;
            this.lblFood2Price.Location = new System.Drawing.Point(51, 167);
            this.lblFood2Price.Name = "lblFood2Price";
            this.lblFood2Price.Size = new System.Drawing.Size(79, 13);
            this.lblFood2Price.TabIndex = 3;
            this.lblFood2Price.Text = "Food 2 Price: $";
            // 
            // txtFood2Price
            // 
            this.txtFood2Price.Location = new System.Drawing.Point(161, 164);
            this.txtFood2Price.Name = "txtFood2Price";
            this.txtFood2Price.Size = new System.Drawing.Size(120, 20);
            this.txtFood2Price.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(49, 199);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(230, 30);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTaxLabel
            // 
            this.lblTaxLabel.AutoSize = true;
            this.lblTaxLabel.Location = new System.Drawing.Point(55, 259);
            this.lblTaxLabel.Name = "lblTaxLabel";
            this.lblTaxLabel.Size = new System.Drawing.Size(83, 13);
            this.lblTaxLabel.TabIndex = 6;
            this.lblTaxLabel.Text = "7% Sales Tax: $";
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Location = new System.Drawing.Point(165, 259);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(28, 13);
            this.lblTaxAmount.TabIndex = 7;
            this.lblTaxAmount.Text = "0.00";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.Location = new System.Drawing.Point(55, 299);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(123, 17);
            this.lblTotalLabel.TabIndex = 8;
            this.lblTotalLabel.Text = "Total Amount: $";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.Location = new System.Drawing.Point(165, 299);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(40, 17);
            this.lblTotalAmount.TabIndex = 9;
            this.lblTotalAmount.Text = "0.00";
            // 
            // txtfoodtwoname
            // 
            this.txtfoodtwoname.Location = new System.Drawing.Point(159, 129);
            this.txtfoodtwoname.Name = "txtfoodtwoname";
            this.txtfoodtwoname.Size = new System.Drawing.Size(120, 20);
            this.txtfoodtwoname.TabIndex = 11;
            // 
            // lblfood2name
            // 
            this.lblfood2name.AutoSize = true;
            this.lblfood2name.Location = new System.Drawing.Point(49, 132);
            this.lblfood2name.Name = "lblfood2name";
            this.lblfood2name.Size = new System.Drawing.Size(83, 13);
            this.lblfood2name.TabIndex = 10;
            this.lblfood2name.Text = "food two name :";
            // 
            // txtfood1name
            // 
            this.txtfood1name.Location = new System.Drawing.Point(160, 64);
            this.txtfood1name.Name = "txtfood1name";
            this.txtfood1name.Size = new System.Drawing.Size(120, 20);
            this.txtfood1name.TabIndex = 13;
            // 
            // lblfood1name
            // 
            this.lblfood1name.AutoSize = true;
            this.lblfood1name.Location = new System.Drawing.Point(50, 68);
            this.lblfood1name.Name = "lblfood1name";
            this.lblfood1name.Size = new System.Drawing.Size(84, 13);
            this.lblfood1name.TabIndex = 12;
            this.lblfood1name.Text = "food one name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 346);
            this.Controls.Add(this.txtfood1name);
            this.Controls.Add(this.lblfood1name);
            this.Controls.Add(this.txtfoodtwoname);
            this.Controls.Add(this.lblfood2name);
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
        private System.Windows.Forms.TextBox txtfoodtwoname;
        private System.Windows.Forms.Label lblfood2name;
        private System.Windows.Forms.TextBox txtfood1name;
        private System.Windows.Forms.Label lblfood1name;
    }
}

