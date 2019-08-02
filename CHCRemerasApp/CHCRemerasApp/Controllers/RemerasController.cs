using CHCRemerasApp.Models;
using CHCRemerasApp.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHCRemerasApp.Controllers
{
    public class RemerasController : Controller
    {
        // GET: Remeras
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarRemeras()
        {
            RemerasViewModel vm = new RemerasViewModel();
            vm.listaRemerasVer = new GestorRemeras().mostrarRemeras();

            return View(vm);
        }

        public ActionResult NuevaRemera()
        {
            RemerasViewModel vm = new RemerasViewModel();
            vm.listaTalles = new GestorRemeras().mostrarTalles();
            vm.listaColores = new GestorRemeras().mostrarColores();
            vm.listaTipo = new GestorRemeras().mostrarTipos();
            vm.listaEstados = new GestorEstados().mostrarEstados();

            return View(vm);
        }

        [HttpPost]
        public ActionResult NuevaRemera(Remera remera)
        {
            RemerasViewModel vm = new RemerasViewModel();
            new GestorRemeras().AgregarRemera(remera);
            vm.listaRemerasVer = new GestorRemeras().mostrarRemeras();
            return View("MostrarRemeras", vm);

        }

        public ActionResult EditarRemera(int id)
        {
            RemerasViewModel vm = new RemerasViewModel();
            vm.listaTalles = new GestorRemeras().mostrarTalles();
            vm.listaColores = new GestorRemeras().mostrarColores();
            vm.listaTipo = new GestorRemeras().mostrarTipos();
            vm.listaEstados = new GestorEstados().mostrarEstados();
            vm.remera = new GestorRemeras().EditarRemeraVer(id);

            return View(vm);
        }



        [HttpPost]
        public ActionResult EditarRemera(RemerasViewModel rvm)
        {
            new GestorRemeras().EditarRemera(rvm.remera);
            RemerasViewModel vm = new RemerasViewModel();
            vm.listaRemerasVer = new GestorRemeras().mostrarRemeras();
            return View("MostrarRemeras", vm);

        }

    }
}