using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class Estado
    {
        public int id_estado { set; get; }
        public string descripcion { set; get; }

        public Estado(int id, string des)
        {
            id_estado = id;
            descripcion = des;
        }
        public Estado() { }
    }
}