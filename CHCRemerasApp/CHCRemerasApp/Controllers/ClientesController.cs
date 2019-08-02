using CHCRemerasApp.Models;
using CHCRemerasApp.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHCRemerasApp.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarClientes()
        {
            ClientesViewModel vm = new ClientesViewModel();
            vm.listaClientes = new GestorClientes().mostrarClientes();

            return View(vm);
        }

        public ActionResult NuevoCliente()
        {
            ClientesViewModel vm = new ClientesViewModel();
            vm.listaSexos = new GestorClientes().mostrarSexos();
            vm.listaCiudades = new GestorClientes().mostrarCiudades();
            vm.listaEstados = new GestorEstados().mostrarEstados();



            return View(vm);
        }

        [HttpPost]
        public ActionResult NuevoCliente(Cliente cliente)
        {

            int bandera = 1;

            if (ModelState.IsValid)
            {
                ClientesViewModel vm = new ClientesViewModel();
                new GestorClientes().AgregarCliente(cliente);
                vm.listaClientes = new GestorClientes().mostrarClientes();
                return View("MostrarClientes", vm);
            }
            else {
                ClientesViewModel vm = new ClientesViewModel();
                vm.listaSexos = new GestorClientes().mostrarSexos();
                vm.listaCiudades = new GestorClientes().mostrarCiudades();
                vm.listaEstados = new GestorEstados().mostrarEstados();
                vm.bandera = bandera;

                return View(vm);
            }

        }



        public ActionResult EditarCliente(int id)
        {
            ClientesViewModel vm = new ClientesViewModel();

            vm.listaCiudades = new GestorClientes().mostrarCiudades();
            vm.listaSexos = new GestorClientes().mostrarSexos();
            vm.listaEstados = new GestorEstados().mostrarEstados();
            vm.cliente = new GestorClientes().EditarClienteVer(id);

            return View(vm);
        }



        [HttpPost]
        public ActionResult EditarCliente(ClientesViewModel rvm)
        {
            new GestorClientes().EditarCliente(rvm.cliente);
            ClientesViewModel vm = new ClientesViewModel();
            vm.listaClientes = new GestorClientes().mostrarClientes();

            return View("MostrarClientes", vm);

        }
    }
}