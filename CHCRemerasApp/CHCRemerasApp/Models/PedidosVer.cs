using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class PedidosVer
    {
        public int cod_pedido { set; get; }
        public DateTime fecha { set; get; }
        public string nombre_cliente { set; get; }
        public string vendedor { set; get; }
        public float preFinal { set; get; }
        public int descuento { set; get; }
        public string descripcion_estado { set; get; }

        public PedidosVer() { }

        public PedidosVer(int cod, DateTime fec, string clien, string vend, float pre, int des, string est)
        {
            cod_pedido = cod;
            fecha = fec;
            nombre_cliente = clien;
            vendedor = vend;
            preFinal = pre;
            descuento = des;
            descripcion_estado = est;

        }
    }
}