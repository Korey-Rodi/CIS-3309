namespace MusicLibrary
{
    partial class frmCreatePlaylist
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
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.txtPlaylistName = new System.Windows.Forms.TextBox();
            this.lblPlaylistDesc = new System.Windows.Forms.Label();
            this.txtPlaylistDesc = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPlaylistName.Location = new System.Drawing.Point(24, 59);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(326, 37);
            this.lblPlaylistName.TabIndex = 0;
            this.lblPlaylistName.Text = "Enter Playlist Name:";
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaylistName.Location = new System.Drawing.Point(368, 56);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Size = new System.Drawing.Size(273, 44);
            this.txtPlaylistName.TabIndex = 1;
            // 
            // lblPlaylistDesc
            // 
            this.lblPlaylistDesc.AutoSize = true;
            this.lblPlaylistDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlaylistDesc.Location = new System.Drawing.Point(24, 144);
            this.lblPlaylistDesc.Name = "lblPlaylistDesc";
            this.lblPlaylistDesc.Size = new System.Drawing.Size(312, 37);
            this.lblPlaylistDesc.TabIndex = 2;
            this.lblPlaylistDesc.Text = "Enter Playlist Desc:";
            // 
            // txtPlaylistDesc
            // 
            this.txtPlaylistDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaylistDesc.Location = new System.Drawing.Point(368, 137);
            this.txtPlaylistDesc.Name = "txtPlaylistDesc";
            this.txtPlaylistDesc.Size = new System.Drawing.Size(273, 44);
            this.txtPlaylistDesc.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(239, 255);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(219, 55);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmCreatePlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(677, 334);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtPlaylistDesc);
            this.Controls.Add(this.lblPlaylistDesc);
            this.Controls.Add(this.txtPlaylistName);
            this.Controls.Add(this.lblPlaylistName);
            this.Name = "frmCreatePlaylist";
            this.Text = "frmCreatePlaylist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.TextBox txtPlaylistName;
        private System.Windows.Forms.Label lblPlaylistDesc;
        private System.Windows.Forms.TextBox txtPlaylistDesc;
        private System.Windows.Forms.Button btnCreate;
    }
}