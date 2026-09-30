namespace hotel_room
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
            this.lblGuestName = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.lblNights = new System.Windows.Forms.Label();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.lblPriceNight = new System.Windows.Forms.Label();
            this.txtPriceNight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblServiceTaxLabel = new System.Windows.Forms.Label();
            this.lblServiceTax = new System.Windows.Forms.Label();
            this.lblDiscountLabel = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotalAmountLabel = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(178, 165);
            this.lblGuestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(142, 20);
            this.lblGuestName.TabIndex = 19;
            this.lblGuestName.Text = "Enter Guest Name";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(397, 160);
            this.txtGuestName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(343, 26);
            this.txtGuestName.TabIndex = 20;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(178, 219);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(133, 20);
            this.lblRoomType.TabIndex = 21;
            this.lblRoomType.Text = "Enter Room Type";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(397, 214);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(343, 26);
            this.txtRoomType.TabIndex = 22;
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Location = new System.Drawing.Point(178, 273);
            this.lblNights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(175, 20);
            this.lblNights.TabIndex = 23;
            this.lblNights.Text = "Enter Number of Nights";
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(397, 268);
            this.txtNights.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(343, 26);
            this.txtNights.TabIndex = 24;
            // 
            // lblPriceNight
            // 
            this.lblPriceNight.AutoSize = true;
            this.lblPriceNight.Location = new System.Drawing.Point(178, 327);
            this.lblPriceNight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceNight.Name = "lblPriceNight";
            this.lblPriceNight.Size = new System.Drawing.Size(156, 20);
            this.lblPriceNight.TabIndex = 25;
            this.lblPriceNight.Text = "Enter Price Per Night";
            // 
            // txtPriceNight
            // 
            this.txtPriceNight.Location = new System.Drawing.Point(397, 321);
            this.txtPriceNight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPriceNight.Name = "txtPriceNight";
            this.txtPriceNight.Size = new System.Drawing.Size(343, 26);
            this.txtPriceNight.TabIndex = 26;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(360, 382);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(180, 46);
            this.btnCalculate.TabIndex = 27;
            this.btnCalculate.Text = "Calculate Booking";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(235, 59);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(439, 32);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Hotel Room Booking Calculator";
            // 
            // lblServiceTaxLabel
            // 
            this.lblServiceTaxLabel.AutoSize = true;
            this.lblServiceTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblServiceTaxLabel.Location = new System.Drawing.Point(184, 459);
            this.lblServiceTaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceTaxLabel.Name = "lblServiceTaxLabel";
            this.lblServiceTaxLabel.Size = new System.Drawing.Size(193, 25);
            this.lblServiceTaxLabel.TabIndex = 28;
            this.lblServiceTaxLabel.Text = "Service Tax (10%)";
            // 
            // lblServiceTax
            // 
            this.lblServiceTax.AutoSize = true;
            this.lblServiceTax.Location = new System.Drawing.Point(408, 459);
            this.lblServiceTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceTax.Name = "lblServiceTax";
            this.lblServiceTax.Size = new System.Drawing.Size(49, 20);
            this.lblServiceTax.TabIndex = 29;
            this.lblServiceTax.Text = "$0.00";
            // 
            // lblDiscountLabel
            // 
            this.lblDiscountLabel.AutoSize = true;
            this.lblDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDiscountLabel.Location = new System.Drawing.Point(185, 509);
            this.lblDiscountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscountLabel.Name = "lblDiscountLabel";
            this.lblDiscountLabel.Size = new System.Drawing.Size(149, 25);
            this.lblDiscountLabel.TabIndex = 30;
            this.lblDiscountLabel.Text = "Discount (5%)";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(408, 513);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 20);
            this.lblDiscount.TabIndex = 31;
            this.lblDiscount.Text = "$0.00";
            // 
            // lblTotalAmountLabel
            // 
            this.lblTotalAmountLabel.AutoSize = true;
            this.lblTotalAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmountLabel.Location = new System.Drawing.Point(184, 560);
            this.lblTotalAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmountLabel.Name = "lblTotalAmountLabel";
            this.lblTotalAmountLabel.Size = new System.Drawing.Size(141, 25);
            this.lblTotalAmountLabel.TabIndex = 32;
            this.lblTotalAmountLabel.Text = "Total Amount";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(408, 560);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(49, 20);
            this.lblTotalAmount.TabIndex = 33;
            this.lblTotalAmount.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 693);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.lblNights);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.lblPriceNight);
            this.Controls.Add(this.txtPriceNight);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblServiceTaxLabel);
            this.Controls.Add(this.lblServiceTax);
            this.Controls.Add(this.lblDiscountLabel);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTotalAmountLabel);
            this.Controls.Add(this.lblTotalAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.Label lblPriceNight;
        private System.Windows.Forms.TextBox txtPriceNight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblServiceTaxLabel;
        private System.Windows.Forms.Label lblServiceTax;
        private System.Windows.Forms.Label lblDiscountLabel;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalAmountLabel;
        private System.Windows.Forms.Label lblTotalAmount;
    }
}

