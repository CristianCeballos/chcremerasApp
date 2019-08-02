using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class GestorDiseños
    {
        string cadena = "Data Source=DESKTOP-69T3JGA;Initial Catalog=CHCRemerasBaseDatos;User ID=sa;Password=homero2011";

        public List<Diseños> mostrarDiseños()
        {
            List<Diseños> salida = new List<Diseños>();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("exec DiseñosVer", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string des = dr.GetString(1);
                string url = dr.GetString(2);
                string cat = dr.GetString(3);


                Diseños dis = new Diseños(id, des,url,cat);
                salida.Add(dis);
            }

            conn.Close();
            return salida;

        }
    }
}