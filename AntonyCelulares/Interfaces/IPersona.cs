using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AntonyCelulares.Interfaces
{
    public interface IPersona
    {
        public  Guid Id { get; set; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Email { get; set; }
        public Image Avatar { set; get; }
        public string Documento { set; get; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        
    }
}
