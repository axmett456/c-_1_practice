namespace bmi_assignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.LSTRESULT = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(257, 57);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(276, 28);
            this.txtWeight.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(63, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(396, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your height:";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(257, 105);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(276, 28);
            this.txtHeight.TabIndex = 2;
            // 
            // LSTRESULT
            // 
            this.LSTRESULT.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LSTRESULT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSTRESULT.FormattingEnabled = true;
            this.LSTRESULT.ItemHeight = 29;
            this.LSTRESULT.Location = new System.Drawing.Point(579, 68);
            this.LSTRESULT.Name = "LSTRESULT";
            this.LSTRESULT.Size = new System.Drawing.Size(305, 352);
            this.LSTRESULT.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 457);
            this.Controls.Add(this.LSTRESULT);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.ListBox LSTRESULT;
    }
}

