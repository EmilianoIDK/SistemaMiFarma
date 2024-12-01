using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class entFactura
    {
        public int id_ComprobanteVenta { get; set; }
        public entEmpresa empresa { get; set; }
        public entUsuario cliente { get; set; }
        public string tipo_comprobante { get; set; }
        public string numero_comprobante { get; set; }

        public double total { get; set; }
        public string fecha { get; set; }
    }
}
