namespace DatabaseExample2
{
    partial class frmStudentInfo
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
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(281, 186);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(138, 23);
            this.btnAddRecord.TabIndex = 27;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(281, 215);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 23);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update Database";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(327, 118);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(92, 23);
            this.btnLast.TabIndex = 25;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(327, 31);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(92, 23);
            this.btnFirst.TabIndex = 24;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(327, 89);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(92, 23);
            this.btnPrevious.TabIndex = 23;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(327, 60);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(92, 23);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(43, 126);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(36, 13);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Major:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(24, 103);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(55, 13);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Firstname:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(24, 77);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 13);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Lastname:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(24, 41);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(61, 13);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Student ID:";
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(91, 38);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(159, 20);
            this.txtSID.TabIndex = 17;
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(91, 126);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(89, 20);
            this.txtMajor.TabIndex = 16;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(91, 100);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(159, 20);
            this.txtFN.TabIndex = 15;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(91, 74);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(159, 20);
            this.txtLN.TabIndex = 14;
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 261);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.txtLN);
            this.Name = "frmStudentInfo";
            this.Text = "Student Information Form";
            this.Load += new System.EventHandler(this.frmStudentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnAddRecord;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnLast;
        internal System.Windows.Forms.Button btnFirst;
        internal System.Windows.Forms.Button btnPrevious;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtSID;
        internal System.Windows.Forms.TextBox txtMajor;
        internal System.Windows.Forms.TextBox txtFN;
        internal System.Windows.Forms.TextBox txtLN;
    }
}

