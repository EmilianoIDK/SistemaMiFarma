using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class entEmpresa
    {
        public int idEmpresa { get; set; }
        public int RUC { get; set; }    
        public string razon_social { get; set; }
        public string direccion { get; set; }

        public int celular { get; set; }
        public int telefono { get; set; }
        public Boolean estado { get; set; }
    }
}
