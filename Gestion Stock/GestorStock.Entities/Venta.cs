using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorStock.Entities
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public int UsuarioId { get; set; }
    }
}
