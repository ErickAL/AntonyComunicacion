using System;
using System.Collections.Generic;
using System.Text;

namespace AntonyCelulares.Models
{
    public class Result
    {
        public bool IsSuccess { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
    }
}
