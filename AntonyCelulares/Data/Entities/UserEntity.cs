using AntonyCelulares.Enums;
using AntonyCelulares.Interfaces;
using AntonyCelulares.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace AntonyCelulares.Data.Entities
{
    public class UserEntity //: IUsuario
    {
        [Key]
        public Guid Id { get; set; }
        public string Username { get; set; }
        public UserType UserType { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public ImagenEntity Avatar { get; set; }
        public string Email { get; set; }

    }
}
