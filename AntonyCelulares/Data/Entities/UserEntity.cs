using AntonyCelulares.Enums;
using AntonyCelulares.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Drawing;

namespace AntonyCelulares.Data.Entities
{
    public class UserEntity :  IdentityUser, IUsuario
    {
        public string Username { get; set; }
        public UserType UserType { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Image Avatar { get; set; }
    }
}
