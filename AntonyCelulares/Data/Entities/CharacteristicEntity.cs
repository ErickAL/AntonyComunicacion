using AntonyCelulares.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AntonyCelulares.Data.Entities
{
    public class CharacteristicEntity : ICaracteristica
    {
        public Guid Id { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
        public ICollection<IArticulo> Articulos { get; set; }
    }
}
