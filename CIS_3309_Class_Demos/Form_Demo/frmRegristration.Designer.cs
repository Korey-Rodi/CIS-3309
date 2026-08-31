namespace Form_Demo
{
    partial class frmRegristration
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
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.lblDisplayArea = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lblEnterPassword = new System.Windows.Forms.Label();
            this.chkPepperoniOpt = new System.Windows.Forms.CheckBox();
            this.chkCheeseOpt = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ddlStateOfResidence = new System.Windows.Forms.ComboBox();
            this.lstStateOfResidence = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProcess.Location = new System.Drawing.Point(229, 365);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(375, 62);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Click Me";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtUserInput
            // 
            this.txtUserInput.BackColor = System.Drawing.SystemColors.Info;
            this.txtUserInput.ForeColor = System.Drawing.Color.Black;
            this.txtUserInput.Location = new System.Drawing.Point(222, 176);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(392, 26);
            this.txtUserInput.TabIndex = 1;
            this.txtUserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserInput.TextChanged += new System.EventHandler(this.txtUserInput_TextChanged);
            // 
            // lblDisplayArea
            // 
            this.lblDisplayArea.AutoSize = true;
            this.lblDisplayArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayArea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDisplayArea.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayArea.Location = new System.Drawing.Point(63, 9);
            this.lblDisplayArea.Name = "lblDisplayArea";
            this.lblDisplayArea.Size = new System.Drawing.Size(699, 49);
            this.lblDisplayArea.TabIndex = 2;
            this.lblDisplayArea.Text = "Welcome to CIS 3309 Demo Program";
            this.lblDisplayArea.MouseEnter += new System.EventHandler(this.lblDisplayArea_MouseEnter);
            this.lblDisplayArea.MouseLeave += new System.EventHandler(this.lblDisplayArea_MouseLeave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtPassword.Location = new System.Drawing.Point(332, 226);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(186, 26);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(118, 179);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(98, 20);
            this.lblEnterName.TabIndex = 4;
            this.lblEnterName.Text = "Enter Name:";
            // 
            // lblEnterPassword
            // 
            this.lblEnterPassword.AutoSize = true;
            this.lblEnterPassword.Location = new System.Drawing.Point(205, 229);
            this.lblEnterPassword.Name = "lblEnterPassword";
            this.lblEnterPassword.Size = new System.Drawing.Size(121, 20);
            this.lblEnterPassword.TabIndex = 5;
            this.lblEnterPassword.Text = "Enter Password";
            // 
            // chkPepperoniOpt
            // 
            this.chkPepperoniOpt.AutoSize = true;
            this.chkPepperoniOpt.Location = new System.Drawing.Point(32, 83);
            this.chkPepperoniOpt.Name = "chkPepperoniOpt";
            this.chkPepperoniOpt.Size = new System.Drawing.Size(107, 24);
            this.chkPepperoniOpt.TabIndex = 6;
            this.chkPepperoniOpt.Text = "Pepperoni";
            this.chkPepperoniOpt.UseVisualStyleBackColor = true;
            // 
            // chkCheeseOpt
            // 
            this.chkCheeseOpt.AutoSize = true;
            this.chkCheeseOpt.Location = new System.Drawing.Point(32, 124);
            this.chkCheeseOpt.Name = "chkCheeseOpt";
            this.chkCheeseOpt.Size = new System.Drawing.Size(90, 24);
            this.chkCheeseOpt.TabIndex = 7;
            this.chkCheeseOpt.Text = "Cheese";
            this.chkCheeseOpt.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(646, 98);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 24);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(2, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(126, 24);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(2, 32);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(126, 24);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(641, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 99);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(644, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 84);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // ddlStateOfResidence
            // 
            this.ddlStateOfResidence.FormattingEnabled = true;
            this.ddlStateOfResidence.Items.AddRange(new object[] {
            "NJ",
            "PA",
            "DE",
            "MD",
            "MA",
            "NY"});
            this.ddlStateOfResidence.Location = new System.Drawing.Point(309, 289);
            this.ddlStateOfResidence.Name = "ddlStateOfResidence";
            this.ddlStateOfResidence.Size = new System.Drawing.Size(237, 28);
            this.ddlStateOfResidence.TabIndex = 14;
            this.ddlStateOfResidence.SelectedIndexChanged += new System.EventHandler(this.MyHandler);
            // 
            // lstStateOfResidence
            // 
            this.lstStateOfResidence.FormattingEnabled = true;
            this.lstStateOfResidence.ItemHeight = 20;
            this.lstStateOfResidence.Items.AddRange(new object[] {
            "PA",
            "NJ",
            "DE",
            "MA",
            "NY"});
            this.lstStateOfResidence.Location = new System.Drawing.Point(779, 332);
            this.lstStateOfResidence.Name = "lstStateOfResidence";
            this.lstStateOfResidence.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstStateOfResidence.Size = new System.Drawing.Size(155, 24);
            this.lstStateOfResidence.TabIndex = 15;
            // 
            // frmRegristration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.lstStateOfResidence);
            this.Controls.Add(this.ddlStateOfResidence);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.chkCheeseOpt);
            this.Controls.Add(this.chkPepperoniOpt);
            this.Controls.Add(this.lblEnterPassword);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblDisplayArea);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.btnProcess);
            this.Name = "frmRegristration";
            this.Text = "CIS 3309 Form Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Label lblDisplayArea;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Label lblEnterPassword;
        private System.Windows.Forms.CheckBox chkPepperoniOpt;
        private System.Windows.Forms.CheckBox chkCheeseOpt;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ddlStateOfResidence;
        private System.Windows.Forms.ListBox lstStateOfResidence;
    }
}

