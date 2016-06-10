using ConexionUWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConexionUWP
{
    public abstract class DAL_UWP
    {
        /*Atributos Protegidos*/

        /*Metodos Publicos*/
        public abstract Task solicitarInventario(string url);
    }
}
