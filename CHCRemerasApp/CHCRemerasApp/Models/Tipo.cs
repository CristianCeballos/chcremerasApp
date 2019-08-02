using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class Tipo
    {
        public int id_tipo { set; get; }
        public string descripcion { set; get; }

        public Tipo(int id, string des)
        {
            id_tipo = id;
            descripcion = des;
        }

        public Tipo() { }
    }
}