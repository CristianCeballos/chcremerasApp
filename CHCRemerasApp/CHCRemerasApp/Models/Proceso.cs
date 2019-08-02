using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class Proceso
    {
        public int nro_pedido { set; get; }
        public int id_item { set; get; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string observaciones { set; get; }
        

        public DateTime fecha { set; get; }

        public Proceso() { }

        public Proceso(int nro_ped, int id_it, string obs, DateTime fe)
        {
            this.nro_pedido = nro_ped;
            this.id_item = id_it;
            this.observaciones = obs;
            this.fecha = fe;

                
        }

        public Proceso(int nro_ped, int id_it, string obs)
        {
            this.nro_pedido = nro_ped;
            this.id_item = id_it;
            this.observaciones = obs;


        }
    }
}