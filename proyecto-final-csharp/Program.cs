namespace proyecto_final_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}