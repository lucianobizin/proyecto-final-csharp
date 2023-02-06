using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_csharp.models
{
    public class Venta
    {
        public long Id { get; set; }
        public string Comentarios { get; set; }
        public long IdUsuario { get; set; }

    }
}
