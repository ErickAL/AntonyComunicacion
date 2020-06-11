using AntonyCelulares.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AntonyCelulares.Interfaces
{
    public interface IUsuario: IPersona
    {
        public string Username { get; set; }
        public string  Password { get; set; }
        public UserType  UserType { get; set; }
    }
}
