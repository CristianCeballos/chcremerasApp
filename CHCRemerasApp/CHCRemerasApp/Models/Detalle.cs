using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class Detalle
    {
        public int nro_pedido { set; get; }
        public int id_remera { set; get; }
        public int cantidad { set; get; }
        public double subtotal { set; get; }
        public int id_vendedor { set; get; }
        public int nro_cliente { set; get; }

        public Detalle() { }

        public Detalle(int ped, int rem, int cant, double pre, int ven, int clie)
        {
            nro_pedido = ped;
            id_remera = rem;
            cantidad = cant;
            subtotal = pre;
            id_vendedor = ven;
            nro_cliente = clie;


        }

        
    }

    public class DetallePedido
    {
        public Detalle[] values { set; get; }
    }
}