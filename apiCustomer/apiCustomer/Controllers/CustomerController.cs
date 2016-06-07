using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiCustomer.Models;//se pone el using el nombre del proyecto y su modelos
using RNConexion.ISSC211.DataAbstractionLayer;
using RNConexion.ISSC211.DataStorageLayer;
using System.Data;

namespace apiCustomer.Controllers
{
    public class CustomerController : ApiController
    {
        // GET: api/Customer
        public IEnumerable<CustomerModel> Get()//se pone el tipo CustomerModel o la clase que se va a enviar
        {
            List<CustomerModel> listaObj = new List<CustomerModel>();
            CustomerModel objeto = new CustomerModel();
            DSL conexion = new DSL();
            bool cn = conexion.Open("Data Source = DESKTOP-8KVESM0\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id=sa; Password = 123", RNConexion.ISSC211.DataAbstractionLayer.enumProveedor.SQLServer);
            conexion.InitialSQLStatment("dbo.consultaInventario", System.Data.CommandType.StoredProcedure);
            //conexion.SetParameterProcedure("@nombre", System.Data.ParameterDirection.Input, enumTipo.Cadena, "Ivan");
            DataTable table = conexion.ReturnTable();
            foreach (DataRow Obj in table.Rows)
            {
                objeto = new CustomerModel();
                objeto.NoEntrada = int.Parse(Obj[0].ToString());
                objeto.Codigo = Obj[1].ToString();
                objeto.Estilo = Obj[2].ToString();
                objeto.cantidad = int.Parse(Obj[3].ToString());
                objeto.categoria = int.Parse(Obj[4].ToString());
                objeto.FechaEntrada = (DateTime)Obj[5];
                try {
                    objeto.FechaSalida = (DateTime)Obj[6];
                }
                catch (Exception e) {
                  
                }
                try
                {
                    objeto.Observaciones = Obj[7].ToString();
                }
                catch (Exception e)
                {

                }
                try
                {
                    objeto.estatus = int.Parse(Obj[8].ToString());
                }
                catch (Exception e)
                {

                }
                listaObj.Add(objeto);
            }
            return listaObj;
        }

        // GET: api/Customer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
        }
    }
}
