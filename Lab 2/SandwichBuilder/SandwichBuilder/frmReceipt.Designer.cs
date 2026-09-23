namespace SandwichBuilder
{
    partial class frmReceipt
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
            this.lblReceiptInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblReceiptInfo
            // 
            this.lblReceiptInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiptInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptInfo.Location = new System.Drawing.Point(0, 0);
            this.lblReceiptInfo.Name = "lblReceiptInfo";
            this.lblReceiptInfo.Size = new System.Drawing.Size(978, 944);
            this.lblReceiptInfo.TabIndex = 1;
            this.lblReceiptInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(978, 944);
            this.Controls.Add(this.lblReceiptInfo);
            this.Name = "frmReceipt";
            this.Text = "frmReceipt";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblReceiptInfo;
    }
}