namespace classexampledemolab3
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnModal = new System.Windows.Forms.Button();
            this.btnNonModal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModal
            // 
            this.btnModal.BackColor = System.Drawing.Color.Salmon;
            this.btnModal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModal.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnModal.Location = new System.Drawing.Point(36, 55);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(393, 260);
            this.btnModal.TabIndex = 0;
            this.btnModal.Text = "Modal";
            this.btnModal.UseVisualStyleBackColor = false;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // btnNonModal
            // 
            this.btnNonModal.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNonModal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNonModal.Font = new System.Drawing.Font("Old English Text MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNonModal.ForeColor = System.Drawing.Color.Red;
            this.btnNonModal.Location = new System.Drawing.Point(676, 55);
            this.btnNonModal.Name = "btnNonModal";
            this.btnNonModal.Size = new System.Drawing.Size(393, 260);
            this.btnNonModal.TabIndex = 1;
            this.btnNonModal.Text = "Non-Modal";
            this.btnNonModal.UseVisualStyleBackColor = false;
            this.btnNonModal.Click += new System.EventHandler(this.btnNonModal_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1093, 870);
            this.Controls.Add(this.btnNonModal);
            this.Controls.Add(this.btnModal);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button btnNonModal;
    }
}