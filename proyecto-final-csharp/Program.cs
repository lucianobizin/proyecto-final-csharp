using proyecto_final_csharp.controllers;
using proyecto_final_csharp.models;

namespace proyecto_final_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Primer Pre-Entrega del proyecto final
            ////---------------------------------------------
            ////EJERCICIO 1

            ////Simulación del front end del primer ejercicio(traer usuario con el id de usuario)

            ////models.Usuario user1 = new models.Usuario();
            ////user1 = controllers.ManipuladorUsuario.ObtenerUsuario(1);
            ////Console.WriteLine("----------\n\n" + $"ID: {user1.Id}\n" + $"Nombre: {user1.Nombre}\n"
            ////    + $"Apellido: {user1.Apeliido}\n" + $"Nombre de Usuario: {user1.NombreUsuario}\n"
            ////    + $"Contraseña: {user1.Contraseña}\n" + $"Email: {user1.Mail}\n\n" + "----------");


            ////---------------------------------------------
            ////EJERCICIO 2
            ///
            ////Simulación del front end del segundo ejercicio (traer producto mediante un IdUsuario)

            //Console.WriteLine("Obtener todos los productos cargados por Usuario: ");
            //long Usuario = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine($"\n\nEstos son los productos obtenidos por {Usuario}\n\n");
            //foreach (var item in controllers.ManipuladorProducto.ObtenerProducto(Usuario))
            //{
            //    Console.WriteLine("\n\n----------\n\n" + $"ID: {item.Id}\n" + $"Descripciones: {item.Descripciones}\n"
            //    + $"Costo: {item.Costo}\n" + $"PrecioVenta: {item.PrecioVenta}\n"
            //    + $"Stock: {item.Stock}\n" + $"IdUsuario: {item.IdUsuario}\n\n" + "----------");
            //}


            ////---------------------------------------------
            //// EJERCICIO 3

            ///Simulación del front end del tercer ejercicio (traer productos vendidos por id de usuario)

            //Console.WriteLine("Obtener todos los productos vendidos por Usuario: ");
            //long Usuario = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine($"\n\nEstos son los productos vendidos por {Usuario}\n");
            //List<models.Producto> productosVendidos = controllers.ManipuladorProducto.ObtenerProductosVendidosPorUsuario(Usuario);
            //foreach (models.Producto productosVendido in productosVendidos)
            //{
            //    Console.WriteLine("----------\n\n" + $"ID: {productosVendido.Id}\n" + $"Descripciones: {productosVendido.Descripciones}\n" + "----------");
            //}


            ////---------------------------------------------
            //// EJERCICIO 4

            ////Simulación del front end del cuarto ejercicio (traer ventas por id de usuario)

            //Console.WriteLine("Obtener todos las ventas por Usuario: ");
            //long Usuario = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine($"\n\nEstos son las ventas de {Usuario}\n");
            //List<models.ProductoVendido> productosVendidos = controllers.ManipuladorProductoVendido.ObtenerVentasPorIdUsuario(Usuario);
            //foreach (models.ProductoVendido productosVendido in productosVendidos)
            //{
            //    Console.WriteLine("----------\n\n" + $"ID: {productosVendido.Id}\n" + $"Stock: {productosVendido.Stock}\n"
            //       + $"IdProducto: {productosVendido.IdProducto}\n" + $"IdVenta: {productosVendido.IdVenta}\n" + "----------");
            //}


            ////---------------------------------------------
            //// EJERCICIO 5

            ////Simulación del front end del quinto ejercicio (traer usuario mediante NombreUsuario y Contraseñar)

            //Console.WriteLine("Ingrese el nombre de usuario: ");
            //string Usuario = Console.ReadLine();
            //Console.WriteLine("Ingrese la contraseña: ");
            //string Contraseña = Console.ReadLine();

            //models.Usuario usuarioLogueado = new models.Usuario();
            //usuarioLogueado = controllers.ManipuladorUsuario.Login(Usuario, Contraseña);
            //if (usuarioLogueado == null)
            //{
            //    Console.WriteLine("Passw o usuario incorrectos");
            //}
            //else
            //{
            //    Console.WriteLine("Bienvenido " + usuarioLogueado.NombreUsuario);

            //}

            //// --------------------------------------
            //// ENTREGA DE CLASE 15
            //// ---------------------------------------------

            //// EJERCICIO 1

            ////Simulación del front end del primer ejercicio (modificar usuario)

            //Usuario usuarioModificado = new Usuario();
            //usuarioModificado.Id = 2;
            //usuarioModificado.Nombre = "Luciano";
            //usuarioModificado.Apellido = "Bizin";
            //usuarioModificado.NombreUsuario = "lbizin";
            //usuarioModificado.Contraseña = "SoyLucianoBizin";
            //usuarioModificado.Mail = "lucianob@gmail.com";


            //if (ManipuladorUsuario.ModificarUsuario(usuarioModificado) >= 1)
            //{
            //    Console.WriteLine("Usuario modificado");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo modificar el usuario");
            //}

            //Usuario usuarioModificado2 = new Usuario();
            //usuarioModificado2.Id = 2;
            //usuarioModificado2.Nombre = "Ernesto";
            //usuarioModificado2.Apellido = "Perez";
            //usuarioModificado2.NombreUsuario = "eperez";
            //usuarioModificado2.Contraseña = "SoyErnestoPerez";
            //usuarioModificado2.Mail = "ernestoperez@gmail.com";


            //if (ManipuladorUsuario.ModificarUsuario(usuarioModificado2) >= 1)
            //{
            //    Console.WriteLine("Usuario modificado");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo modificar el usuario");
            //}

            //// EJERCICIO 2

            ////Simulación del front end del segundo ejercicio (insertar producto)

            //Producto productoAInsertar = new Producto();
            //productoAInsertar.Descripciones = "Campera Nike";
            //productoAInsertar.Costo = 9000;
            //productoAInsertar.PrecioVenta = 12000;
            //productoAInsertar.Stock = 99;
            //productoAInsertar.IdUsuario = 2;

            //if (ManipuladorProducto.InsertarProducto(productoAInsertar) >= 1)
            //{
            //    Console.WriteLine("Producto insertado");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo insertar el producto");
            //}

            //// EJERCICIO 3

            ////Simulación del front end del tercer ejercicio (modificar producto)

            //Producto productoAModificar = new Producto();
            //productoAModificar.Id = 8;
            //productoAModificar.Descripciones = "Campera Nike";
            //productoAModificar.Costo = 15000;
            //productoAModificar.PrecioVenta = 30000;
            //productoAModificar.Stock = 99;
            //productoAModificar.IdUsuario = 2;

            //if (ManipuladorProducto.ModificarProducto(productoAModificar) >= 1)
            //{
            //    Console.WriteLine("Producto modificado");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo modificar el producto");
            //}

            //// EJERCICIO 4

            ////Simulación del front end del cuarto ejercicio (eliminar producto)

            //if (ManipuladorProducto.EliminarProducto(Convert.ToInt64(7)) >= 1)
            //{
            //    Console.WriteLine("Producto eliminado");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo eliminar el producto");
            //}

        }
    }
}