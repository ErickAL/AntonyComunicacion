using AntonyCelulares.Interfaces;
using System;

namespace AntonyCelulares.Data.Entities
{
    public class Usuario : IUsuario
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apeliido { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
