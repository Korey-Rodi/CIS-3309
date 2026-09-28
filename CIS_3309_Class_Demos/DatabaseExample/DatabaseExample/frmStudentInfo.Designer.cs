namespace DatabaseExample
{
    partial class frmStudents
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnLoadStudentsFromCollection = new System.Windows.Forms.Button();
            this.btnSearchDatabase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlMajor = new System.Windows.Forms.ComboBox();
            this.btnSearchCollection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(12, 22);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(467, 150);
            this.dgvStudents.TabIndex = 27;
            // 
            // btnLoadStudentsFromCollection
            // 
            this.btnLoadStudentsFromCollection.Location = new System.Drawing.Point(485, 22);
            this.btnLoadStudentsFromCollection.Name = "btnLoadStudentsFromCollection";
            this.btnLoadStudentsFromCollection.Size = new System.Drawing.Size(193, 42);
            this.btnLoadStudentsFromCollection.TabIndex = 28;
            this.btnLoadStudentsFromCollection.Text = "Load Students from Collection";
            this.btnLoadStudentsFromCollection.UseVisualStyleBackColor = true;
            this.btnLoadStudentsFromCollection.Click += new System.EventHandler(this.btnLoadStudentsFromCollection_Click);
            // 
            // btnSearchDatabase
            // 
            this.btnSearchDatabase.Location = new System.Drawing.Point(246, 209);
            this.btnSearchDatabase.Name = "btnSearchDatabase";
            this.btnSearchDatabase.Size = new System.Drawing.Size(156, 34);
            this.btnSearchDatabase.TabIndex = 29;
            this.btnSearchDatabase.Text = "Search Database By Major";
            this.btnSearchDatabase.UseVisualStyleBackColor = true;
            this.btnSearchDatabase.Click += new System.EventHandler(this.btnSearchDatabase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Select a Major:";
            // 
            // ddlMajor
            // 
            this.ddlMajor.FormattingEnabled = true;
            this.ddlMajor.Location = new System.Drawing.Point(98, 211);
            this.ddlMajor.Name = "ddlMajor";
            this.ddlMajor.Size = new System.Drawing.Size(121, 21);
            this.ddlMajor.TabIndex = 31;
            // 
            // btnSearchCollection
            // 
            this.btnSearchCollection.Location = new System.Drawing.Point(246, 258);
            this.btnSearchCollection.Name = "btnSearchCollection";
            this.btnSearchCollection.Size = new System.Drawing.Size(156, 34);
            this.btnSearchCollection.TabIndex = 32;
            this.btnSearchCollection.Text = "Search Collection By Major";
            this.btnSearchCollection.UseVisualStyleBackColor = true;
            this.btnSearchCollection.Click += new System.EventHandler(this.btnSearchCollection_Click);
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 338);
            this.Controls.Add(this.btnSearchCollection);
            this.Controls.Add(this.ddlMajor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchDatabase);
            this.Controls.Add(this.btnLoadStudentsFromCollection);
            this.Controls.Add(this.dgvStudents);
            this.Name = "frmStudents";
            this.Text = "Students Form";
            this.Load += new System.EventHandler(this.frmStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStudents;
        internal System.Windows.Forms.Button btnLoadStudentsFromCollection;
        internal System.Windows.Forms.Button btnSearchDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlMajor;
        internal System.Windows.Forms.Button btnSearchCollection;
    }
}

