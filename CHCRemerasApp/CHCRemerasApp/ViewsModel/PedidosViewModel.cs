using CHCRemerasApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.ViewsModel
{
    public class PedidosViewModel
    {
        public List<Pedido> listaPedidos { set; get; }
        public List<Detalle> listaDetalles { set; get; }
        public Pedido pedido { set; get; }
        public PedidosVer pedidoVer { set; get; }
        public List<PedidosVer> pedidosVer { set; get; }
        public List<DetallesVer> listaDetallesVer { set; get; }
        public List<Remera> listaRemeras { set; get; }
        public Remera remera { set; get; }
        public Detalle detalle { set; get; }
        public List<ClientesVer> listaClientes { set; get; }
        public Cliente cliente{ set; get; }
        public List<Estado> ListaEstados { set; get; }
        public Estado estado { set; get; }
        public int ultimo { set; get; }
        public List<RemerasVer> listaRemerasVer { set; get; }
        public List<Vendedores> listaVendedores { set; get; }
        public List<Item> listaItems { set; get; }
        public Proceso proceso { set; get; }
        public List<Item> listaItemsLista { set; get; }
        public PedidoDetalles pedidoDetalles { set; get; }
    }
}