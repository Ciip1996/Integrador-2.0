using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesProyecto
{
    public class Parseador
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
        public List<String> contraseñaCast(List<Object> lstObj)
        {
            List<String> list = new List<String>();
            foreach (Object obj in lstObj)
            {
                String cadena = JsonConvert.DeserializeObject<String>(obj.ToString());
                list.Add(cadena);
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
