namespace MusicLibrary
{
    partial class frmPlaylists
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
            this.components = new System.ComponentModel.Container();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.btnAddSongs = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.musicDataSet1 = new MusicLibrary.MusicDataSet1();
            this.musicDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxPlaylist = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblSongCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylist.ForeColor = System.Drawing.Color.Green;
            this.lblPlaylist.Location = new System.Drawing.Point(345, 4);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(261, 37);
            this.lblPlaylist.TabIndex = 1;
            this.lblPlaylist.Text = "Choose Playlist:";
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePlaylist.Location = new System.Drawing.Point(12, 538);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(239, 129);
            this.btnCreatePlaylist.TabIndex = 6;
            this.btnCreatePlaylist.Text = "Create Playlist";
            this.btnCreatePlaylist.UseVisualStyleBackColor = true;
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // btnAddSongs
            // 
            this.btnAddSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSongs.Location = new System.Drawing.Point(257, 538);
            this.btnAddSongs.Name = "btnAddSongs";
            this.btnAddSongs.Size = new System.Drawing.Size(247, 129);
            this.btnAddSongs.TabIndex = 7;
            this.btnAddSongs.Text = "Add Songs";
            this.btnAddSongs.UseVisualStyleBackColor = true;
            this.btnAddSongs.Click += new System.EventHandler(this.btnAddSongs_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(510, 538);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(248, 129);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // musicDataSet1
            // 
            this.musicDataSet1.DataSetName = "MusicDataSet1";
            this.musicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musicDataSet1BindingSource
            // 
            this.musicDataSet1BindingSource.DataSource = this.musicDataSet1;
            this.musicDataSet1BindingSource.Position = 0;
            // 
            // cbxPlaylist
            // 
            this.cbxPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPlaylist.FormattingEnabled = true;
            this.cbxPlaylist.Location = new System.Drawing.Point(296, 44);
            this.cbxPlaylist.Name = "cbxPlaylist";
            this.cbxPlaylist.Size = new System.Drawing.Size(390, 45);
            this.cbxPlaylist.TabIndex = 9;
            this.cbxPlaylist.SelectedIndexChanged += new System.EventHandler(this.cbxPlaylist_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(289, 101);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 37);
            this.lblName.TabIndex = 10;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDesc.Location = new System.Drawing.Point(289, 156);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(0, 37);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvSongs
            // 
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Location = new System.Drawing.Point(28, 279);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.RowHeadersWidth = 62;
            this.dgvSongs.RowTemplate.Height = 28;
            this.dgvSongs.Size = new System.Drawing.Size(953, 253);
            this.dgvSongs.TabIndex = 12;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(764, 538);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(228, 129);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblSongCount
            // 
            this.lblSongCount.AutoSize = true;
            this.lblSongCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSongCount.Location = new System.Drawing.Point(289, 207);
            this.lblSongCount.Name = "lblSongCount";
            this.lblSongCount.Size = new System.Drawing.Size(0, 37);
            this.lblSongCount.TabIndex = 14;
            this.lblSongCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmPlaylists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1004, 679);
            this.Controls.Add(this.lblSongCount);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvSongs);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbxPlaylist);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAddSongs);
            this.Controls.Add(this.btnCreatePlaylist);
            this.Controls.Add(this.lblPlaylist);
            this.Name = "frmPlaylists";
            this.Text = "Playlist";
            this.Load += new System.EventHandler(this.frmPlaylists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Button btnCreatePlaylist;
        private System.Windows.Forms.Button btnAddSongs;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.BindingSource musicDataSet1BindingSource;
        private MusicDataSet1 musicDataSet1;
        private System.Windows.Forms.ComboBox cbxPlaylist;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblSongCount;
    }
}