namespace MusicLibrary
{
    partial class frmSongView
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
            this.pbxAlbum = new System.Windows.Forms.PictureBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxAlbum
            // 
            this.pbxAlbum.Location = new System.Drawing.Point(192, 12);
            this.pbxAlbum.Name = "pbxAlbum";
            this.pbxAlbum.Size = new System.Drawing.Size(406, 374);
            this.pbxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAlbum.TabIndex = 0;
            this.pbxAlbum.TabStop = false;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(192, 472);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(404, 26);
            this.txtArtist.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(192, 422);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(404, 26);
            this.txtTitle.TabIndex = 2;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(194, 527);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(404, 26);
            this.txtAlbum.TabIndex = 3;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(194, 576);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(404, 26);
            this.txtYear.TabIndex = 4;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(194, 634);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(404, 26);
            this.txtDesc.TabIndex = 5;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(192, 697);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(404, 26);
            this.txtGenre.TabIndex = 6;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(194, 760);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(404, 26);
            this.txtDuration.TabIndex = 7;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(192, 822);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(404, 26);
            this.txtUrl.TabIndex = 8;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(20, 889);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(317, 77);
            this.btnSaveChanges.TabIndex = 9;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(446, 889);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(317, 77);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmSongView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 993);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.pbxAlbum);
            this.Name = "frmSongView";
            this.Text = "Song View";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbxAlbum;
        public System.Windows.Forms.TextBox txtArtist;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.TextBox txtAlbum;
        public System.Windows.Forms.TextBox txtYear;
        public System.Windows.Forms.TextBox txtDesc;
        public System.Windows.Forms.TextBox txtGenre;
        public System.Windows.Forms.TextBox txtDuration;
        public System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDelete;
    }
}