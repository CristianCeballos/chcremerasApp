using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class Estadisticas
    {
        public float cantidad_vendida { set; get; }
        public string ciudad { set; get; }
        public int cantidad_ciudades { set; get; }

        public string cliente { set; get; }
        public int cant_por_cliente { set; get; }
        public float precio_por_cliente { set; get; }


        public Estadisticas(string ciu, int cant)
        {
            this.ciudad = ciu;
            this.cantidad_ciudades = cant;
        }


        public Estadisticas() { }
    }
}