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
            this.btnViewPlaylists = new System.Windows.Forms.Button();
            this.btnViewLibrary = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicDataSet = new MusicLibrary.MusicDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewPlaylists
            // 
            this.btnViewPlaylists.Location = new System.Drawing.Point(17, 18);
            this.btnViewPlaylists.Name = "btnViewPlaylists";
            this.btnViewPlaylists.Size = new System.Drawing.Size(400, 45);
            this.btnViewPlaylists.TabIndex = 0;
            this.btnViewPlaylists.Text = "View Playlists";
            this.btnViewPlaylists.UseVisualStyleBackColor = true;
            // 
            // btnViewLibrary
            // 
            this.btnViewLibrary.Location = new System.Drawing.Point(423, 18);
            this.btnViewLibrary.Name = "btnViewLibrary";
            this.btnViewLibrary.Size = new System.Drawing.Size(451, 45);
            this.btnViewLibrary.TabIndex = 1;
            this.btnViewLibrary.Text = "View Library";
            this.btnViewLibrary.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 69);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(269, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Song";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(292, 69);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(272, 45);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Song";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(570, 69);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(304, 45);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Song";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.musicDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(856, 516);
            this.dataGridView1.TabIndex = 5;
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
            // frmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(886, 667);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnViewLibrary);
            this.Controls.Add(this.btnViewPlaylists);
            this.Name = "frmLibrary";
            this.Text = "Music Player";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewPlaylists;
        private System.Windows.Forms.Button btnViewLibrary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource musicDataSetBindingSource;
        private MusicDataSet musicDataSet;
    }
}

