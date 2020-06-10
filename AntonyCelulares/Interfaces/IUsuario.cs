using System;
using System.Collections.Generic;
using System.Text;

namespace AntonyCelulares.Interfaces
{
    public interface IUsuario: IPersona
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string  Password { get; set; }
    }
}
