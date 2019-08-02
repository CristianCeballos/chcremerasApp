using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class RemerasVer
    {

        public int id_remera { set; get; }
        public string titulo_remera { set; get; }
        public string id_talle { set; get; }
        public string id_color { set; get; }
        public string id_tipo { set; get; }
        public string imagen { set; get; }
        public double precio { set; get; }
        public string id_estado { set; get; }

        public RemerasVer() { }

        public RemerasVer(int id, string tit, string talle, string color, string tipo, string im, double pre, string est)
        {
            id_remera = id;
            titulo_remera = tit;
            id_talle = talle;
            id_color = color;
            id_tipo = tipo;
            imagen = im;
            precio = pre;
            id_estado = est;
        }
    }
}