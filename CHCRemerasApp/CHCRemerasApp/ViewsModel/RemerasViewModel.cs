using CHCRemerasApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.ViewsModel
{
    public class RemerasViewModel
    {
        public List<Talle> listaTalles { set; get; }
        public List<Color> listaColores { set; get; }
        public List<Tipo> listaTipo { set; get; }
        public Remera remera { set; get; }
        public List<Estado> listaEstados { set; get; }
        public List<Remera> listaRemeras { set; get; }
        public List<RemerasVer> listaRemerasVer { set; get; }

    }
}