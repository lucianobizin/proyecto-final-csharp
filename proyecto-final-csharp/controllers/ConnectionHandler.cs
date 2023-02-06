using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_csharp.controllers
{
    public static class ConnectionHandler
    {
        public static SqlConnection ConnectToDb()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HF9696H\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                return conn;
                
            }

            catch (Exception ex)
            {
                Console.WriteLine("" + ex.Message);
                SqlConnection returncode = new SqlConnection();
                return returncode;
            }
        }

        //public SqlConnection OpenConnection()
        //{
        //    try
        //    {
        //        ConnectToDb().Open();
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("" + ex.Message);
        //        SqlConnection returncode = new SqlConnection();
        //        return returncode;
        //    }
        //}

        //"SELECT * FROM Usuario WHERE id=@id"




    }
}
