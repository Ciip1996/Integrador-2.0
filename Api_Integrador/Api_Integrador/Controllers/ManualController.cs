using Api_Integrador.Models;
using RNConexion.ISSC211.DataStorageLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api_Integrador.Controllers
{
    public class ManualController : ApiController
    {
        // GET: api/Manual
        public IEnumerable<Manual> Get()
        {
            Manual manual = new Manual();
            List<Manual> listaManual = new List<Manual>();
            DSL conexion = new DSL();
            bool cn = conexion.Open("Data Source = DESKTOP-8KVESM0\\SQLEXPRESS; Initial Catalog=IntegradorBD; User Id = sa ; Password = 123; ", RNConexion.ISSC211.DataAbstractionLayer.enumProveedor.SQLServer);
            conexion.InitialSQLStatment("SELECT * FROM dbo.obtenerManual()", System.Data.CommandType.Text);
            DataTable table = conexion.ReturnTable();
            foreach (DataRow item in table.Rows)
            {
                manual = new Manual();
                manual.Id = int.Parse(item[0].ToString());
                manual.Url = item[1].ToString();
                manual.Instruccion = item[2].ToString();
                listaManual.Add(manual);
            }
            return listaManual;
        }
    }
}
