using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class GestorClientes
    {
        string cadena = "Data Source=DESKTOP-69T3JGA;Initial Catalog=CHCRemerasBaseDatos;User ID=sa;Password=homero2011";

        public List<ClientesVer> mostrarClientes()
        {
            List<ClientesVer> salida = new List<ClientesVer>();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("exec ClientesVer", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id_cliente = dr.GetInt32(0);
                string nombre = dr.GetString(1);
                string nombre_usuario = dr.GetString(2);
                int edad = dr.GetInt32(3);
                string sexo = dr.GetString(4);
                string ciudad = dr.GetString(5);
                string mail = dr.GetString(6);
                string telefono = dr.GetString(7);
                string id_estado = dr.GetString(8);

                ClientesVer c = new ClientesVer(id_cliente, nombre, nombre_usuario, edad, sexo, ciudad, mail, telefono, id_estado);
                salida.Add(c);
            }

            conn.Close();
            return salida;

        }

        public List<Sexo> mostrarSexos()
        {
            List<Sexo> salida = new List<Sexo>();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("select * from Sexos", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id_sexo = dr.GetInt32(0);
                string descripcion = dr.GetString(1);


                Sexo s = new Sexo(id_sexo, descripcion);
                salida.Add(s);
            }

            conn.Close();
            return salida;

        }

        public List<Ciudades> mostrarCiudades()
        {
            List<Ciudades> salida = new List<Ciudades>();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("select * from Ciudades", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id_ciudad = dr.GetInt32(0);
                string nombre = dr.GetString(1);


                Ciudades c = new Ciudades(id_ciudad, nombre);
                salida.Add(c);
            }

            conn.Close();
            return salida;

        }

        public void AgregarCliente(Cliente cliente)
        {
            

            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("insert into Clientes(nombre, nombre_usuario, edad, id_sexo, id_ciudad, mail, telefono, id_estado) values(@nombre, @nombre_usuario, @edad, @sexo, @id_ciudad, @mail, @telefono, @id_estado)", conn);

            comm.Parameters.Add(new SqlParameter("@nombre", cliente.nombre));
            comm.Parameters.Add(new SqlParameter("@nombre_usuario", cliente.nombre_usuario));
            comm.Parameters.Add(new SqlParameter("@edad", cliente.edad));
            comm.Parameters.Add(new SqlParameter("@sexo", cliente.sexo));
            comm.Parameters.Add(new SqlParameter("@id_ciudad", cliente.id_ciudad));
            comm.Parameters.Add(new SqlParameter("@mail", cliente.email));
            comm.Parameters.Add(new SqlParameter("@telefono", cliente.telefono));
            comm.Parameters.Add(new SqlParameter("@id_estado", cliente.id_estado));

            comm.ExecuteNonQuery();

            conn.Close();
          

        }

        public Cliente EditarClienteVer(int id)
        {
            Cliente salida = new Cliente();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("select * from clientes where id_cliente= " + id, conn);

            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id_cliente = dr.GetInt32(0);
                string nombre = dr.GetString(1);
                string nombre_usuario = dr.GetString(2);
                int edad = dr.GetInt32(3);
                int sexo = dr.GetInt32(4);
                int id_ciudad = dr.GetInt32(5);
                string mail = dr.GetString(6);
                string telefono = dr.GetString(7);
                int id_estado = dr.GetInt32(8);

                salida = new Cliente(id_cliente, nombre, nombre_usuario, edad, sexo, id_ciudad, mail, telefono, id_estado);

            }

            conn.Close();
            return salida;
        }

        public void EditarCliente(Cliente c)
        {
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("update Clientes set nombre = @nombre, nombre_usuario = @nombre_usuario, edad = @edad, id_sexo = @sexo, id_ciudad = @id_ciudad,  mail = @mail,  telefono = @telefono, id_estado = @id_estado where id_cliente = @id_cliente", conn);
            comm.Parameters.Add(new SqlParameter("@id_cliente", c.id_cliente));
            comm.Parameters.Add(new SqlParameter("@nombre", c.nombre));
            comm.Parameters.Add(new SqlParameter("@nombre_usuario", c.nombre_usuario));
            comm.Parameters.Add(new SqlParameter("@edad", c.edad));
            comm.Parameters.Add(new SqlParameter("@sexo", c.sexo));
            comm.Parameters.Add(new SqlParameter("@id_ciudad", c.id_ciudad));
            comm.Parameters.Add(new SqlParameter("@mail", c.email));
            comm.Parameters.Add(new SqlParameter("@telefono", c.telefono));
            comm.Parameters.Add(new SqlParameter("@id_estado", c.id_estado));

            comm.ExecuteNonQuery();
            conn.Close();
        }

    }
}