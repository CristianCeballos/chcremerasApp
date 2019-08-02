using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class GestorEstadisticas
    {
        string cadena = "Data Source=DESKTOP-69T3JGA;Initial Catalog=CHCRemerasBaseDatos;User ID=sa;Password=homero2011";

        public float totalVendido()
        {
            float total = 0f;
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("exec totalVendido", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                total = (float)dr.GetDouble(0);
            }

            conn.Close();
            return total;

        }

        public List<Estadisticas> cantidadCiudades()
        {

            List<Estadisticas> salida = new List<Estadisticas>();
            int total = 0;
            string ciudad = "";
            
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("exec topCiudades", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                ciudad = dr.GetString(0);
                total = dr.GetInt32(1);

                Estadisticas est = new Estadisticas();
                est.ciudad = ciudad;
                est.cantidad_ciudades = total;

                salida.Add(est);

            }

            conn.Close();
            return salida;

        }

        public List<Estadisticas> cantidadClientes()
        {

            List<Estadisticas> salida = new List<Estadisticas>();
            int total = 0;
            float importe = 0f;
            string cliente = "";

            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("exec topClientes", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                cliente = dr.GetString(0);
                total = dr.GetInt32(1);
                importe = (float)dr.GetDouble(2);

                Estadisticas est = new Estadisticas();
                est.cliente = cliente;
                est.cant_por_cliente = total;
                est.precio_por_cliente = importe;

                salida.Add(est);

            }

            conn.Close();
            return salida;

        }
    }
}