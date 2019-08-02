using CHCRemerasApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.ViewsModel
{
    public class ClientesViewModel
    {
        public List<ClientesVer> listaClientes { set; get; }
        public Cliente cliente { set; get; }
        public List<Sexo> listaSexos { set; get; }
        public List<Ciudades> listaCiudades { set; get; }
        public List<Estado> listaEstados { set; get; }
        public int bandera { set; get; }

    }
}