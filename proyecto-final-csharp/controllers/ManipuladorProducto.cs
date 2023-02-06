using proyecto_final_csharp.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_csharp.controllers
{
    public static class ManipuladorProducto
    {

        public static List<Producto> ObtenerProducto(long idUsuario)
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection conn = ConnectionHandler.ConnectToDb())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Producto WHERE IdUsuario=@idUsuario", conn);
                SqlParameter idParameter = new SqlParameter();
                idParameter.ParameterName = "idUsuario";
                idParameter.SqlDbType = SqlDbType.BigInt;
                idParameter.Value = idUsuario;

                command.Parameters.Add(idParameter);

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                
                if (reader.HasRows)
                {
                    
                    while (reader.Read())
                    {
                        Producto producto = new Producto();
                        producto.Id = reader.GetInt64(0);
                        producto.Descripciones = reader.GetString(1);
                        producto.Costo = reader.GetDecimal(2);
                        producto.PrecioVenta = reader.GetDecimal(3);
                        producto.Stock = reader.GetInt32(4);
                        producto.IdUsuario = reader.GetInt64(5);
                        productos.Add(producto);
                    }
                }
                return productos;
            }

        }

        public static Producto ObtenerProductoPorId(long id)
        {
            using (SqlConnection conn = ConnectionHandler.ConnectToDb())
            {
                Producto producto = new Producto();
                SqlCommand command = new SqlCommand("SELECT * FROM Producto WHERE Id=@id", conn);
                SqlParameter idParameter = new SqlParameter();
                idParameter.ParameterName = "id";
                idParameter.SqlDbType = SqlDbType.BigInt;
                idParameter.Value = id;

                command.Parameters.Add(idParameter);

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        producto.Id = reader.GetInt64(0);
                        producto.Descripciones = reader.GetString(1);
                        producto.Costo = reader.GetDecimal(2);
                        producto.PrecioVenta = reader.GetDecimal(3);
                        producto.Stock = reader.GetInt32(4);
                        producto.IdUsuario = reader.GetInt64(5);
                    }
                }

                return producto;
            }
        }

        public static List<Producto> ObtenerProductosVendidosPorUsuario(long idUsuario)
        {
            List<long> listaIdProductos = new List<long>();

            using (SqlConnection conn = ConnectionHandler.ConnectToDb())
            {
                Producto producto = new Producto();
                SqlCommand command = new SqlCommand("SELECT ProductoVendido.IdProducto FROM ProductoVendido INNER JOIN Venta ON Venta.Id = ProductoVendido.IdVenta WHERE Venta.IdUsuario = @idUsuario", conn);
                SqlParameter idParameter = new SqlParameter();
                idParameter.ParameterName = "idUsuario";
                idParameter.SqlDbType = SqlDbType.BigInt;
                idParameter.Value = idUsuario;

                command.Parameters.Add(idParameter);

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        listaIdProductos.Add(reader.GetInt64(0));
                    }
                }
            }

            List<Producto> productos = new List<Producto>();
            foreach (long idProducto in listaIdProductos)
            {
                Producto productoTemporal = ObtenerProductoPorId(idProducto);
                productos.Add(productoTemporal);
            }

            return productos;
        }

    }
}
