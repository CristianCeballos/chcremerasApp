using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class Talle
    {
        public int id_talle { set; get; }
        public string descripcion { set; get; }

        public Talle(int id, string des)
        {
            id_talle = id;
            descripcion = des;
        }

        public Talle() { }
    }
}