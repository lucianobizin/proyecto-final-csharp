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
    public static class ManipuladorProductoVendido
    {
        public static List<ProductoVendido> ObtenerVentasPorIdUsuario(long idUsuario)
        {
            List<ProductoVendido> listaIdProductos = new List<ProductoVendido>();

            using (SqlConnection conn = ConnectionHandler.ConnectToDb())
            {
                Producto producto = new Producto();
                SqlCommand command = new SqlCommand("SELECT ProductoVendido.* FROM ProductoVendido INNER JOIN Venta ON Venta.Id = ProductoVendido.IdVenta WHERE Venta.IdUsuario = @idUsuario", conn);
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
                        ProductoVendido productoVendidoTempo = new ProductoVendido();
                        productoVendidoTempo.Id = reader.GetInt64(0);
                        productoVendidoTempo.Stock = reader.GetInt32(1);
                        productoVendidoTempo.IdProducto = reader.GetInt64(2);
                        productoVendidoTempo.IdVenta = reader.GetInt64(3);

                        listaIdProductos.Add(productoVendidoTempo);
                    }
                }
            }

            return listaIdProductos;
        }

        public static int IngresarProductoVendido(ProductoVendido nuevoProductoVendido)
        {
            using (SqlConnection conn = ConnectionHandler.ConnectToDb())
            {
                SqlCommand command = new SqlCommand("INSERT INTO ProductoVendido (Stock, IdProducto, IdVenta) VALUES (@stock, @idProducto, @idVenta)", conn);

                SqlParameter idParameterStock = new SqlParameter();
                idParameterStock.ParameterName = "stock";
                idParameterStock.SqlDbType = SqlDbType.VarChar;
                idParameterStock.Value = nuevoProductoVendido.Stock;

                SqlParameter idParameterIdProducto = new SqlParameter();
                idParameterIdProducto.ParameterName = "idProducto";
                idParameterIdProducto.SqlDbType = SqlDbType.BigInt;
                idParameterIdProducto.Value = nuevoProductoVendido.IdProducto;

                SqlParameter idParameterIdventa = new SqlParameter();
                idParameterIdventa.ParameterName = "idVenta";
                idParameterIdventa.SqlDbType = SqlDbType.BigInt;
                idParameterIdventa.Value = nuevoProductoVendido.IdVenta;

                command.Parameters.Add(idParameterStock);
                command.Parameters.Add(idParameterIdProducto);
                command.Parameters.Add(idParameterIdventa);

                conn.Open();

                return command.ExecuteNonQuery();
            }
        }
    }
}
