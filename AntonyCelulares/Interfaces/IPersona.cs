using System;
using System.Collections.Generic;
using System.Text;

namespace AntonyCelulares.Interfaces
{
    public interface IPersona
    {
        public Guid Id { get; set; }
        public string Nombre { set; get; }
        public string Apeliido { set; get; }
        public string Documento { set; get; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
