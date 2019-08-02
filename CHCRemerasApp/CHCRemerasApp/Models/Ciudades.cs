using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class Ciudades
    {
        public int id_ciudad { set; get; }
        public string nombre { set; get; }

        public Ciudades(int id, string nom)
        {
            id_ciudad = id;
            nombre = nom;
        }

        public Ciudades() { }
    }
}