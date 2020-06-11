using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AntonyCelulares.Views.Shared
{
    public partial class ImageViewerPage : Form
    {
        public ICollection<Image> Images { get; set; }
        public Image SelectedImage 
        { 
            get=>ImageViewer.Image; 
            set=>ImageViewer.Image=value; 
        }
        public ImageViewerPage(Image image)
        {
          
            InitializeComponent();
            Images = new List<Image>();
            Images.Add(image);
            cargarMedias();
        }
        public ImageViewerPage(ICollection<Image> image)
        {
            InitializeComponent();
            Images = image;
            cargarMedias();
        }

        private void cargarMedias()
        {
            
            SelectedImage = Images.FirstOrDefault();
            foreach (var item in Images)
            {
                var pictureBox = new PictureBox();
                //pictureBox1.Location = new System.Drawing.Point(3, 3);
                pictureBox.Image = item;
                pictureBox.Size = new System.Drawing.Size(100, 80);
                pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureBox.TabIndex = 0;
                pictureBox.TabStop = false;
                pictureBox.Click += new System.EventHandler(this.ImageViewer_Click);
                this.MediaPanel.Controls.Add(pictureBox);
                //pictureBox.Show();
            }
           

        }

        private void ImageViewer_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox.Image != null)
            {
                SelectedImage = pictureBox.Image; 
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
