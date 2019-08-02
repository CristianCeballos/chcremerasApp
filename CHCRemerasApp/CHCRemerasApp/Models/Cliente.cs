using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class Cliente
    {

        [Required(ErrorMessage = "Campo obligatorio")]
        public int id_cliente { set; get; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string nombre { set; get; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string nombre_usuario { set; get; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public int edad { set; get; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public int sexo { set; get; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public int id_ciudad { set; get; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string email { set; get; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string telefono { set; get; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public int id_estado { set; get; }

        public Cliente() { }

        public Cliente(int id, string nom, string nom_usser, int ed, int sex, int ciud, string mail, string tel, int est)
        {
            id_cliente = id;
            nombre = nom;
            nombre_usuario = nom_usser;
            edad = ed;
            sexo = sex;
            id_ciudad = ciud;
            email = mail;
            telefono = tel;
            id_estado = est;

        }

    }
}