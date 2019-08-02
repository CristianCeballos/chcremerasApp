using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class Color
    {
        public int id_color { set; get; }
        public string descripcion { set; get; }

        public Color(int id, string des)
        {
            id_color = id;
            descripcion = des;
        }

        public Color() { }
    }
}