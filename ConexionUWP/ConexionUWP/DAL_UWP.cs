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
        public abstract Task getAll(string url);
        public abstract Task getAllByParameter(string url, string parameter);
        /*public abstract Task put(string url, int id, Object obj);
        public abstract Task post(string url, Object id);*/
    }
}
