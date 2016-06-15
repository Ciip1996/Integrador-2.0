using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesProyecto
{
    public class Catalogo
    {
        public string Codigo { get; set; }
        public string Estilo { get; set; }
        public string Foto { get; set; }
        public int Marca { get; set; }
        public float PrecioVenta { get; set; }
        public float PrecioCompra { get; set; }
        public string Descripcion { get; set; }
        public int Estatus { get; set; }
    }
    public enum Marca
    {
        Pekes = 1,
        Picolin = 2,
        WomenIntuition = 3,
        Aleba = 4,
    }
    public enum Estatus
    {
        habil = 1,
        descontinuado = 0
    }
}
