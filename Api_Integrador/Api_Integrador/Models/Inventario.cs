﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Integrador.Controllers
{
    public class Inventario
    {
        public int NoEntrada { get; set; }
        public string Codigo { get; set; }
        public int Cantidad { get; set; }
        public int Categoria { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Observaciones { get; set; }
        public int Estatus { get; set; }
    }
}