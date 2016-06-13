using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Interfaz_Proyecto_Integrador
{
    class Parseador
    {
        public List<Inventario> InventarioCast(List<Object> lstObj)
        {
            List<Inventario> list = new List<Inventario>();
            foreach (Object obj in lstObj)
            {
                Inventario RegistroInventario = JsonConvert.DeserializeObject<Inventario>(obj.ToString());
                list.Add(RegistroInventario);
            }
            return list;
        }
        public List<Empleado> EmpleadosCast(List<Object> lstObj)
        {
            List<Empleado> list = new List<Empleado>();
            foreach (Object obj in lstObj)
            {
                Empleado RegistroInventario = JsonConvert.DeserializeObject<Empleado>(obj.ToString());
                list.Add(RegistroInventario);
            }
            return list;
        }
    }
}
