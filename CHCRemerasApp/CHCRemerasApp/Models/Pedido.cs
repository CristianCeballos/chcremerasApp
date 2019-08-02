using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class Pedido
    {
        public int cod_pedido { set; get; }
        public DateTime fecha { set; get; }
        public int id_cliente { set; get; }
        public int id_vendedor { set; get; }
        public float preFinal { set; get; }
        public int descuento { set; get; }
        public int id_estado { set; get; }

        public Pedido() { }

        public Pedido(int cod,DateTime fec, int clien, int vend, float pre, int des, int est)
        {
            cod_pedido = cod;
            fecha = fec;id_cliente = clien;
            id_vendedor = vend;
            preFinal = pre;
            descuento = des;
            id_estado = est;

        }

    }
}