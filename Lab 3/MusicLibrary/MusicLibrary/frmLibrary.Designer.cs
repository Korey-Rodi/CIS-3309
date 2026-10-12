namespace MusicLibrary
{
    partial class frmLibrary
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
            this.dgvLibrary = new System.Windows.Forms.DataGridView();
            this.musicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicDataSet = new MusicLibrary.MusicDataSet();
            this.btnViewSong = new System.Windows.Forms.Button();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibrary
            // 
            this.dgvLibrary.AutoGenerateColumns = false;
            this.dgvLibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artist,
            this.Title,
            this.Album});
            this.dgvLibrary.DataSource = this.musicDataSetBindingSource;
            this.dgvLibrary.Location = new System.Drawing.Point(17, 135);
            this.dgvLibrary.Name = "dgvLibrary";
            this.dgvLibrary.RowHeadersWidth = 62;
            this.dgvLibrary.RowTemplate.Height = 28;
            this.dgvLibrary.Size = new System.Drawing.Size(856, 516);
            this.dgvLibrary.TabIndex = 5;
            // 
            // musicDataSetBindingSource
            // 
            this.musicDataSetBindingSource.DataSource = this.musicDataSet;
            this.musicDataSetBindingSource.Position = 0;
            // 
            // musicDataSet
            // 
            this.musicDataSet.DataSetName = "MusicDataSet";
            this.musicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnViewSong
            // 
            this.btnViewSong.Location = new System.Drawing.Point(33, 20);
            this.btnViewSong.Name = "btnViewSong";
            this.btnViewSong.Size = new System.Drawing.Size(164, 29);
            this.btnViewSong.TabIndex = 6;
            this.btnViewSong.Text = "View Song";
            this.btnViewSong.UseVisualStyleBackColor = true;
            this.btnViewSong.Click += new System.EventHandler(this.btnViewSong_Click);
            // 
            // Artist
            // 
            this.Artist.DataPropertyName = "Artist";
            this.Artist.HeaderText = "Artist";
            this.Artist.MinimumWidth = 8;
            this.Artist.Name = "Artist";
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 8;
            this.Title.Name = "Title";
            // 
            // Album
            // 
            this.Album.DataPropertyName = "Album";
            this.Album.HeaderText = "Album";
            this.Album.MinimumWidth = 8;
            this.Album.Name = "Album";
            // 
            // frmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(886, 667);
            this.Controls.Add(this.btnViewSong);
            this.Controls.Add(this.dgvLibrary);
            this.Name = "frmLibrary";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.frmLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLibrary;
        private System.Windows.Forms.BindingSource musicDataSetBindingSource;
        private MusicDataSet musicDataSet;
        private System.Windows.Forms.Button btnViewSong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
    }
}

