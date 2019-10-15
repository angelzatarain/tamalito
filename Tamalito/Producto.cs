using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamalito
{
    class Producto
    {
        public int IdProducto { get; set; }
        public int costo { get; set; }
        public int inventario { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public String categoria { get; set; }
        public String urlImagen { get; set; }
        public int tiempoPreparacion { get; set; }

    }
}
