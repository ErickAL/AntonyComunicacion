using AntonyCelulares.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AntonyCelulares.Interfaces
{
    public interface IUsuario: IPersona
    {
       
        public string Username { get; set; }
        public string  Password { get; set; }
        public UserType  Rol { get; set; }
    }
}
