using System;
using System.Collections.Generic;

namespace AntonyCelulares.Interfaces
{
    public interface ICaracteristica
    {
        public Guid Id { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
        public ICollection<IArticulo>  Articulos { get; set; }
    }
}