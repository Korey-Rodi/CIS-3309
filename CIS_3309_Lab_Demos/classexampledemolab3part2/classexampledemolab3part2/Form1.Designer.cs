namespace classexampledemolab3part2
{
    partial class Form1
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.lvPlayers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(29, 20);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(437, 57);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Click here to register player";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lvPlayers
            // 
            this.lvPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvPlayers.HideSelection = false;
            this.lvPlayers.Location = new System.Drawing.Point(1, 123);
            this.lvPlayers.Name = "lvPlayers";
            this.lvPlayers.Size = new System.Drawing.Size(476, 291);
            this.lvPlayers.TabIndex = 1;
            this.lvPlayers.UseCompatibleStateImageBehavior = false;
            this.lvPlayers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Player Name";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Player Type";
            this.columnHeader2.Width = 202;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Player Position";
            this.columnHeader3.Width = 182;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.lvPlayers);
            this.Controls.Add(this.btnRegister);
            this.Name = "Form1";
            this.Text = "Little eagles registration form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        internal System.Windows.Forms.ListView lvPlayers;
    }
}

