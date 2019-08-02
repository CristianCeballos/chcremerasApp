using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class Diseños
    {
        public int id_diseño { set; get; }
        public string descripcion { set; get; }
        public string url_imagen { set; get; }
        public string categoria { set; get; }

        public Diseños(int id, string des, string url, string cat)
        {
            id_diseño = id;
            descripcion = des;
            url_imagen = url;
            categoria = cat;
        }

        public Diseños() { }
    }
}