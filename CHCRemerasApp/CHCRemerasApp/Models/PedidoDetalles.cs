using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class PedidoDetalles
    {

        public Pedido pedido { set; get; }
        public Detalle[] detalles { set; get; }

        public PedidoDetalles(Pedido p, Detalle[] d)
        {
            pedido = p;
            detalles = d;
        }

        public PedidoDetalles() { }

    }
}