using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class GestorEstados
    {
        string cadena = "Data Source=DESKTOP-69T3JGA;Initial Catalog=CHCRemerasBaseDatos;User ID=sa;Password=homero2011";

        public List<Estado> mostrarEstados()
        {
            List<Estado> salida = new List<Estado>();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("select * from Estados", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string des = dr.GetString(1);
                

                Estado est = new Estado(id,des);
                salida.Add(est);
            }

            conn.Close();
            return salida;

        }

    }
}