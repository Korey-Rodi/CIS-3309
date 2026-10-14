namespace MusicLibrary
{
    partial class frmAddSong
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
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtAlbumURL = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.cbxGenre = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(166, 12);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(197, 26);
            this.txtArtist.TabIndex = 0;
            this.txtArtist.Text = "Enter Artist:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(166, 62);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(197, 26);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "Enter Title:";
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(166, 243);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(197, 26);
            this.txtAlbum.TabIndex = 2;
            this.txtAlbum.Text = "Enter Album:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(166, 196);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(197, 26);
            this.txtYear.TabIndex = 3;
            this.txtYear.Text = "Enter Year:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(44, 284);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(441, 26);
            this.txtDesc.TabIndex = 4;
            this.txtDesc.Text = "Enter Description";
            // 
            // txtAlbumURL
            // 
            this.txtAlbumURL.Location = new System.Drawing.Point(44, 338);
            this.txtAlbumURL.Name = "txtAlbumURL";
            this.txtAlbumURL.Size = new System.Drawing.Size(441, 26);
            this.txtAlbumURL.TabIndex = 5;
            this.txtAlbumURL.Text = "Enter Cover Art URL:";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(166, 151);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(197, 26);
            this.txtDuration.TabIndex = 6;
            this.txtDuration.Text = "Enter Duration:";
            // 
            // cbxGenre
            // 
            this.cbxGenre.FormattingEnabled = true;
            this.cbxGenre.Items.AddRange(new object[] {
            "Pop",
            "Rock",
            "Grunge",
            "Emo",
            "Lofi"});
            this.cbxGenre.Location = new System.Drawing.Point(166, 106);
            this.cbxGenre.Name = "cbxGenre";
            this.cbxGenre.Size = new System.Drawing.Size(191, 28);
            this.cbxGenre.TabIndex = 7;
            this.cbxGenre.Text = "Pick Genre";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(157, 398);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(243, 58);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(541, 489);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxGenre);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtAlbumURL);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtArtist);
            this.Name = "frmAddSong";
            this.Text = "Add Song View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtAlbumURL;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.ComboBox cbxGenre;
        private System.Windows.Forms.Button btnAdd;
    }
}