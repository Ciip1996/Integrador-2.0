using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace apiCustomer.Controllers
{
    public class claseNuevaController : ApiController
    {
        // GET: api/claseNueva
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/claseNueva/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/claseNueva
        public void Post(Uri url)
        {
            Uri x = url;
        }

        // PUT: api/claseNueva/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/claseNueva/5
        public void Delete(int id)
        {
        }
    }
}
