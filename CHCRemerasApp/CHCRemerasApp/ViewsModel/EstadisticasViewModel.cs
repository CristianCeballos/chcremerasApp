using CHCRemerasApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.ViewsModel
{
    public class EstadisticasViewModel
    {
        public float total_vendido { set; get; }
        public List<Estadisticas> estadisticas { set; get; }
        public List<Estadisticas> por_cliente { set; get; }
    }
}