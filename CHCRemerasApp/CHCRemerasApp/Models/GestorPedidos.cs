using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CHCRemerasApp.Models
{
    public class GestorPedidos
    {
        string cadena = "Data Source=DESKTOP-69T3JGA;Initial Catalog=CHCRemerasBaseDatos;User ID=sa;Password=homero2011";

        public List<PedidosVer> mostrarPedidos()
        {
            List<PedidosVer> salida = new List<PedidosVer>();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("execute PedidosVer", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int nro_pedido = dr.GetInt32(0);
                DateTime fecha = dr.GetDateTime(1);
                string id_cliente = dr.GetString(2);
                string vendedor = dr.GetString(3);
                
                int descuento = dr.GetInt32(4);
                string id_estado = dr.GetString(5);
                float precio = (float)dr.GetDouble(6);

                PedidosVer pv = new PedidosVer(nro_pedido,fecha, id_cliente, vendedor, precio, descuento, id_estado);
                salida.Add(pv);
            }

            conn.Close();
            return salida;

        }

        public List<DetallesVer> mostrarDetalles(int id)
        {
            List<DetallesVer> salida = new List<DetallesVer>();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("execute DetallesVer " + id, conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id_det= dr.GetInt32(0);
                int nro_ped = dr.GetInt32(1);
                int id_reme = dr.GetInt32(2);
                string imagen= dr.GetString(3);
                string reme = dr.GetString(4);
                int cant = dr.GetInt32(5);
                double pre = dr.GetDouble(6);

                DetallesVer d = new DetallesVer(id_det,nro_ped,id_reme,imagen, reme, cant, pre);
                salida.Add(d);
            }

            conn.Close();
            return salida;
        }

        public int AgregarPedido(Pedido pedido)
        {
            int idPedido = 0;
            int descuento = 0;

            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("insert into Pedidos(fecha, id_cliente, id_vendedor, id_estado, descuento) values(@fecha, @id_cliente, @vendedor, @id_estado, @descuento)", conn);

            comm.Parameters.Add(new SqlParameter("@fecha", DateTime.Today));
            comm.Parameters.Add(new SqlParameter("@id_cliente", pedido.id_cliente));
            comm.Parameters.Add(new SqlParameter("@vendedor", pedido.id_vendedor));
            comm.Parameters.Add(new SqlParameter("@id_estado", 1));
            comm.Parameters.Add(new SqlParameter("@descuento", descuento));

            comm.ExecuteNonQuery();

            comm = new SqlCommand("NumeroPedido", conn);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                idPedido  = dr.GetInt32(0);

            }

            conn.Close();


            return idPedido;

        }


        public void AgregarDetalles(Detalle detalle, int ultimo)
        {


            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

      

                SqlCommand comm = new SqlCommand("insert into DetallesPedidos(nro_pedido, id_remera, cantidad,precio) values(@nro_pedido, @id_remera,@cantidad,@subtotal)", conn);

                comm.Parameters.Add(new SqlParameter("@nro_pedido", ultimo));
                comm.Parameters.Add(new SqlParameter("@id_remera", detalle.id_remera));
                comm.Parameters.Add(new SqlParameter("@cantidad", detalle.cantidad));
                comm.Parameters.Add(new SqlParameter("@subtotal", detalle.subtotal));

                comm.ExecuteNonQuery();


           
            


            conn.Close();
         
        }


        public PedidosVer Pedido(int id)
        {
            PedidosVer p = new PedidosVer();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("exec PedidosDetallesPrecio " + id, conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int nro_pedido = dr.GetInt32(0);
                DateTime fecha = dr.GetDateTime(1);
                string id_cliente = dr.GetString(2);
                string vendedor = dr.GetString(3);
                int descuento = dr.GetInt32(4);
                string id_estado = dr.GetString(5);
                float precio = (float)dr.GetDouble(6);

                p = new PedidosVer(nro_pedido, fecha, id_cliente, vendedor, precio, descuento, id_estado);
                
            }

            conn.Close();
            return p;
        }


        public List<Vendedores> mostrarVendedores()
        {
            List<Vendedores> salida = new List<Vendedores>();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("select * from Vendedores", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string nom = dr.GetString(1);


                Vendedores ven = new Vendedores(id, nom);
                salida.Add(ven);
            }

            conn.Close();
            return salida;

        }

        public List<Item> mostrarItems(int id)
        {
            List<Item> salida = new List<Item>();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("execute ItemsPedidosVer " +id, conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id_item = dr.GetInt32(0);
                string codigo= dr.GetString(1);
                string descripcion = dr.GetString(2);
                DateTime fecha = dr.GetDateTime(3);
                int estado = dr.GetInt32(4);
                string obs = dr.GetString(5);



                Item item = new Item(id_item, codigo,descripcion,fecha,estado, obs);
                salida.Add(item);
            }

            conn.Close();
            return salida;

        }

        public List<Item> mostrarItemsLista()
        {
            List<Item> salida = new List<Item>();
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand comm = new SqlCommand("select * from Items", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while (dr.Read())
            {
                int id_item = dr.GetInt32(0);
                string codigo = dr.GetString(1);
                string descripcion = dr.GetString(2);
                //DateTime fecha = dr.GetDateTime(3);
                int estado = dr.GetInt32(3);
                



                Item item = new Item(id_item, codigo, descripcion, estado);
                salida.Add(item);
            }

            conn.Close();
            return salida;

        }

        public void AgregarProcesos(Proceso p)
        {


            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();



            SqlCommand comm = new SqlCommand("insert into Procesos(nro_pedido, id_item, fecha,observaciones) values(@nro_pedido, @id_item,@fecha,@observaciones)", conn);

            comm.Parameters.Add(new SqlParameter("@nro_pedido", p.nro_pedido));
            comm.Parameters.Add(new SqlParameter("@id_item", p.id_item));
            comm.Parameters.Add(new SqlParameter("@fecha", DateTime.Today));
            comm.Parameters.Add(new SqlParameter("@observaciones", p.observaciones));

            comm.ExecuteNonQuery();






            conn.Close();

        }






    }
}