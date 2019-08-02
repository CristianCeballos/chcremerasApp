using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class DetallesVer
    {
        public int id_detalle { set; get; }
        public int id_pedido { set; get; }
        public int id_remera { set; get; }
        public string imagen { set; get; }
        public string descripcion_remera { set; get; }
        public int cantidad { set; get; }
        public double monto_parcial { set; get; }

        public DetallesVer() { }

        public DetallesVer(int id_det,int ped, int id_rem, string ima, string rem, int cant, double pre)
        {
            id_detalle = id_det;
            id_pedido = ped;
            id_remera = id_rem;
            descripcion_remera = rem;
            cantidad = cant;
            monto_parcial = pre;
            imagen = ima;
        }
    }
}