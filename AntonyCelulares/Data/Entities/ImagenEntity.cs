using System;
using System.Collections.Generic;
using System.Text;

namespace AntonyCelulares.Data.Entities
{
    public class ImagenEntity
    {        
        public int Id { get; set; }
        public string Title { get; set; }
        public byte[] Data { get; set; }
    }
}
