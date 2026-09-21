namespace classexampledemolab3part2
{
    partial class frmRegister
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxPosition = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(19, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(463, 26);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Player Name:";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Defense",
            "Offense",
            "Special Teams"});
            this.cbxType.Location = new System.Drawing.Point(18, 60);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(462, 28);
            this.cbxType.TabIndex = 1;
            this.cbxType.Text = "Player Type:";
            // 
            // cbxPosition
            // 
            this.cbxPosition.FormattingEnabled = true;
            this.cbxPosition.Items.AddRange(new object[] {
            "QB",
            "RB",
            "WR",
            "TE",
            "Oline",
            "Dline",
            "LB",
            "CB",
            "S",
            "Punter",
            "Kicker"});
            this.cbxPosition.Location = new System.Drawing.Point(19, 117);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Size = new System.Drawing.Size(461, 28);
            this.cbxPosition.TabIndex = 2;
            this.cbxPosition.Text = "Player Position:";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Perpetua Titling MT", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(18, 310);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(464, 111);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(503, 469);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbxPosition);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.txtName);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxPosition;
        private System.Windows.Forms.Button btnRegister;
    }
}