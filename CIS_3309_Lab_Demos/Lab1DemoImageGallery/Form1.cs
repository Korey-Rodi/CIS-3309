using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1DemoImageGallery
{
    public partial class Form1 : Form
    {
        int pictureNumber = 1;
        public Form1()
        {
            InitializeComponent();
            ChangePictures(pictureNumber);
        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();
        }
        private void ChangePictures(int pictureNumber)
        {
            switch (pictureNumber)
            {
                case 1:
                    PictureViewer.Image = Properties.Resources._1;
                    lblName.Text = "Saquan Barkley";
                    break;
                case 2:
                    PictureViewer.Image = Properties.Resources._2;
                    lblName.Text = "Zack Baun";
                    break;
                case 3:
                    PictureViewer.Image = Properties.Resources._3;
                    lblName.Text = "Jalen Carter";
                    break;
                case 4:
                    PictureViewer.Image = Properties.Resources._4;
                    lblName.Text = "Jordan Davis";
                    break;
                case 5:
                    PictureViewer.Image = Properties.Resources._5;
                    lblName.Text = "Branden Graham";
                    break;
                case 6:
                    PictureViewer.Image = Properties.Resources._6;
                    lblName.Text = "Devanta Smith";
                    break;
                case 7:
                    PictureViewer.Image = Properties.Resources._7;
                    lblName.Text = "Jalen Hurts";
                    break;

            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pictureNumber += 1;
            if (pictureNumber < 1)
            {
                pictureNumber = 7;
            }
            ChangePictures(pictureNumber);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pictureNumber -= 1;
            if (pictureNumber < 1)
            {
                pictureNumber = 7;
            }
            ChangePictures(pictureNumber);

        }
    }
}
