namespace ass11
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
            this.lblStudentInformation = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblStudentType = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.rbUndergraduate = new System.Windows.Forms.RadioButton();
            this.rbPostgraduate = new System.Windows.Forms.RadioButton();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSavedStudentInfo = new System.Windows.Forms.Label();
            this.txtSavedStudentInfo = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            // lblStudentInformation
            this.lblStudentInformation.AutoSize = true;
            this.lblStudentInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentInformation.ForeColor = System.Drawing.Color.Maroon;
            this.lblStudentInformation.Location = new System.Drawing.Point(30, 20);
            this.lblStudentInformation.Name = "lblStudentInformation";
            this.lblStudentInformation.Size = new System.Drawing.Size(177, 24);
            this.lblStudentInformation.TabIndex = 0;
            this.lblStudentInformation.Text = "Student Information";
            
            // lblStudentID
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(30, 60);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(58, 13);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "Student ID:";
            
            // txtStudentID
            this.txtStudentID.Location = new System.Drawing.Point(130, 60);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(200, 20);
            this.txtStudentID.TabIndex = 2;
            
            // lblStudentName
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(30, 90);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(75, 13);
            this.lblStudentName.TabIndex = 3;
            this.lblStudentName.Text = "Student Name:";
            
            // txtStudentName
            this.txtStudentName.Location = new System.Drawing.Point(130, 90);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(200, 20);
            this.txtStudentName.TabIndex = 4;
            
            // lblDepartment
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(30, 120);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 13);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department:";
            
            // txtDepartment
            this.txtDepartment.Location = new System.Drawing.Point(130, 120);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(200, 20);
            this.txtDepartment.TabIndex = 6;
            
            // lblMark
            this.lblMark.AutoSize = true;
            this.lblMark.Location = new System.Drawing.Point(30, 150);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(35, 13);
            this.lblMark.TabIndex = 7;
            this.lblMark.Text = "Mark:";
            
            // txtMark
            this.txtMark.Location = new System.Drawing.Point(130, 150);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(200, 20);
            this.txtMark.TabIndex = 8;
            
            // Mark validation label
            this.lblMarkNote = new System.Windows.Forms.Label();
            this.lblMarkNote.AutoSize = true;
            this.lblMarkNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkNote.ForeColor = System.Drawing.Color.Gray;
            this.lblMarkNote.Location = new System.Drawing.Point(130, 173);
            this.lblMarkNote.Name = "lblMarkNote";
            this.lblMarkNote.Size = new System.Drawing.Size(190, 13);
            this.lblMarkNote.TabIndex = 9;
            this.lblMarkNote.Text = "Mark must be a non-negative number (0 or above)";
            
            // lblStudentType
            this.lblStudentType.AutoSize = true;
            this.lblStudentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentType.Location = new System.Drawing.Point(30, 200);
            this.lblStudentType.Name = "lblStudentType";
            this.lblStudentType.Size = new System.Drawing.Size(82, 13);
            this.lblStudentType.TabIndex = 10;
            this.lblStudentType.Text = "Student Type";
            
            // rbUndergraduate
            this.rbUndergraduate.AutoSize = true;
            this.rbUndergraduate.Checked = true;
            this.rbUndergraduate.Location = new System.Drawing.Point(50, 220);
            this.rbUndergraduate.Name = "rbUndergraduate";
            this.rbUndergraduate.Size = new System.Drawing.Size(97, 17);
            this.rbUndergraduate.TabIndex = 11;
            this.rbUndergraduate.TabStop = true;
            this.rbUndergraduate.Text = "Undergraduate";
            this.rbUndergraduate.UseVisualStyleBackColor = true;
            
            // rbPostgraduate
            this.rbPostgraduate.AutoSize = true;
            this.rbPostgraduate.Location = new System.Drawing.Point(50, 243);
            this.rbPostgraduate.Name = "rbPostgraduate";
            this.rbPostgraduate.Size = new System.Drawing.Size(90, 17);
            this.rbPostgraduate.TabIndex = 12;
            this.rbPostgraduate.Text = "Postgraduate";
            this.rbPostgraduate.UseVisualStyleBackColor = true;
            
            // btnSaveToFile
            this.btnSaveToFile.BackColor = System.Drawing.Color.LightGreen;
            this.btnSaveToFile.Location = new System.Drawing.Point(30, 270);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(100, 35);
            this.btnSaveToFile.TabIndex = 13;
            this.btnSaveToFile.Text = "Save to File";
            this.btnSaveToFile.UseVisualStyleBackColor = false;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            
            // btnReadFromFile
            this.btnReadFromFile.Location = new System.Drawing.Point(140, 270);
            this.btnReadFromFile.Name = "btnReadFromFile";
            this.btnReadFromFile.Size = new System.Drawing.Size(100, 35);
            this.btnReadFromFile.TabIndex = 14;
            this.btnReadFromFile.Text = "Read from File";
            this.btnReadFromFile.UseVisualStyleBackColor = true;
            this.btnReadFromFile.Click += new System.EventHandler(this.btnReadFromFile_Click);
            
            // btnClear
            this.btnClear.Location = new System.Drawing.Point(250, 270);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 35);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            
            // btnExit
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Location = new System.Drawing.Point(340, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 35);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            
            // lblSavedStudentInfo
            this.lblSavedStudentInfo.AutoSize = true;
            this.lblSavedStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavedStudentInfo.ForeColor = System.Drawing.Color.Navy;
            this.lblSavedStudentInfo.Location = new System.Drawing.Point(490, 20);
            this.lblSavedStudentInfo.Name = "lblSavedStudentInfo";
            this.lblSavedStudentInfo.Size = new System.Drawing.Size(158, 17);
            this.lblSavedStudentInfo.TabIndex = 17;
            this.lblSavedStudentInfo.Text = "Saved Student Information";
            
            // txtSavedStudentInfo
            this.txtSavedStudentInfo.Location = new System.Drawing.Point(490, 45);
            this.txtSavedStudentInfo.Multiline = true;
            this.txtSavedStudentInfo.Name = "txtSavedStudentInfo";
            this.txtSavedStudentInfo.ReadOnly = true;
            this.txtSavedStudentInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSavedStudentInfo.Size = new System.Drawing.Size(290, 260);
            this.txtSavedStudentInfo.TabIndex = 18;
            
            // lblInstructions
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(490, 310);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(69, 13);
            this.lblInstructions.TabIndex = 19;
            this.lblInstructions.Text = "Instructions:";
            
            // Instructions content
            this.lblInstructionsDetail = new System.Windows.Forms.Label();
            this.lblInstructionsDetail.AutoSize = true;
            this.lblInstructionsDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionsDetail.Location = new System.Drawing.Point(490, 325);
            this.lblInstructionsDetail.Name = "lblInstructionsDetail";
            this.lblInstructionsDetail.Size = new System.Drawing.Size(280, 55);
            this.lblInstructionsDetail.TabIndex = 20;
            this.lblInstructionsDetail.Text = "1. Fill in Student ID, Name, Department, and Mark\r\n2. Select Student Type (Undergraduate or Postgraduate)\r\n3. Click \"Save to File\" to store the information\r\n4. Click \"Read from File\" to display all saved records";
            
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.lblInstructionsDetail);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtSavedStudentInfo);
            this.Controls.Add(this.lblSavedStudentInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReadFromFile);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.rbPostgraduate);
            this.Controls.Add(this.rbUndergraduate);
            this.Controls.Add(this.lblStudentType);
            this.Controls.Add(this.lblMarkNote);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblStudentInformation);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentInformation;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label lblMarkNote;
        private System.Windows.Forms.Label lblStudentType;
        private System.Windows.Forms.RadioButton rbUndergraduate;
        private System.Windows.Forms.RadioButton rbPostgraduate;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnReadFromFile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSavedStudentInfo;
        private System.Windows.Forms.TextBox txtSavedStudentInfo;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblInstructionsDetail;
    }
}

