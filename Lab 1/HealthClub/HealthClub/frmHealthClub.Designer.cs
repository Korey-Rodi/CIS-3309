namespace HealthClub
{
    partial class frmHealthClub
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
            this.radAdult = new System.Windows.Forms.RadioButton();
            this.radChild = new System.Windows.Forms.RadioButton();
            this.radStudent = new System.Windows.Forms.RadioButton();
            this.radSenior = new System.Windows.Forms.RadioButton();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.lblMonthlyFees = new System.Windows.Forms.Label();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbMembershipType = new System.Windows.Forms.GroupBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.chkTrainer = new System.Windows.Forms.CheckBox();
            this.chkKarate = new System.Windows.Forms.CheckBox();
            this.chkYoga = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbMemmberLength = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbFees = new System.Windows.Forms.GroupBox();
            this.gbMembershipType.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbMemmberLength.SuspendLayout();
            this.gbFees.SuspendLayout();
            this.SuspendLayout();
            // 
            // radAdult
            // 
            this.radAdult.AutoSize = true;
            this.radAdult.Location = new System.Drawing.Point(2, 25);
            this.radAdult.Name = "radAdult";
            this.radAdult.Size = new System.Drawing.Size(141, 24);
            this.radAdult.TabIndex = 0;
            this.radAdult.TabStop = true;
            this.radAdult.Text = "Standard Adult";
            this.radAdult.UseVisualStyleBackColor = true;
            // 
            // radChild
            // 
            this.radChild.AutoSize = true;
            this.radChild.Location = new System.Drawing.Point(2, 55);
            this.radChild.Name = "radChild";
            this.radChild.Size = new System.Drawing.Size(177, 24);
            this.radChild.TabIndex = 1;
            this.radChild.TabStop = true;
            this.radChild.Text = "Child (12 and under)";
            this.radChild.UseVisualStyleBackColor = true;
            // 
            // radStudent
            // 
            this.radStudent.AutoSize = true;
            this.radStudent.Location = new System.Drawing.Point(2, 85);
            this.radStudent.Name = "radStudent";
            this.radStudent.Size = new System.Drawing.Size(91, 24);
            this.radStudent.TabIndex = 2;
            this.radStudent.TabStop = true;
            this.radStudent.Text = "Student";
            this.radStudent.UseVisualStyleBackColor = true;
            // 
            // radSenior
            // 
            this.radSenior.AutoSize = true;
            this.radSenior.Location = new System.Drawing.Point(2, 115);
            this.radSenior.Name = "radSenior";
            this.radSenior.Size = new System.Drawing.Size(132, 24);
            this.radSenior.TabIndex = 3;
            this.radSenior.TabStop = true;
            this.radSenior.Text = "Senior Citizen";
            this.radSenior.UseVisualStyleBackColor = true;
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(12, 59);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(204, 26);
            this.txtMonths.TabIndex = 5;
            // 
            // lblMonthlyFees
            // 
            this.lblMonthlyFees.AutoSize = true;
            this.lblMonthlyFees.Location = new System.Drawing.Point(141, 22);
            this.lblMonthlyFees.Name = "lblMonthlyFees";
            this.lblMonthlyFees.Size = new System.Drawing.Size(0, 20);
            this.lblMonthlyFees.TabIndex = 6;
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Location = new System.Drawing.Point(141, 56);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(0, 20);
            this.lblTotalFee.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(66, 392);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(165, 41);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(327, 392);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 41);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(587, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 41);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbMembershipType
            // 
            this.gbMembershipType.Controls.Add(this.radSenior);
            this.gbMembershipType.Controls.Add(this.radStudent);
            this.gbMembershipType.Controls.Add(this.radChild);
            this.gbMembershipType.Controls.Add(this.radAdult);
            this.gbMembershipType.Location = new System.Drawing.Point(66, 29);
            this.gbMembershipType.Name = "gbMembershipType";
            this.gbMembershipType.Size = new System.Drawing.Size(206, 151);
            this.gbMembershipType.TabIndex = 11;
            this.gbMembershipType.TabStop = false;
            this.gbMembershipType.Text = "Type of Membership";
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.chkTrainer);
            this.gbOptions.Controls.Add(this.chkKarate);
            this.gbOptions.Controls.Add(this.chkYoga);
            this.gbOptions.Location = new System.Drawing.Point(587, 29);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(199, 144);
            this.gbOptions.TabIndex = 12;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // chkTrainer
            // 
            this.chkTrainer.AutoSize = true;
            this.chkTrainer.Location = new System.Drawing.Point(25, 94);
            this.chkTrainer.Name = "chkTrainer";
            this.chkTrainer.Size = new System.Drawing.Size(150, 24);
            this.chkTrainer.TabIndex = 2;
            this.chkTrainer.Text = "Personal Trainer";
            this.chkTrainer.UseVisualStyleBackColor = true;
            // 
            // chkKarate
            // 
            this.chkKarate.AutoSize = true;
            this.chkKarate.Location = new System.Drawing.Point(25, 64);
            this.chkKarate.Name = "chkKarate";
            this.chkKarate.Size = new System.Drawing.Size(82, 24);
            this.chkKarate.TabIndex = 1;
            this.chkKarate.Text = "Karate";
            this.chkKarate.UseVisualStyleBackColor = true;
            // 
            // chkYoga
            // 
            this.chkYoga.AutoSize = true;
            this.chkYoga.Location = new System.Drawing.Point(25, 34);
            this.chkYoga.Name = "chkYoga";
            this.chkYoga.Size = new System.Drawing.Size(73, 24);
            this.chkYoga.TabIndex = 0;
            this.chkYoga.Text = "Yoga";
            this.chkYoga.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Enter the Number of Months";
            // 
            // gbMemmberLength
            // 
            this.gbMemmberLength.Controls.Add(this.txtMonths);
            this.gbMemmberLength.Controls.Add(this.label3);
            this.gbMemmberLength.Location = new System.Drawing.Point(68, 230);
            this.gbMemmberLength.Name = "gbMemmberLength";
            this.gbMemmberLength.Size = new System.Drawing.Size(249, 133);
            this.gbMemmberLength.TabIndex = 14;
            this.gbMemmberLength.TabStop = false;
            this.gbMemmberLength.Text = "Membership Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Monthly Fee:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total:";
            // 
            // gbFees
            // 
            this.gbFees.Controls.Add(this.label5);
            this.gbFees.Controls.Add(this.label4);
            this.gbFees.Controls.Add(this.lblTotalFee);
            this.gbFees.Controls.Add(this.lblMonthlyFees);
            this.gbFees.Location = new System.Drawing.Point(504, 221);
            this.gbFees.Name = "gbFees";
            this.gbFees.Size = new System.Drawing.Size(248, 128);
            this.gbFees.TabIndex = 17;
            this.gbFees.TabStop = false;
            this.gbFees.Text = "Membership Fees";
            // 
            // frmHealthClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbFees);
            this.Controls.Add(this.gbMemmberLength);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbMembershipType);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmHealthClub";
            this.Text = "Membership Fee Calculator";
            this.gbMembershipType.ResumeLayout(false);
            this.gbMembershipType.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbMemmberLength.ResumeLayout(false);
            this.gbMemmberLength.PerformLayout();
            this.gbFees.ResumeLayout(false);
            this.gbFees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radAdult;
        private System.Windows.Forms.RadioButton radChild;
        private System.Windows.Forms.RadioButton radStudent;
        private System.Windows.Forms.RadioButton radSenior;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.Label lblMonthlyFees;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbMembershipType;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbMemmberLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbFees;
        private System.Windows.Forms.CheckBox chkTrainer;
        private System.Windows.Forms.CheckBox chkKarate;
        private System.Windows.Forms.CheckBox chkYoga;
    }
}

