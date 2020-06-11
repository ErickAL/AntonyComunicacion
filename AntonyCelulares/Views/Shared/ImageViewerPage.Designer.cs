namespace AntonyCelulares.Views.Shared
{
    partial class ImageViewerPage
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
            this.ImageViewer = new System.Windows.Forms.PictureBox();
            this.MediaPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewer)).BeginInit();
            this.MediaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageViewer
            // 
            this.ImageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageViewer.Location = new System.Drawing.Point(0, 0);
            this.ImageViewer.Name = "ImageViewer";
            this.ImageViewer.Size = new System.Drawing.Size(800, 450);
            this.ImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageViewer.TabIndex = 0;
            this.ImageViewer.TabStop = false;
            // 
            // MediaPanel
            // 
            this.MediaPanel.Controls.Add(this.pictureBox1);
            this.MediaPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MediaPanel.Location = new System.Drawing.Point(0, 367);
            this.MediaPanel.Name = "MediaPanel";
            this.MediaPanel.Size = new System.Drawing.Size(800, 83);
            this.MediaPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ImageViewerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MediaPanel);
            this.Controls.Add(this.ImageViewer);
            this.Name = "ImageViewerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageViewerPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewer)).EndInit();
            this.MediaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageViewer;
        private System.Windows.Forms.FlowLayoutPanel MediaPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}