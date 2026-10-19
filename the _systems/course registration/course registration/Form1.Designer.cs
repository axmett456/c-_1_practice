namespace course_registration
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
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.Btncalculate = new System.Windows.Forms.Button();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtcourses = new System.Windows.Forms.TextBox();
            this.lblcourses = new System.Windows.Forms.Label();
            this.txtlevel = new System.Windows.Forms.TextBox();
            this.lbllevel = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblanemeoutput = new System.Windows.Forms.Label();
            this.lblfeeoutput = new System.Windows.Forms.Label();
            this.lbldiscountoutput = new System.Windows.Forms.Label();
            this.lblageoutput = new System.Windows.Forms.Label();
            this.lbltutionoutput = new System.Windows.Forms.Label();
            this.lblcoursesoutput = new System.Windows.Forms.Label();
            this.lblfinaloutput = new System.Windows.Forms.Label();
            this.lblleveloutput = new System.Windows.Forms.Label();
            this.txtfee = new System.Windows.Forms.TextBox();
            this.lblfee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(50, 52);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(158, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter student name :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(248, 49);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(300, 26);
            this.txtname.TabIndex = 1;
            // 
            // Btncalculate
            // 
            this.Btncalculate.Location = new System.Drawing.Point(54, 333);
            this.Btncalculate.Name = "Btncalculate";
            this.Btncalculate.Size = new System.Drawing.Size(154, 51);
            this.Btncalculate.TabIndex = 2;
            this.Btncalculate.Text = "Calculate";
            this.Btncalculate.UseVisualStyleBackColor = true;
            this.Btncalculate.Click += new System.EventHandler(this.Btncalculate_Click);
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(248, 102);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(300, 26);
            this.txtage.TabIndex = 4;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(50, 105);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(145, 20);
            this.lblage.TabIndex = 3;
            this.lblage.Text = "Enter student age :";
            // 
            // txtcourses
            // 
            this.txtcourses.Location = new System.Drawing.Point(248, 159);
            this.txtcourses.Name = "txtcourses";
            this.txtcourses.Size = new System.Drawing.Size(300, 26);
            this.txtcourses.TabIndex = 6;
            // 
            // lblcourses
            // 
            this.lblcourses.AutoSize = true;
            this.lblcourses.Location = new System.Drawing.Point(50, 162);
            this.lblcourses.Name = "lblcourses";
            this.lblcourses.Size = new System.Drawing.Size(192, 20);
            this.lblcourses.TabIndex = 5;
            this.lblcourses.Text = "Enter number of courses :";
            // 
            // txtlevel
            // 
            this.txtlevel.Location = new System.Drawing.Point(248, 215);
            this.txtlevel.Name = "txtlevel";
            this.txtlevel.Size = new System.Drawing.Size(300, 26);
            this.txtlevel.TabIndex = 8;
            // 
            // lbllevel
            // 
            this.lbllevel.AutoSize = true;
            this.lbllevel.Location = new System.Drawing.Point(50, 218);
            this.lbllevel.Name = "lbllevel";
            this.lbllevel.Size = new System.Drawing.Size(133, 20);
            this.lbllevel.TabIndex = 7;
            this.lbllevel.Text = "Enter study level :";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(224, 333);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(154, 51);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(394, 333);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(154, 51);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblanemeoutput
            // 
            this.lblanemeoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblanemeoutput.Location = new System.Drawing.Point(52, 418);
            this.lblanemeoutput.Name = "lblanemeoutput";
            this.lblanemeoutput.Size = new System.Drawing.Size(230, 41);
            this.lblanemeoutput.TabIndex = 11;
            this.lblanemeoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblanemeoutput.Click += new System.EventHandler(this.lblanemoutput_Click);
            // 
            // lblfeeoutput
            // 
            this.lblfeeoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblfeeoutput.Location = new System.Drawing.Point(320, 418);
            this.lblfeeoutput.Name = "lblfeeoutput";
            this.lblfeeoutput.Size = new System.Drawing.Size(230, 41);
            this.lblfeeoutput.TabIndex = 12;
            this.lblfeeoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldiscountoutput
            // 
            this.lbldiscountoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbldiscountoutput.Location = new System.Drawing.Point(318, 488);
            this.lbldiscountoutput.Name = "lbldiscountoutput";
            this.lbldiscountoutput.Size = new System.Drawing.Size(230, 41);
            this.lbldiscountoutput.TabIndex = 14;
            this.lbldiscountoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblageoutput
            // 
            this.lblageoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblageoutput.Location = new System.Drawing.Point(52, 488);
            this.lblageoutput.Name = "lblageoutput";
            this.lblageoutput.Size = new System.Drawing.Size(230, 41);
            this.lblageoutput.TabIndex = 13;
            this.lblageoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltutionoutput
            // 
            this.lbltutionoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbltutionoutput.Location = new System.Drawing.Point(318, 558);
            this.lbltutionoutput.Name = "lbltutionoutput";
            this.lbltutionoutput.Size = new System.Drawing.Size(230, 41);
            this.lbltutionoutput.TabIndex = 16;
            this.lbltutionoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcoursesoutput
            // 
            this.lblcoursesoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblcoursesoutput.Location = new System.Drawing.Point(52, 558);
            this.lblcoursesoutput.Name = "lblcoursesoutput";
            this.lblcoursesoutput.Size = new System.Drawing.Size(230, 41);
            this.lblcoursesoutput.TabIndex = 15;
            this.lblcoursesoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblfinaloutput
            // 
            this.lblfinaloutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblfinaloutput.Location = new System.Drawing.Point(318, 627);
            this.lblfinaloutput.Name = "lblfinaloutput";
            this.lblfinaloutput.Size = new System.Drawing.Size(230, 41);
            this.lblfinaloutput.TabIndex = 18;
            this.lblfinaloutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblleveloutput
            // 
            this.lblleveloutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblleveloutput.Location = new System.Drawing.Point(52, 627);
            this.lblleveloutput.Name = "lblleveloutput";
            this.lblleveloutput.Size = new System.Drawing.Size(230, 41);
            this.lblleveloutput.TabIndex = 17;
            this.lblleveloutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtfee
            // 
            this.txtfee.Location = new System.Drawing.Point(248, 269);
            this.txtfee.Name = "txtfee";
            this.txtfee.Size = new System.Drawing.Size(300, 26);
            this.txtfee.TabIndex = 20;
            // 
            // lblfee
            // 
            this.lblfee.AutoSize = true;
            this.lblfee.Location = new System.Drawing.Point(50, 272);
            this.lblfee.Name = "lblfee";
            this.lblfee.Size = new System.Drawing.Size(112, 20);
            this.lblfee.TabIndex = 19;
            this.lblfee.Text = "Transport fee :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 710);
            this.Controls.Add(this.txtfee);
            this.Controls.Add(this.lblfee);
            this.Controls.Add(this.lblfinaloutput);
            this.Controls.Add(this.lblleveloutput);
            this.Controls.Add(this.lbltutionoutput);
            this.Controls.Add(this.lblcoursesoutput);
            this.Controls.Add(this.lbldiscountoutput);
            this.Controls.Add(this.lblageoutput);
            this.Controls.Add(this.lblfeeoutput);
            this.Controls.Add(this.lblanemeoutput);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtlevel);
            this.Controls.Add(this.lbllevel);
            this.Controls.Add(this.txtcourses);
            this.Controls.Add(this.lblcourses);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.Btncalculate);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button Btncalculate;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtcourses;
        private System.Windows.Forms.Label lblcourses;
        private System.Windows.Forms.TextBox txtlevel;
        private System.Windows.Forms.Label lbllevel;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblanemeoutput;
        private System.Windows.Forms.Label lblfeeoutput;
        private System.Windows.Forms.Label lbldiscountoutput;
        private System.Windows.Forms.Label lblageoutput;
        private System.Windows.Forms.Label lbltutionoutput;
        private System.Windows.Forms.Label lblcoursesoutput;
        private System.Windows.Forms.Label lblfinaloutput;
        private System.Windows.Forms.Label lblleveloutput;
        private System.Windows.Forms.TextBox txtfee;
        private System.Windows.Forms.Label lblfee;
    }
}

