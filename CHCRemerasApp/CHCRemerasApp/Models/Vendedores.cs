using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class Vendedores
    {
        public int id_vendedor { set; get; }
        public string nombre { set; get; }

        public Vendedores(int id, string des)
        {
            id_vendedor = id;
            nombre = des;
        }

        public Vendedores() { }
    }
}