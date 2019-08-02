using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class Item
    {
        public int id_item { set; get; }
        public string codigo { set; get; }
        public string descripcion { set; get; }
        public DateTime fecha { set; get; }
        public int id_estado { set; get; }
        public string observaciones { set; get; }

        public Item() { }

        public Item(int id, string cod, string des, DateTime fe, int estado, string obs)
        {
            this.id_item = id;
            this.codigo = cod;
            this.descripcion = des;
            this.fecha = fe;
            this.id_estado = estado;
            this.observaciones = obs;
        }

        public Item(int id, string cod, string des, DateTime fe, int estado)
        {
            this.id_item = id;
            this.codigo = cod;
            this.descripcion = des;
            this.fecha = fe;
            this.id_estado = estado;
           
        }

        public Item(int id, string cod, string des, int estado)
        {
            this.id_item = id;
            this.codigo = cod;
            this.descripcion = des;

            this.id_estado = estado;

        }
    }
}