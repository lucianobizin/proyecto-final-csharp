using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_csharp.models
{
    public class Producto
    {
        public long Id { get; set; }
        public string Descripciones { get; set; } = string.Empty;
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public long IdUsuario { get; set; }

    }
}
