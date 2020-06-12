using AntonyCelulares.Data.Entities;
using AntonyCelulares.Enums;
using AntonyCelulares.Interfaces;
using AntonyCelulares.Views.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AntonyCelulares.Views.Account
{
    public partial class RegisterUsuarioPage : Form, IUsuario
    {
       
        
        #region Properties
        private bool IsUpdating { get; set; }
        public string Email
        {
            get => txtEmail.Text;
            set => txtEmail.Text = value;
        }
        public string Username
        {
            get => txtUsername.Text;
            set => txtUsername.Text = value;
        }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public string Nombre { get => txtNombre.Text; set => txtNombre.Text = value; }
        public string Apellido { get => txtApellido.Text; set => txtApellido.Text = value; }
        public string Documento { get => txtDocument.Text; set => txtDocument.Text = value; }
        public string Direccion { get => txtDireccion.Text; set => txtDireccion.Text = value; }
        public string Telefono { get => txtTelefono.Text; set => txtTelefono.Text = value; }

        public UserType UserType
        {
            get => (UserType)cbUserTypes.SelectedIndex;
            set => cbUserTypes.SelectedIndex = (int)value;
        }
        public Image Avatar { get => pbAvatar.Image; set => pbAvatar.Image = value; }
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion
        #region Contructors
        public RegisterUsuarioPage()
        {
            InitializeComponent();
            IsUpdating = false;
        }
        public RegisterUsuarioPage(UserEntity user)
        {
            InitializeComponent();
            IsUpdating = true;


        }

        #endregion

        #region Methods

        private  void btnSearchImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                Avatar = Bitmap.FromFile(openFileDialog.FileName);
               if(openFileDialog.FileNames.Length>1)
                 {

                     List<Image> images = new List<Image>();
                     foreach (var item in openFileDialog.FileNames)
                     {
                         images.Add(Bitmap.FromFile(item));
                     }

                     var imageViewer = new ImageViewerPage(images);
                     imageViewer.Show();

                 }
            }
        }
        private void pbAvatar_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox.Image != null)
            {
                ImageViewerPage imageViewer = new ImageViewerPage(pictureBox.Image);
                imageViewer.Show();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
