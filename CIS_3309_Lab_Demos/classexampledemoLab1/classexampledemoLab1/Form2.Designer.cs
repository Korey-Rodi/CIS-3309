namespace classexampledemoLab1
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
            lblsurvey = new Label();
            textBox1 = new TextBox();
            cboFAVathlete = new ComboBox();
            chkTeam = new CheckedListBox();
            lblforcheckboxlist = new Label();
            rdoMail = new RadioButton();
            SuspendLayout();
            // 
            // lblsurvey
            // 
            lblsurvey.AutoSize = true;
            lblsurvey.Font = new Font("Algerian", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsurvey.Location = new Point(12, 9);
            lblsurvey.Name = "lblsurvey";
            lblsurvey.Size = new Size(393, 38);
            lblsurvey.TabIndex = 0;
            lblsurvey.Text = "Philly Sports Survey";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 224, 192);
            textBox1.Location = new Point(24, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "Full Name";
            textBox1.UseWaitCursor = true;
            // 
            // cboFAVathlete
            // 
            cboFAVathlete.FormattingEnabled = true;
            cboFAVathlete.Items.AddRange(new object[] { "Brice Harper", "Dan Vladar", "Jalen Hurts", "Lebron James", "Milan Iloski " });
            cboFAVathlete.Location = new Point(24, 126);
            cboFAVathlete.Name = "cboFAVathlete";
            cboFAVathlete.Size = new Size(214, 28);
            cboFAVathlete.TabIndex = 2;
            cboFAVathlete.Text = "Favorite Philly Athlete";
            // 
            // chkTeam
            // 
            chkTeam.BackColor = Color.FromArgb(192, 255, 192);
            chkTeam.FormattingEnabled = true;
            chkTeam.Items.AddRange(new object[] { "Eagles", "Flyers", "Phillies", "76'ers", "Union" });
            chkTeam.Location = new Point(24, 196);
            chkTeam.Name = "chkTeam";
            chkTeam.Size = new Size(261, 114);
            chkTeam.TabIndex = 3;
            // 
            // lblforcheckboxlist
            // 
            lblforcheckboxlist.AutoSize = true;
            lblforcheckboxlist.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblforcheckboxlist.Location = new Point(24, 174);
            lblforcheckboxlist.Name = "lblforcheckboxlist";
            lblforcheckboxlist.Size = new Size(273, 19);
            lblforcheckboxlist.TabIndex = 4;
            lblforcheckboxlist.Text = "Check Philly teams you support";
            // 
            // rdoMail
            // 
            rdoMail.AutoSize = true;
            rdoMail.Location = new Point(24, 346);
            rdoMail.Name = "rdoMail";
            rdoMail.Size = new Size(164, 24);
            rdoMail.TabIndex = 5;
            rdoMail.TabStop = true;
            rdoMail.Text = "Join Our Mailing List";
            rdoMail.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(582, 553);
            Controls.Add(rdoMail);
            Controls.Add(lblforcheckboxlist);
            Controls.Add(chkTeam);
            Controls.Add(cboFAVathlete);
            Controls.Add(textBox1);
            Controls.Add(lblsurvey);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblsurvey;
        private TextBox textBox1;
        private ComboBox cboFAVathlete;
        private CheckedListBox chkTeam;
        private Label lblforcheckboxlist;
        private RadioButton rdoMail;
    }
}