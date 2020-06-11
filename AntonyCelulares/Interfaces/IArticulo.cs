using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AntonyCelulares.Interfaces
{
    public interface IArticulo
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<ICaracteristica> Caracteristicas { get; set; }

    }
}
