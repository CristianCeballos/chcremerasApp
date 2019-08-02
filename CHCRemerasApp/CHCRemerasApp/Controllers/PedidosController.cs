using CHCRemerasApp.Models;
using CHCRemerasApp.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace CHCRemerasApp.Controllers
{
    public class PedidosController : Controller
    {
        // GET: Pedidos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarPedidos()
        {
            PedidosViewModel vm = new PedidosViewModel();
            vm.pedidosVer = new GestorPedidos().mostrarPedidos();
            
            return View(vm);
        }

        public ActionResult NuevoPedido()
        {
            PedidosViewModel vm = new PedidosViewModel();
            vm.pedido = new Pedido();
            
            vm.listaRemerasVer = new GestorRemeras().mostrarRemeras();
            vm.listaClientes = new GestorClientes().mostrarClientes();
            vm.ListaEstados = new GestorEstados().mostrarEstados();
            vm.listaVendedores = new GestorPedidos().mostrarVendedores();
            vm.pedidosVer = new GestorPedidos().mostrarPedidos();


            return View(vm);

        }


        [HttpPost]
        public ActionResult AgregarDetalles(DetallePedido detalles)
        {
            //Pedido pedido = pedidoDetalles.pedido;
            //Detalle[] det = detalles;

            int nro = 0;
            Pedido pedido = new Pedido();
            

            var Array = detalles.values;

            pedido.id_cliente = Array[0].id_vendedor;
            pedido.id_vendedor = 1;
            pedido.descuento = 0;

            nro = new GestorPedidos().AgregarPedido(pedido);

            foreach (Detalle d in Array)
            {

                new GestorPedidos().AgregarDetalles(d,nro);
            }

            PedidosViewModel vm = new PedidosViewModel();

            vm.pedidosVer = new GestorPedidos().mostrarPedidos();
            vm.ultimo = nro;

            return Json(new { data = true });

            //return View("MostrarPedidos", vm);

        }


        public ActionResult ProcesosPedidos(int id)
        {
            PedidosViewModel vm = new PedidosViewModel();
            vm.listaItems = new GestorPedidos().mostrarItems(id);
            vm.listaItemsLista = new GestorPedidos().mostrarItemsLista();
            vm.pedidoVer = new GestorPedidos().Pedido(id);

            return View(vm);
        }

        [HttpPost]
        public ActionResult ProcesosPedidos(PedidosViewModel vm)
        {

            int cod = 0;
            cod = vm.pedidoVer.cod_pedido;

            if (ModelState.IsValid)
            {


                    int cod_ped = vm.pedidoVer.cod_pedido;
                    int id_item = vm.proceso.id_item;
                    string observaciones = vm.proceso.observaciones;
                    Proceso p = new Proceso(cod_ped, id_item, observaciones);
                    new GestorPedidos().AgregarProcesos(p);
                    vm.listaItems = new GestorPedidos().mostrarItems(cod_ped);
                    vm.listaItemsLista = new GestorPedidos().mostrarItemsLista();
                    vm.pedidoVer = new GestorPedidos().Pedido(cod_ped);


                    return View("ProcesosPedidos", vm);

            }
            else
            {

                vm.listaItems = new GestorPedidos().mostrarItems(cod);
                vm.listaItemsLista = new GestorPedidos().mostrarItemsLista();
                vm.pedidoVer = new GestorPedidos().Pedido(cod);


                return View("ProcesosPedidos", vm);

            }



        }



        public ActionResult DetallePedidos(int id)
        {
            PedidosViewModel vm = new PedidosViewModel();
            vm.listaDetallesVer = new GestorPedidos().mostrarDetalles(id);
            vm.pedidoVer = new GestorPedidos().Pedido(id);

            return View(vm);
        }


        //[HttpPost]
        //public ActionResult AgregarDetalles(DetallePedido detalles)
        //{
        //    var Array = detalles.values;

        //    foreach (Detalle d in Array)
        //    {
        //        new GestorPedidos().AgregarDetalles(d);
        //    }

        //    PedidosViewModel vm = new PedidosViewModel();
        //    vm.pedidosVer = new GestorPedidos().mostrarPedidos();

        //    return Json(new { data = true });
        //    //return View("MostrarPedidos", vm);

        //}

        //public ActionResult AgregarDetalles()
        //{
        //    PedidosViewModel vm = new PedidosViewModel();
        //    vm.pedidosVer = new GestorPedidos().mostrarPedidos();

        //    return View("MostrarPedidos",vm);

        //}




    }
}