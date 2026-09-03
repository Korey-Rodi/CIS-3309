namespace Lab1DemoImageGallery
{
    partial class Form2
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.cboFavAthlete = new System.Windows.Forms.ComboBox();
            this.lstFavoriteTeam = new System.Windows.Forms.CheckedListBox();
            this.radMailingList = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(48, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(605, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Take My PHLY Sports Survey";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.White;
            this.txtFullName.Location = new System.Drawing.Point(66, 75);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(577, 26);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.Text = "Full Name";
            // 
            // cboFavAthlete
            // 
            this.cboFavAthlete.FormattingEnabled = true;
            this.cboFavAthlete.Items.AddRange(new object[] {
            "Jalen Brown",
            "Bryce Harper",
            "Chase Utley",
            "Jalen Hurts",
            "Lebron James"});
            this.cboFavAthlete.Location = new System.Drawing.Point(187, 107);
            this.cboFavAthlete.Name = "cboFavAthlete";
            this.cboFavAthlete.Size = new System.Drawing.Size(317, 28);
            this.cboFavAthlete.TabIndex = 2;
            this.cboFavAthlete.Text = "Who is your Favoite PHLY Athlete";
            // 
            // lstFavoriteTeam
            // 
            this.lstFavoriteTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lstFavoriteTeam.FormattingEnabled = true;
            this.lstFavoriteTeam.Items.AddRange(new object[] {
            "PHILLIES",
            "EAGLES",
            "UNION",
            "FLYERS",
            "76\'ers"});
            this.lstFavoriteTeam.Location = new System.Drawing.Point(205, 150);
            this.lstFavoriteTeam.Name = "lstFavoriteTeam";
            this.lstFavoriteTeam.Size = new System.Drawing.Size(265, 119);
            this.lstFavoriteTeam.TabIndex = 3;
            // 
            // radMailingList
            // 
            this.radMailingList.AutoSize = true;
            this.radMailingList.Location = new System.Drawing.Point(227, 275);
            this.radMailingList.Name = "radMailingList";
            this.radMailingList.Size = new System.Drawing.Size(212, 24);
            this.radMailingList.TabIndex = 4;
            this.radMailingList.TabStop = true;
            this.radMailingList.Text = "Select to Join Mailing List";
            this.radMailingList.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(678, 644);
            this.Controls.Add(this.radMailingList);
            this.Controls.Add(this.lstFavoriteTeam);
            this.Controls.Add(this.cboFavAthlete);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form2";
            this.Text = "PHLY Sports Survey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ComboBox cboFavAthlete;
        private System.Windows.Forms.CheckedListBox lstFavoriteTeam;
        private System.Windows.Forms.RadioButton radMailingList;
    }
}