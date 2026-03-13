using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSSCH_ADSI2026.Facturacion
{
    public class Factura
    {
        public int Id { get; set; }
        public int NumeroFactura { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }
        public bool Pagada { get; set; }

    }
}
