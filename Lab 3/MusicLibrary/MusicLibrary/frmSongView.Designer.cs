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
            this.pbxAlbumArt = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlbumArt)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxAlbumArt
            // 
            this.pbxAlbumArt.Location = new System.Drawing.Point(254, 29);
            this.pbxAlbumArt.Name = "pbxAlbumArt";
            this.pbxAlbumArt.Size = new System.Drawing.Size(235, 209);
            this.pbxAlbumArt.TabIndex = 0;
            this.pbxAlbumArt.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(254, 276);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(234, 26);
            this.txtTitle.TabIndex = 1;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(255, 325);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(234, 26);
            this.txtArtist.TabIndex = 2;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(254, 368);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(234, 26);
            this.txtAlbum.TabIndex = 3;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(255, 422);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(234, 26);
            this.txtYear.TabIndex = 4;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(115, 480);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(532, 26);
            this.txtDesc.TabIndex = 5;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(254, 523);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(234, 26);
            this.txtGenre.TabIndex = 6;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(254, 587);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(234, 26);
            this.txtDuration.TabIndex = 7;
            // 
            // frmSongView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(725, 708);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.pbxAlbumArt);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmSongView";
            this.Text = "frmSongView";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlbumArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbxAlbumArt;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.TextBox txtArtist;
        public System.Windows.Forms.TextBox txtAlbum;
        public System.Windows.Forms.TextBox txtYear;
        public System.Windows.Forms.TextBox txtDesc;
        public System.Windows.Forms.TextBox txtGenre;
        public System.Windows.Forms.TextBox txtDuration;
    }
}