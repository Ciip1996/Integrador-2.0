using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Integrador.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
        public int Puesto { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Estatus { get; set; }
        public DateTime FechaEgreso { get; set; }
    }
}
