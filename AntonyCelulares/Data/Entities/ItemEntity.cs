using AntonyCelulares.Interfaces;
using AntonyCelulares.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AntonyCelulares.Data.Entities
{
    public class ItemEntity 
    {
        public Guid Id { get ; set;}
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public ICollection<ImagenEntity> Imagenes { get; set; }
        public ICollection<CharacteristicEntity> Caracteristicas { get; set; }
    }
}
