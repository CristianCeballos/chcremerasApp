using CHCRemerasApp.Models;
using CHCRemerasApp.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHCRemerasApp.Controllers
{
    public class DiseñosController : Controller
    {
        // GET: Diseños
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarDiseños()
        {
            DiseñosViewModel vm = new DiseñosViewModel();
            vm.listaDiseños = new GestorDiseños().mostrarDiseños();

            return View(vm);
        }
    }
}