using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiCustomer.Models
{
    public class CustomerModel
    {
        public int NoEntrada { get; set; }
        public string Codigo { get; set; }
        public string Estilo { get; set; }
        public int cantidad { get; set; }
        public int categoria { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Observaciones { get; set; }
        public int estatus { get; set; }
    }
}