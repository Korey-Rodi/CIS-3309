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
            // 
            // frmRegristration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisplayArea);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.btnProcess);
            this.Name = "frmRegristration";
            this.Text = "CIS 3309 Form Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Label lblDisplayArea;
    }
}

