using AntonyCelulares.Controllers;
using AntonyCelulares.Data.Entities;
using AntonyCelulares.Enums;
using AntonyCelulares.Helpers;
using AntonyCelulares.Interfaces;
using AntonyCelulares.Views.Shared;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AntonyCelulares.Views.Account
{
    public partial class RegisterUsuarioPage : Form, IUsuario
    {



        #region Properties   
        private bool IsUpdating { get; set; }
        public Guid Id { get; set; }
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
        private ImagenEntity _imagenEntity;

        public ImagenEntity ImagenEntity
        {
            get => _imagenEntity ?? (_imagenEntity=new ImagenEntity { Data=ImageHelper.ImageToByteArray(Avatar) });
            set{
                _imagenEntity = value;
                Avatar=ImageHelper.ByteArrayToImage(value.Data);
            }
        }

        // public Image Avatar { get => pbAvatar.Image; set => pbAvatar.Image = value; }
        public Image Avatar
        {
            get => pbAvatar.Image;
            set
            { 
                pbAvatar.Image = value;
                ImagenEntity.Data = ImageHelper.ImageToByteArray(value);
            }
        }

        private UserEntity _user;

        public UserEntity User
        {
            get => _user ?? (_user = new UserEntity
            {
                Apellido = Apellido,
                // Avatar = new ImagenEntity { Data = ImageHelper.ImageToByteArray(Avatar) },
                Direccion = Direccion,
                Documento = Documento,
                Email = Email,
                Id = Id,
                Nombre = Nombre,
                Password = Password,
                Telefono = Telefono,
                Username = Username,
                UserType = UserType,
            });
            set
            {
                _user = value;
                Apellido = value.Apellido;
                //Avatar = value.Avatar ,
                Direccion = value.Direccion;
                Documento = value.Documento;
                Email = value.Email;
                Id = value.Id;
                Nombre = value.Nombre;
                Password = value.Password;
                Telefono = value.Telefono;
                Username = value.Username;
                UserType = value.UserType;
            }
        }





        #endregion
        #region Contructors
        public RegisterUsuarioPage()
        {
            InitializeComponent();
            Id = Guid.Empty;
            IsUpdating = false;
        }
        public RegisterUsuarioPage(
            UserEntity user)
        {
            InitializeComponent();
            User = user;
            IsUpdating = true;


        }

        #endregion

        #region Methods

        private void btnSearchImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                Avatar = Bitmap.FromFile(openFileDialog.FileName);

                if (openFileDialog.FileNames.Length > 1)
                {

                    List<Image> images = new List<Image>();
                    foreach (string item in openFileDialog.FileNames)
                    {
                        images.Add(Bitmap.FromFile(item));
                    }

                    ImageViewerPage imageViewer = new ImageViewerPage(images);
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
