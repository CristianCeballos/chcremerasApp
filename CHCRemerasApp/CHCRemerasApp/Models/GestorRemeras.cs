using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class GestorRemeras
    {
        string cadena = "Data Source=DESKTOP-69T3JGA;Initial Catalog=CHCRemerasBaseDatos;User ID=sa;Password=homero2011";

        public List<RemerasVer> mostrarRemeras()
        {
            List<RemerasVer> salida = new List<RemerasVer>();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("exec RemerasVer", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int nro_rem = dr.GetInt32(0);
                string titulo = dr.GetString(1);
                string id_talle = dr.GetString(2);
                string id_color = dr.GetString(3);
                string id_tipo = dr.GetString(4);
                string imagen = dr.GetString(5);
                double precio = dr.GetDouble(6);
                string id_estado = dr.GetString(7);

                RemerasVer r = new RemerasVer(nro_rem, titulo, id_talle, id_color, id_tipo, imagen, precio, id_estado);
                salida.Add(r);
            }

            conn.Close();
            return salida;

        }

        public List<Talle> mostrarTalles()
        {
            List<Talle> salida = new List<Talle>();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("select * from Talles", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string des = dr.GetString(1);


                Talle tall = new Talle(id, des);
                salida.Add(tall);
            }

            conn.Close();
            return salida;

        }

        public List<Color> mostrarColores()
        {
            List<Color> salida = new List<Color>();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("select * from Colores", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string des = dr.GetString(1);


                Color col = new Color(id, des);
                salida.Add(col);
            }

            conn.Close();
            return salida;

        }

        public List<Tipo> mostrarTipos()
        {
            List<Tipo> salida = new List<Tipo>();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("select * from Tipo", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string des = dr.GetString(1);


                Tipo tip = new Tipo(id, des);
                salida.Add(tip);
            }

            conn.Close();
            return salida;

        }

        public void AgregarRemera(Remera remera)
        {


            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("insert into Remeras(titulo_remera, id_talle, id_color, id_tipo, imagen, precio, id_estado) values(@titulo_remera, @id_talle, @id_color, @id_tipo, @imagen, @precio,@id_estado)", conn);

            comm.Parameters.Add(new SqlParameter("@titulo_remera", remera.titulo_remera));
            comm.Parameters.Add(new SqlParameter("@id_talle", remera.id_talle));
            comm.Parameters.Add(new SqlParameter("@id_color", remera.id_color));
            comm.Parameters.Add(new SqlParameter("@id_tipo", remera.id_tipo));
            comm.Parameters.Add(new SqlParameter("@imagen", remera.imagen));
            comm.Parameters.Add(new SqlParameter("@precio", remera.precio));
            comm.Parameters.Add(new SqlParameter("@id_estado", remera.id_estado));

            comm.ExecuteNonQuery();

            conn.Close();


        }

        public Remera EditarRemeraVer(int id)
        {
            Remera salida = new Remera();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("select * from remeras where id_remera= " + id, conn);

            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int nro_rem = dr.GetInt32(0);
                string titulo = dr.GetString(1);
                int id_talle = dr.GetInt32(2);
                int id_color = dr.GetInt32(3);
                int id_tipo = dr.GetInt32(4);
                string imagen = dr.GetString(5);
                float precio = (float)dr.GetDouble(6);
                int id_estado = dr.GetInt32(7);

                salida = new Remera(nro_rem, titulo, id_talle, id_color, id_tipo, imagen, precio, id_estado);
                
            }

            conn.Close();
            return salida;
        }

        public void EditarRemera(Remera r)
        {
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("update Remeras set titulo_remera = @titulo_remera, id_talle = @id_talle, id_color = @id_color, id_tipo = @id_tipo, imagen = @imagen, precio = @precio, id_estado = @id_estado where id_remera = @id", conn);
            comm.Parameters.Add(new SqlParameter("@titulo_remera", r.titulo_remera));
            comm.Parameters.Add(new SqlParameter("@id_talle", r.id_talle));
            comm.Parameters.Add(new SqlParameter("@id_color", r.id_color));
            comm.Parameters.Add(new SqlParameter("@id_tipo", r.id_tipo));
            comm.Parameters.Add(new SqlParameter("@imagen", r.imagen));
            comm.Parameters.Add(new SqlParameter("@precio", r.precio));
            comm.Parameters.Add(new SqlParameter("@id_estado", r.id_estado));
            comm.Parameters.Add(new SqlParameter("@id", r.id_remera));

            comm.ExecuteNonQuery();
            conn.Close();
        }


    }
}