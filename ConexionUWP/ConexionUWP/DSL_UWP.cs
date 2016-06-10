using ConexionUWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConexionUWP
{
    public class DSL_UWP : DAL_UWP
    {
        protected HttpClient httpClient = new HttpClient();
        protected HttpResponseMessage response = new HttpResponseMessage();
        protected List<Inventario> Inventario = new List<Inventario>();

        public override async Task solicitarInventario(string url)
        {
            this.response = await httpClient.GetAsync(url);
            this.response.EnsureSuccessStatusCode();
            Inventario = await response.Content.ReadAsAsync<List<Inventario>>();
        }
        /*public async Task AltaInventario(string url, string inventario)
        {
            this.response = await httpClient.GetAsync(url + inventario);
            this.response.EnsureSuccessStatusCode();
            Inventario = await response.Content.ReadAsAsync<List<Inventario>>();
        }*/
        public List<Inventario> obtenerInventario()
        {
            return Inventario;
        }
        public HttpResponseMessage getResponse()
        {
            return this.response;
        }

    }
}
