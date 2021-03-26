using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public String Nombre { get; set; }
        public int edad{ get; set; }
        public String NumeroTelefono { get; set; }
        public String DUI { get; set; }
        public String Direccion { get; set; }
    }
}