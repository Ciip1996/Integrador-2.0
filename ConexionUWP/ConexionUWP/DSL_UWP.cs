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
        /*public override async Task put(string url, Object obj) {
            this.response = await httpClient.GetAsync(url);
        }
        public override async Task post(string url, int id)
        {
            this.response = await httpClient.GetAsync(url);
        }*/
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
