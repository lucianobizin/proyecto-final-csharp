using proyecto_final_csharp.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_csharp.controllers
{
    public static class ManipuladorUsuario 
    {

        public static Usuario ObtenerUsuario(long id)
        {
            Usuario usuario = new Usuario();
            using (SqlConnection conn = ConnectionHandler.ConnectToDb())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Usuario WHERE Id=@id", conn);
                SqlParameter idParameter = new SqlParameter();
                idParameter.ParameterName = "id";
                idParameter.SqlDbType = SqlDbType.BigInt;
                idParameter.Value = id;

                command.Parameters.Add(idParameter);

                //ConnectionHandler.OpenConnection();
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        usuario.Id = reader.GetInt64(0);
                        usuario.Nombre = reader.GetString(1);
                        usuario.Apeliido = reader.GetString(2);
                        usuario.NombreUsuario = reader.GetString(3);
                        usuario.Contraseña = reader.GetString(4);
                        usuario.Mail = reader.GetString(5);
                    }
                }
                return usuario;
            }
        }

        public static Usuario Login (string usuario, string password)
        {
            Usuario user = new Usuario();
            using (SqlConnection conn = ConnectionHandler.ConnectToDb())
            {

                SqlCommand command = new SqlCommand("SELECT * FROM Usuario WHERE NombreUsuario=@NombreUsuario AND Contraseña=@Contraseña", conn);
                SqlParameter idParameterUsuario = new SqlParameter();
                idParameterUsuario.ParameterName = "NombreUsuario";
                idParameterUsuario.SqlDbType = SqlDbType.VarChar;
                idParameterUsuario.Value = usuario;

                command.Parameters.Add(idParameterUsuario);

                SqlParameter idParameterContraseña = new SqlParameter();
                idParameterContraseña.ParameterName = "Contraseña";
                idParameterContraseña.SqlDbType = SqlDbType.VarChar;
                idParameterContraseña.Value = password;

                command.Parameters.Add(idParameterContraseña);

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user.Id = reader.GetInt64(0);
                        user.Nombre = reader.GetString(1);
                        user.Apeliido = reader.GetString(2);
                        user.NombreUsuario = reader.GetString(3);
                        user.Contraseña = reader.GetString(4);
                        user.Mail = reader.GetString(5);
                    }

                    return user;
                }
            }

            return null;
        }
    }
}
