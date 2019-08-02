using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class Sexo
    {
        public int id_sexo { set; get; }
        public string descripcion { set; get; }

        public Sexo(int id, string des)
        {
            id_sexo = id;
            descripcion = des;
        }

        public Sexo() { }
    }
}