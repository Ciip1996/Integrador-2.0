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
        protected List<Object> content;
        public override async Task getAll(string url)
        {
            this.response = await httpClient.GetAsync(url);
            this.response.EnsureSuccessStatusCode();
            content = await response.Content.ReadAsAsync<List<Object>>();
        }
        public override async Task getAllByParameter(string url, string parameter)
        {
            this.response = await httpClient.GetAsync(url + parameter);
            this.response.EnsureSuccessStatusCode();
            content = await response.Content.ReadAsAsync<List<Object>>();
        }
        public override async Task postObject(string url, Object empleadoAlta)
        {
            var httpClient = new HttpClient();
            var response = httpClient.PostAsJsonAsync(url, empleadoAlta).Result;
            response.EnsureSuccessStatusCode();
            Object content = await response.Content.ReadAsAsync<Object>();
        }
        public override async Task putObject(string url, Object empleado) {
            var httpClient = new HttpClient();
            var response = httpClient.PutAsJsonAsync(url, empleado).Result;
            //new Empleado {Nombre = "Mail",Contraseña = "caca",Pregunta = "hotmail?",Respuesta = "si",Estatus = 1,FechaIngreso = Convert.ToDateTime("1999-09-09"),FechaEgreso = Convert.ToDateTime("2000-11-10"),Puesto = 1 
            response.EnsureSuccessStatusCode();
            Object content = await response.Content.ReadAsAsync<Object>();
        }
        public List<Object> getContent()
        {
            return content;
        }
        public HttpResponseMessage getResponse()
        {
            return this.response;
        }

    }
}
