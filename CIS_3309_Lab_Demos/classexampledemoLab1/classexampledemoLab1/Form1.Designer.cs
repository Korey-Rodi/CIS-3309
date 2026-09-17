namespace classexampledemoLab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBack = new Button();
            btnNext = new Button();
            lblName = new Label();
            PictureViewer = new PictureBox();
            btnnextform = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureViewer).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(15, 38);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(169, 50);
            btnBack.TabIndex = 0;
            btnBack.Text = "Last Pic";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(353, 38);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(169, 50);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next Pic";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(128, 255, 128);
            lblName.Location = new Point(205, 51);
            lblName.Name = "lblName";
            lblName.Size = new Size(133, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Player Name";
            // 
            // PictureViewer
            // 
            PictureViewer.Image = Properties.Resources._7;
            PictureViewer.Location = new Point(96, 125);
            PictureViewer.Name = "PictureViewer";
            PictureViewer.Size = new Size(350, 254);
            PictureViewer.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureViewer.TabIndex = 3;
            PictureViewer.TabStop = false;
            // 
            // btnnextform
            // 
            btnnextform.Location = new Point(167, 440);
            btnnextform.Name = "btnnextform";
            btnnextform.Size = new Size(224, 56);
            btnnextform.TabIndex = 4;
            btnnextform.Text = "Take our survey";
            btnnextform.UseVisualStyleBackColor = true;
            btnnextform.Click += btnnextform_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(582, 553);
            Controls.Add(btnnextform);
            Controls.Add(PictureViewer);
            Controls.Add(lblName);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PictureViewer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnNext;
        private Label lblName;
        private PictureBox PictureViewer;
        private Button btnnextform;
    }
}
