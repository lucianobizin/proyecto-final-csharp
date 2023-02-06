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
    }
}
