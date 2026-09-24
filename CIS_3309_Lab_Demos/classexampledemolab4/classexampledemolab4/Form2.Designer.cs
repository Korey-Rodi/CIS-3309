namespace classexampledemolab4
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
            this.btnButton = new System.Windows.Forms.Button();
            this.btnButton2 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(33, 26);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(916, 157);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "Set";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnButton2
            // 
            this.btnButton2.Location = new System.Drawing.Point(33, 745);
            this.btnButton2.Name = "btnButton2";
            this.btnButton2.Size = new System.Drawing.Size(916, 157);
            this.btnButton2.TabIndex = 1;
            this.btnButton2.Text = "Get";
            this.btnButton2.UseVisualStyleBackColor = true;
            this.btnButton2.Click += new System.EventHandler(this.btnButton2_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(35, 189);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(913, 539);
            this.txtOutput.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 944);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnButton2);
            this.Controls.Add(this.btnButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnButton2;
        private System.Windows.Forms.TextBox txtOutput;
    }
}