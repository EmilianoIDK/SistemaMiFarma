﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class entUsuario
    {
        public int idUsuario { get; set; }
        public int dni { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string tipoUsuario { get; set; }
        public int telefono { get; set; }
        public Boolean estado { get; set; }
    }
}
