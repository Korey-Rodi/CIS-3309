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
            this.lblPlaylistName.Location = new System.Drawing.Point(67, 56);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(225, 30);
            this.lblPlaylistName.TabIndex = 0;
            this.lblPlaylistName.Text = "Enter Playlist Name:";
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.Location = new System.Drawing.Point(264, 53);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Size = new System.Drawing.Size(100, 26);
            this.txtPlaylistName.TabIndex = 1;
            // 
            // lblPlaylistDesc
            // 
            this.lblPlaylistDesc.AutoSize = true;
            this.lblPlaylistDesc.Location = new System.Drawing.Point(67, 99);
            this.lblPlaylistDesc.Name = "lblPlaylistDesc";
            this.lblPlaylistDesc.Size = new System.Drawing.Size(218, 30);
            this.lblPlaylistDesc.TabIndex = 2;
            this.lblPlaylistDesc.Text = "Enter Playlist Desc:";
            // 
            // txtPlaylistDesc
            // 
            this.txtPlaylistDesc.Location = new System.Drawing.Point(264, 99);
            this.txtPlaylistDesc.Name = "txtPlaylistDesc";
            this.txtPlaylistDesc.Size = new System.Drawing.Size(100, 26);
            this.txtPlaylistDesc.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(117, 151);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(175, 26);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmCreatePlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 201);
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