using CHCRemerasApp.Models;
using CHCRemerasApp.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHCRemerasApp.Controllers
{
    public class EstadisticasController : Controller
    {
        // GET: Estadisticas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EstadisticasVer()
        {
            EstadisticasViewModel vm = new EstadisticasViewModel();
            vm.total_vendido = new GestorEstadisticas().totalVendido();
            vm.estadisticas = new GestorEstadisticas().cantidadCiudades();
            vm.por_cliente = new GestorEstadisticas().cantidadClientes();
            return View(vm);
        }
    }
}