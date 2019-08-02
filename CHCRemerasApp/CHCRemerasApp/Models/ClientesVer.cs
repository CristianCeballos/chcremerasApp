using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class ClientesVer
    {
        public int id_cliente { set; get; }
        public string nombre { set; get; }
        public string nombre_usuario { set; get; }
        public int edad { set; get; }
        public string sexo { set; get; }
        public string ciudad { set; get; }
        public string email { set; get; }
        public string telefono { set; get; }
        public string estado { set; get; }

        public ClientesVer() { }

        public ClientesVer(int id, string nom, string nom_usser, int ed, string sex, string ciud, string mail, string tel, string est)
        {
            id_cliente = id;
            nombre = nom;
            nombre_usuario = nom_usser;
            edad = ed;
            sexo = sex;
            ciudad = ciud;
            email = mail;
            telefono = tel;
            estado = est;

        }
    }
}