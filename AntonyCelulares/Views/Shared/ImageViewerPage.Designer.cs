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
            this.MediaPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ImageViewer = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // MediaPanel
            // 
            this.MediaPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.MediaPanel.AllowDrop = true;
            this.MediaPanel.AutoScroll = true;
            this.MediaPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MediaPanel.BackColor = System.Drawing.Color.Transparent;
            this.MediaPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MediaPanel.Location = new System.Drawing.Point(0, 340);
            this.MediaPanel.Name = "MediaPanel";
            this.MediaPanel.Size = new System.Drawing.Size(800, 110);
            this.MediaPanel.TabIndex = 1;
            // 
            // ImageViewer
            // 
            this.ImageViewer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ImageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageViewer.Location = new System.Drawing.Point(0, 0);
            this.ImageViewer.Name = "ImageViewer";
            this.ImageViewer.Size = new System.Drawing.Size(800, 450);
            this.ImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageViewer.TabIndex = 0;
            this.ImageViewer.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoEllipsis = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.DarkViolet;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(741, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImageViewerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MediaPanel);
            this.Controls.Add(this.ImageViewer);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImageViewerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageViewerPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ImageViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageViewer;
        private System.Windows.Forms.FlowLayoutPanel MediaPanel;
        private System.Windows.Forms.Button button1;
    }
}