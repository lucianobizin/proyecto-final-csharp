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

        public static int InsertarProducto(Producto producto)
        {
            using (SqlConnection conn = ConnectionHandler.ConnectToDb())
            {
                SqlCommand command = new SqlCommand("INSERT INTO Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario) VALUES (@descripciones, @costo, @precioVenta, @stock, @idUsuario)", conn);

                SqlParameter idParameterDescripciones = new SqlParameter();
                idParameterDescripciones.ParameterName = "descripciones";
                idParameterDescripciones.SqlDbType = SqlDbType.VarChar;
                idParameterDescripciones.Value = producto.Descripciones;

                SqlParameter idParameterCosto = new SqlParameter();
                idParameterCosto.ParameterName = "costo";
                idParameterCosto.SqlDbType = SqlDbType.Money;
                idParameterCosto.Value = producto.Costo;

                SqlParameter idParameterPrecioVenta = new SqlParameter();
                idParameterPrecioVenta.ParameterName = "precioVenta";
                idParameterPrecioVenta.SqlDbType = SqlDbType.Money;
                idParameterPrecioVenta.Value = producto.PrecioVenta;

                SqlParameter idParameterStock = new SqlParameter();
                idParameterStock.ParameterName = "stock";
                idParameterStock.SqlDbType = SqlDbType.Int;
                idParameterStock.Value = producto.Stock;

                SqlParameter idParameterIdUsuario = new SqlParameter();
                idParameterIdUsuario.ParameterName = "idUsuario";
                idParameterIdUsuario.SqlDbType = SqlDbType.BigInt;
                idParameterIdUsuario.Value = producto.IdUsuario;

                command.Parameters.Add(idParameterDescripciones);
                command.Parameters.Add(idParameterCosto);
                command.Parameters.Add(idParameterPrecioVenta);
                command.Parameters.Add(idParameterStock);
                command.Parameters.Add(idParameterIdUsuario);

                conn.Open();

                return command.ExecuteNonQuery();
            }
        }

        public static int ModificarProducto(Producto productoModificado)
        {
            using (SqlConnection conn = ConnectionHandler.ConnectToDb())
            {
                SqlCommand command = new SqlCommand("UPDATE Producto SET Descripciones=@descripciones, Costo=@costo, PrecioVenta=@precioVenta, Stock=@stock, IdUsuario=@idUsuario WHERE Id=@id", conn);

                SqlParameter idParameterId = new SqlParameter();
                idParameterId.ParameterName = "id";
                idParameterId.SqlDbType = SqlDbType.BigInt;
                idParameterId.Value = productoModificado.Id;

                SqlParameter idParameterDescripciones = new SqlParameter();
                idParameterDescripciones.ParameterName = "descripciones";
                idParameterDescripciones.SqlDbType = SqlDbType.VarChar;
                idParameterDescripciones.Value = productoModificado.Descripciones;

                SqlParameter idParameterCosto = new SqlParameter();
                idParameterCosto.ParameterName = "costo";
                idParameterCosto.SqlDbType = SqlDbType.Money;
                idParameterCosto.Value = productoModificado.Costo;

                SqlParameter idParameterPrecioVenta = new SqlParameter();
                idParameterPrecioVenta.ParameterName = "precioVenta";
                idParameterPrecioVenta.SqlDbType = SqlDbType.Money;
                idParameterPrecioVenta.Value = productoModificado.PrecioVenta;

                SqlParameter idParameterStock = new SqlParameter();
                idParameterStock.ParameterName = "stock";
                idParameterStock.SqlDbType = SqlDbType.Int;
                idParameterStock.Value = productoModificado.Stock;

                SqlParameter idParameterIdUsuario = new SqlParameter();
                idParameterIdUsuario.ParameterName = "idUsuario";
                idParameterIdUsuario.SqlDbType = SqlDbType.BigInt;
                idParameterIdUsuario.Value = productoModificado.IdUsuario;

                command.Parameters.Add(idParameterId);
                command.Parameters.Add(idParameterDescripciones);
                command.Parameters.Add(idParameterCosto);
                command.Parameters.Add(idParameterPrecioVenta);
                command.Parameters.Add(idParameterStock);
                command.Parameters.Add(idParameterIdUsuario);

                conn.Open();

                return command.ExecuteNonQuery();
            }
        }

        public static int EliminarProducto(long id)
        {
            using (SqlConnection conn = ConnectionHandler.ConnectToDb())
            {
                SqlCommand command = new SqlCommand("DELETE FROM Producto WHERE Id=@id", conn);

                SqlParameter idParameterId = new SqlParameter();
                idParameterId.ParameterName = "id";
                idParameterId.SqlDbType = SqlDbType.Int;
                idParameterId.Value = id;

                command.Parameters.Add(idParameterId);

                conn.Open();

                return command.ExecuteNonQuery();
            }
        }



    }
}
