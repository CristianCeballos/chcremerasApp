using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class Remera
    {
     

        public int id_remera { set; get; }
        public string titulo_remera { set; get; }
        public int id_talle { set; get; }
        public int id_color { set; get; }
        public int id_tipo { set; get; }
        public string imagen { set; get; }
        public float precio { set; get; }
        public int id_estado { set; get; }

        public Remera() { }

        public Remera(int id, string tit, int talle, int color, int tipo, string im, float pre, int est)
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